using AutoMapper;
using MoviesProject.Shared.Entity;
namespace MoviesProject.Server.Storage
{
    public class AutoMapperRegisters:Profile
    {
        public AutoMapperRegisters()
        {
            CreateMap<Actor, Actor>().ForMember(x=>x.Picture, option=>option.Ignore());
            CreateMap<Movie, Movie>().ForMember(x=>x.MovieImage, option=>option.Ignore());
        }
    }
}