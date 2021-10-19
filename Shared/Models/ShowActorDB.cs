using System.Collections.Generic;
using MoviesProject.Shared.Entity;

namespace MoviesProject.Shared.Models
{
    public class ShowActorDB
    {
        public Actor Actor {get;set;}
        public List<Movie> Movies {get;set;}
    }
}