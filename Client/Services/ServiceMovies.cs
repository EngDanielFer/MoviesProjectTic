using System;
using MoviesProject.Shared.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MoviesProject.Client.Services
{
    public class ServiceMovies: IServiceMovies
    {
        private readonly HttpClient httpClient;

        public ServiceMovies(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        private JsonSerializerOptions OpcionesPorDefectoJSON => new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

        /* Crear registros en la APU. Request = post */
        public async Task<HttpResponseWrapper<object>> Post<T>(string url, T send)
        {
            var sendJSON = JsonSerializer.Serialize(send);
            var sendContent = new StringContent(sendJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, sendContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }

        private async Task<T> DeserializarRespuesta<T>(HttpResponseMessage httpResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, jsonSerializerOptions);
        }

        public async Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T enviar)
        {
            var sendJSON = JsonSerializer.Serialize(enviar);
            var sendContent = new StringContent(sendJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, sendContent);
            if (responseHttp.IsSuccessStatusCode)
            {
                var response = await DeserializarRespuesta<TResponse>(responseHttp, OpcionesPorDefectoJSON);
                return new HttpResponseWrapper<TResponse>(response, false, responseHttp);
            }
            else
            {
                return new HttpResponseWrapper<TResponse>(default, true, responseHttp);
            }
        }

        /* Método para consultar */
        public async Task<HttpResponseWrapper<T>> Get<T>(string url)
        {
            var responseHTTP = await httpClient.GetAsync(url);
            if (responseHTTP.IsSuccessStatusCode)
            {
                var response = await DeserializarRespuesta<T>(responseHTTP, OpcionesPorDefectoJSON);
                return new HttpResponseWrapper<T>(response, false, responseHTTP);
            }
            else
            {
                return new HttpResponseWrapper<T>(default, true, responseHTTP);
            }
        }

        /* Método para modificar */
        public async Task<HttpResponseWrapper<object>> Put<T>(string url, T enviar)
        {
            var sendJSON = JsonSerializer.Serialize(enviar);
            var sendContent = new StringContent(sendJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PutAsync(url, sendContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }

        /* Método para eliminar */
        public async Task<HttpResponseWrapper<object>> Delete(string url)
        {
            var responseHTTP = await httpClient.DeleteAsync(url);
            return new HttpResponseWrapper<object>(null, !responseHTTP.IsSuccessStatusCode, responseHTTP);
        }

        public List<Movie> GetMovies(){
            return new List<Movie>(){
                new Movie()
            { MovieTitle = "Coco", MovieSynopsis = "Sinopsis de Coco",  MovieImage =
            "/Images/coco.jpg", Score = 10, PremiereDate = new DateTime(2021, 09, 20)},
            new Movie()
            { MovieTitle = "Avengers Endgame", MovieSynopsis = "Sinopsis de Avengers Endgame", MovieImage =
            "/Images/avengersendgame.png", Score = 10, PremiereDate = new DateTime(2021, 08, 20)},
            new Movie()
            {MovieTitle = "Detective Pikachu", MovieSynopsis = "Sinopsis de Detective Pikachu",  MovieImage =
            "/Images/detectivepikachu.jpg", Score = 10, PremiereDate = new DateTime(2021, 07, 20)},
            new Movie()
            {MovieTitle = "Rápidos y furiosos 9", MovieSynopsis = "Sinopsis de Rápidos y furiosos 9",  MovieImage =
            "/Images/rapidosfuriosos9.jpg", Score = 10, PremiereDate = new DateTime(2021, 09, 20)},
            new Movie()
            { MovieTitle = "El Conjuro 3", MovieSynopsis = "Sinopsis de El Conjuro 3",  MovieImage =
            "/Images/conjuro3.jpg", Score = 10, PremiereDate = new DateTime(2021, 08, 20)},
            new Movie()
            {MovieTitle = "Titanic", MovieSynopsis = "Sinopsis de Titanic", MovieImage =
            "/Images/titanic.jpg", Score = 10, PremiereDate = new DateTime(2021, 07, 20)}
            };
        } 
    }
}