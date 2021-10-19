#pragma checksum "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c20086c09aa696b73c7694e70d1e565b81f49df3"
// <auto-generated/>
#pragma warning disable 1591
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
#line 13 "C:\MoviesProject\Client\_Imports.razor"
using MoviesProject.Shared.Models;

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
#line 3 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
using MoviesProject.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/{MovieId:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/{MovieId:int}/{Name}")]
    public partial class ShowMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
 if (model == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "Cargando...");
#nullable restore
#line 10 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
                            
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "h2");
            __builder.AddContent(2, 
#nullable restore
#line 14 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
         model.Movie.MovieTitle

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, " (");
            __builder.AddContent(4, 
#nullable restore
#line 14 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
                                  model.Movie.PremiereDate.Value.ToString("yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, ")");
            __builder.CloseElement();
#nullable restore
#line 15 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
    for (int i = 0; i < model.Categories.Count; i++)
    {
        if (i < model.Categories.Count - 1)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, 
#nullable restore
#line 19 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
             linkCategory(model.Categories[i])

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, ", ");
#nullable restore
#line 19 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
                                                             
        }
        else
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, 
#nullable restore
#line 23 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
             linkCategory(model.Categories[i])

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 23 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
                                              
        }
    }
    

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, " |  ");
            __builder.OpenElement(10, "span");
            __builder.AddContent(11, 
#nullable restore
#line 26 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
                            model.Movie.PremiereDate.Value.ToString("dd-MM-yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(12, " | Promedio: ");
            __builder.AddContent(13, 
#nullable restore
#line 27 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
                                model.AvgVote.ToString("0.#")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, "/5 | Tu voto: ");
            __builder.AddContent(15, 
#nullable restore
#line 27 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
                                                                                           model.UserVote.ToString("0.#")

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "style", "display: flex;");
            __builder.OpenElement(18, "span");
            __builder.AddAttribute(19, "style", "display: inline-block; margin-right: 5px;");
            __builder.OpenElement(20, "img");
            __builder.AddAttribute(21, "src", 
#nullable restore
#line 29 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
                                                                           model.Movie.MovieImage

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "style", "width: 225px; height: 315px;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "iframe");
            __builder.AddAttribute(25, "width", "560");
            __builder.AddAttribute(26, "height", "315");
            __builder.AddAttribute(27, "src", "https://www.youtube.com/embed/" + (
#nullable restore
#line 30 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
                                                                             model.Movie.Trailer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "frameborder", "0");
            __builder.AddAttribute(29, "allow", "accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture");
            __builder.AddAttribute(30, "allowfullscreen");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "style", "margin-top: 10px;");
            __builder.AddMarkupContent(33, "<h3>Sinopsis</h3>\r\n        ");
            __builder.OpenElement(34, "p");
            __builder.AddContent(35, 
#nullable restore
#line 35 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
            model.Movie.MovieSynopsis

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "style", "margin-top: 10px;");
            __builder.AddMarkupContent(38, "<h3>Actores</h3>\r\n        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "style", "display: flex; flex-direction: column");
#nullable restore
#line 41 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
             foreach (var actor in model.Actors)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "style", "margin-bottom: 2px;");
            __builder.OpenElement(43, "img");
            __builder.AddAttribute(44, "style", "width: 50px;");
            __builder.AddAttribute(45, "src", 
#nullable restore
#line 44 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
                                                    actor.Picture

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.OpenElement(47, "span");
            __builder.AddAttribute(48, "style", "display:inline-block;width: 200px;");
            __builder.OpenElement(49, "a");
            __builder.AddAttribute(50, "href", "/actor/" + (
#nullable restore
#line 45 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
                                                                                      actor.Id

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 45 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
                                                                                                actor.ActorName.Replace(" ", "-")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, 
#nullable restore
#line 45 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
                                                                                                                                    actor.ActorName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.AddMarkupContent(53, "<span style=\"display:inline-block; width: 45px;\">...</span>\r\n                    ");
            __builder.OpenElement(54, "span");
            __builder.AddContent(55, 
#nullable restore
#line 47 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
                           actor.Character

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
      
    [Parameter] public int MovieId{get;set;}
    [Parameter] public string Name{get;set;}
    private ShowMovieDB model;
    private RenderFragment<Category> linkCategory = (category) =>

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(56, "a");
            __builder2.AddAttribute(57, "href", "movies/search?categoryId=" + (
#nullable restore
#line 57 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
                                                                                                     category.Id

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddContent(58, 
#nullable restore
#line 57 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
                                                                                                                   category.Name

#line default
#line hidden
#nullable disable
            );
            __builder2.CloseElement();
        }
#nullable restore
#line 57 "C:\MoviesProject\Client\Pages\Movies\ShowMovie.razor"
                                                                                                                                    ;

    protected async override Task OnInitializedAsync()
    {
        var responseHttp = await repositorio.Get<ShowMovieDB>($"api/movies/{MovieId}");
            if (responseHttp.Error)
            {
                if (responseHttp.HttpResponseMessage.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    navigationManager.NavigateTo("");
                }
                else
                {
                    var mensajeError = await responseHttp.GetBody();
                    await showMessage.ShowErrorMessage(mensajeError);
                }
            }
            else
            {
                model = responseHttp.Response;
            }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IErrorMessage showMessage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovies repositorio { get; set; }
    }
}
#pragma warning restore 1591
