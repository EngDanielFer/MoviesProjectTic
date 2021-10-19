using System.Collections.Generic;
using MoviesProject.Shared.Entity;

namespace MoviesProject.Shared.Models
{
    public class FilterMovie
    {
        public List<Movie> PeliculasEnCartelera {get;set;}
        public List<Movie> ProximosEstrenos {get;set;}
    }
}