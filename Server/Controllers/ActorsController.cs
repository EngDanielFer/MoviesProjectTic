using MoviesProject.Shared.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesProject.Server.Storage;
using MoviesProject.Shared.Configuration;
using MoviesProject.Shared.Models;
using MoviesProject.Client.Pages;

namespace MoviesProject.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ActorsController: ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IFilesStorage FilesStorage;
        /* private readonly string carpeta = "actors"; */

        public ActorsController(ApplicationDbContext context, IFilesStorage filesStorage) {
            this.context = context;
            this.FilesStorage = filesStorage;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Actor actor)
        {
            if (!string.IsNullOrWhiteSpace(actor.Picture))
            {
                var actor_photo = Convert.FromBase64String(actor.Picture);
                actor.Picture = await FilesStorage.SaveFile(actor_photo, ".jpg", "actors");
            }
            context.Add(actor);
            await context.SaveChangesAsync();
            return actor.Id;
        }

        [HttpGet]
        public async Task<ActionResult<List<Actor>>> Get([FromQuery] Pagination pagination)
        {
            var queryable = context.Actors.AsQueryable();
            return await queryable.Paginar(pagination).ToListAsync();
        }

        [HttpGet("search/{text}")]
        public async Task<ActionResult<List<Actor>>> Get(string text)
        {
            /* Filtrar los actores por el nombre */
            if (string.IsNullOrWhiteSpace(text))
            {
                return new List<Actor>();
            }
            text = text.ToLower();
            return await context.Actors.Where(x=>x.ActorName.ToLower().Contains(text)).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ShowActorDB>> Get (int id){
            var actor = await context.Actors.Where(x=>x.Id == id)
            .Include(x => x.MoviesActor).ThenInclude(x => x.Movie).FirstOrDefaultAsync();
            if (actor == null)
            {
                return NotFound();
            }
            actor.MoviesActor = actor.MoviesActor.OrderBy(x => x.OrderCredits).ToList();
            var model = new ShowActorDB();
            model.Actor = actor;
            model.Movies = actor.MoviesActor.Select(x=> new Movie
            {
                MovieTitle = x.Movie.MovieTitle,
                MovieImage = x.Movie.MovieImage,
                Id = x.Movie.Id
            }).ToList();
            return model;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Actor actor){
            var actorDB = await context.Actors.FirstOrDefaultAsync(x=>x.Id == actor.Id);
            if (actorDB == null)
            {
                return NotFound();
            }
            if (!string.IsNullOrWhiteSpace(actor.Picture))
            {
               var newPhotoActor = Convert.FromBase64String(actor.Picture);
               actorDB.Picture = await  FilesStorage.EditFile(newPhotoActor, "jpg","actors", actorDB.Picture);
            }
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete (int id){
            var actorExist = await context.Actors.AnyAsync(x=>x.Id == id);
            if (!actorExist)
            {
                return NotFound();
            }
            context.Remove(new Actor{Id = id});
            await context.SaveChangesAsync();
            return NoContent();
        }

    }
}