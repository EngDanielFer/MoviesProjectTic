namespace MoviesProject.Shared.Entity
{
    public class MovieActor
    {
        public int ActorId {get;set;}
        public int MovieId {get;set;}
        public Actor Actor {get;set;}
        public Movie Movie {get;set;}
        /* Campos adicionales */
        public int OrderCredits {get;set;}
        public string Character {get;set;}
    }
}