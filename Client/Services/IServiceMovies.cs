using System.Threading.Tasks;
using System.Security.AccessControl;
using MoviesProject.Shared.Entity;
using System.Collections.Generic;
namespace MoviesProject.Client.Services
{
    public interface IServiceMovies
    {
         List<Movie> GetMovies();
         Task<HttpResponseWrapper<object>> Post<T>(string url, T send);
        Task<HttpResponseWrapper<TResponse>> Post<T,TResponse>(string url, T send);
        Task<HttpResponseWrapper<object>> Put<T>(string utl, T send);
         Task<HttpResponseWrapper<T>> Get<T>(string url);
         Task<HttpResponseWrapper<object>> Delete(string url);
    }
}