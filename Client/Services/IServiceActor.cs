using MoviesProject.Shared.Entity;
using System.Collections.Generic;
namespace MoviesProject.Client.Services
{
    public interface IServiceActor
    {
         List<Actor> GetActors();
    }
}