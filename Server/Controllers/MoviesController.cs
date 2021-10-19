using System.Collections.Generic;
using MoviesProject.Shared.Entity;
using MoviesProject.Shared.Models;
using MoviesProject.Shared.Configuration;
using AutoMapper;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesProject.Server.Storage;
using MoviesProject.Client.Pages;

namespace MoviesProject.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IFilesStorage FilesStorage;
        /* Carpeta para el almacenamiento local de multimedia */
        private readonly string carpeta = "movies";
        private readonly IMapper mapper;

        public MoviesController(ApplicationDbContext context, IFilesStorage filesStorage, IMapper mapper)
        {
            this.context = context;
            this.FilesStorage = filesStorage;
            this.mapper = mapper;
        }

        /* Almacenar info de película */
        [HttpPost]
        public async Task<ActionResult<int>> Post(Movie movie)
        {
            if (!string.IsNullOrWhiteSpace(movie.MovieImage))
            {
                var movie_poster = Convert.FromBase64String(movie.MovieImage);
                movie.MovieImage = await FilesStorage.SaveFile(movie_poster, ".jpg", carpeta);
            }
            context.Add(movie);
            await context.SaveChangesAsync();
            return movie.Id;
        }

        /* Listar películas por cartelera y próximos estrenos */
        [HttpGet]
        public async Task<ActionResult<FilterMovie>> Get()
        {
            var limit = 10;
            var pelisEnCartelera = await context.Movies.Where(x => x.EnCartelera).Take(limit).OrderByDescending(x => x.PremiereDate).ToListAsync();
            var currentDate = DateTime.Today;
            var proximosEstrenos = await context.Movies.Where(x => x.PremiereDate > currentDate).OrderBy(x => x.PremiereDate).Take(limit).ToListAsync();
            var response = new FilterMovie()
            {
                PeliculasEnCartelera = pelisEnCartelera,
                ProximosEstrenos = proximosEstrenos
            };
            return response;
        }

        /* Consultar por un registro determinado */
        [HttpGet("{id}")]
        public async Task<ActionResult<ShowMovieDB>> Get(int id)
        {
            var movie = await context.Movies.Where(x => x.Id == id)
            .Include(x => x.CategoriesMovie).ThenInclude(x => x.Category)
            .Include(x => x.MoviesActor).ThenInclude(x => x.Actor).FirstOrDefaultAsync();
            if (movie == null)
            {
                return NotFound();
            }
            var avgVote = 5;
            var voteUser = 5;
            movie.MoviesActor = movie.MoviesActor.OrderBy(x => x.OrderCredits).ToList();
            var model = new ShowMovieDB();
            model.Movie = movie;
            model.Categories = movie.CategoriesMovie.Select(x => x.Category).ToList();
            model.Actors = movie.MoviesActor.Select(x => new Actor
            {
                ActorName = x.Actor.ActorName,
                Picture = x.Actor.Picture,
                Character = x.Character,
                Id = x.ActorId
            }).ToList();
            model.AvgVote = avgVote;
            model.UserVote = voteUser;
            return model;
        }

        public class ParametrosBusqueda
        {
            public int Pagina { get; set; } = 1;
            public int CantidadRegistros { get; set; } = 10;
            public Pagination Pagination
            {
                get
                {
                    return new Pagination()
                    {
                        Pagina = Pagina,
                        CantidadRegistros = CantidadRegistros
                    };
                }
            }
            public string Name { get; set; }
            public int CategoryId { get; set; }
            public bool EnCartelera { get; set; }
            public bool MasVotadas { get; set; }
        }

        [HttpGet("searchMovie")]
        public async Task<ActionResult<List<Movie>>> Get([FromQuery] ParametrosBusqueda parametrosBusqueda)
        {
            var movieQuery = context.Movies.AsQueryable();
            if (!string.IsNullOrWhiteSpace(parametrosBusqueda.Name))
            {
                movieQuery = movieQuery.Where(x => x.MovieTitle.ToLower().Contains(parametrosBusqueda.Name.ToLower()));
            }
            if (parametrosBusqueda.EnCartelera)
            {
                movieQuery = movieQuery.Where(x => x.EnCartelera);
            }

            if (parametrosBusqueda.CategoryId != 0)
            {
                movieQuery = movieQuery.Where(x => x.CategoriesMovie.Select(y => y.CategoryId).Contains(parametrosBusqueda.CategoryId));
            }
            var movies = await movieQuery.Paginar(parametrosBusqueda.Pagination).ToListAsync();
            return movies;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Movie movie)
        {
            var movieDB = await context.Movies.FirstOrDefaultAsync(x => x.Id == movie.Id);
            if (movieDB == null)
            {
                return NotFound();
            }
            movieDB = mapper.Map(movie, movieDB);
            if (!string.IsNullOrWhiteSpace(movie.MovieImage))
            {
                var posterM = Convert.FromBase64String(movie.MovieImage);
                movieDB.MovieImage = await FilesStorage.EditFile(posterM, "jpg", "movies", movieDB.MovieImage);
            }
            await context.Database.ExecuteSqlInterpolatedAsync($"delete from CategoriesMovie WHERE MovieId = {movie.Id}; delete from MoviesActor where MovieId = {movie.Id}");
            if (movie.MoviesActor != null)
            {
                for (int i = 0; i < movie.MoviesActor.Count; i++)
                {
                    movie.MoviesActor[i].OrderCredits = i + 1;
                }
            }
            movieDB.MoviesActor = movie.MoviesActor;
            movieDB.CategoriesMovie = movie.CategoriesMovie;
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpGet("edit/{id}")]
        public async Task<ActionResult<PutMovie>> PutGet(int id)
        {
            var peliculaActionResult = await Get(id);
            if (peliculaActionResult.Result is NotFoundResult)
            {
                return NotFound();
            }
            var peliculaVisualizarDTO = peliculaActionResult.Value;
            var generosSeleccionadosIds = peliculaVisualizarDTO.Categories.Select(x => x.Id).ToList();
            var generosNoSeleccionados = await context.Categories
                .Where(x => !generosSeleccionadosIds.Contains(x.Id))
                .ToListAsync();

            var model = new PutMovie();
            model.Movie = peliculaVisualizarDTO.Movie;
            model.CategoriasNoSeleccionadas = generosNoSeleccionados;
            model.CategoriasSeleccionadas = peliculaVisualizarDTO.Categories;
            model.Actors = peliculaVisualizarDTO.Actors;
            return model;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist_movie = await context.Movies.AnyAsync(x => x.Id == id);
            if (!exist_movie)
            {
                return NotFound();
            }
            context.Remove(new Movie { Id = id });
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}