// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MoviesProject.Client.Pages.Movies
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\MoviesProject\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MoviesProject\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\MoviesProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\MoviesProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\MoviesProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\MoviesProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\MoviesProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\MoviesProject\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\MoviesProject\Client\_Imports.razor"
using MoviesProject.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\MoviesProject\Client\_Imports.razor"
using MoviesProject.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\MoviesProject\Client\_Imports.razor"
using MoviesProject.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\MoviesProject\Client\_Imports.razor"
using MoviesProject.Shared.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\MoviesProject\Client\_Imports.razor"
using MoviesProject.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MoviesProject\Client\Pages\Movies\FilterMovies.razor"
using MoviesProject.Client.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\MoviesProject\Client\Pages\Movies\FilterMovies.razor"
using MoviesProject.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/search")]
    public partial class FilterMovies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\MoviesProject\Client\Pages\Movies\FilterMovies.razor"
       
    private List<Movie> Movies;
    private List<Movie> Estrenos;
    private List<Movie> EnCartelera;
    string movie_name = "";
    string categorySelected = "";
    private bool futurosPremieres = false;
    private bool enCartelera = false;
    private bool mejorCalificada = false;

    protected async override Task OnInitializedAsync()
    {
        var responseHttp = await movie.Get<FilterMovie>("api/movies");
        Estrenos = responseHttp.Response.ProximosEstrenos;
        EnCartelera = responseHttp.Response.PeliculasEnCartelera;
    }

    private List<Category> categories = new List<Category>();
    private void MovieNameKeyPress(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            CargarNewMovies();
        }
    }

    private void CargarNewMovies()
    {
        Movies = movie.GetMovies().Where(x => x.MovieTitle.ToLower().Contains(movie_name.ToLower())).ToList();
        Console.WriteLine($"Título: {movie_name}");
        Console.WriteLine($"Categoría: {categorySelected}");
        Console.WriteLine($"En cartelera: {enCartelera}");
        Console.WriteLine($"Próximos estrenos: {futurosPremieres}");
        Console.WriteLine($"Mejor calificada: {mejorCalificada}");
    }

    private void CleanFields()
    {
        Movies = movie.GetMovies();
        movie_name = "";
        categorySelected = "0";
        enCartelera = false;
        futurosPremieres = false;
        mejorCalificada = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IErrorMessage showMessage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovies movie { get; set; }
    }
}
#pragma warning restore 1591
