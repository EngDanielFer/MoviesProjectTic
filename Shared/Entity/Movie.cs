using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
namespace MoviesProject.Shared.Entity
{
    public class Movie
    {
        /* public Movie(string movieTitle, string movieSynopsis, string movieGenre, string movieImage, DateTime premiereDate) {
            this.MovieTitle = movieTitle;
            this.MovieSynopsis = movieSynopsis;
            this.MovieGenre = movieGenre;
            this.MovieImage = movieImage;
            this.PremiereDate = premiereDate;
        } */
        public int Id {get;set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string MovieTitle {get;set;}
        public bool EnCartelera {get;set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string MovieSynopsis {get;set;}
        public string MovieImage {get;set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public DateTime? PremiereDate {get;set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Trailer {get;set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        /* public List<CategoryMovie> MovieGenre {get;set;} = new List<CategoryMovie>(); */
        public int Score {get;set;}
        /* public string ShortName
        {
            get{
                if (string.IsNullOrWhiteSpace(MovieTitle))
                {
                    return null;
                }
                if (MovieTitle.Length > 60)
                {
                    return MovieTitle.Substring(0,60) + "...";
                } else
                {
                    return MovieTitle;
                }
            }
        } */
        public List<CategoryMovie> CategoriesMovie {get;set;} = new List<CategoryMovie>();
        public List<MovieActor> MoviesActor {get;set;}
    }
}