#pragma checksum "C:\MoviesProject\Client\Pages\Components\SelectorMultipleTypeaHead.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63a50d25572b51a95195b8f8ca32e337ce5bcfea"
// <auto-generated/>
#pragma warning disable 1591
namespace MoviesProject.Client.Pages.Components
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
    public partial class SelectorMultipleTypeaHead<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.MoviesProject.Client.Pages.Components.SelectorMultipleTypeaHead.TypeInference.CreateCustomTypeaHead_0(__builder, 0, 1, 
#nullable restore
#line 2 "C:\MoviesProject\Client\Pages\Components\SelectorMultipleTypeaHead.razor"
                                 (string value) => SearchMethod(value)

#line default
#line hidden
#nullable disable
            , 2, 
#nullable restore
#line 2 "C:\MoviesProject\Client\Pages\Components\SelectorMultipleTypeaHead.razor"
                                                                                 sampleItem

#line default
#line hidden
#nullable disable
            , 3, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 3 "C:\MoviesProject\Client\Pages\Components\SelectorMultipleTypeaHead.razor"
                    (T item) => ElementoSeleccionado(item)

#line default
#line hidden
#nullable disable
            ), 4, (context) => (__builder2) => {
                __builder2.AddContent(5, 
#nullable restore
#line 5 "C:\MoviesProject\Client\Pages\Components\SelectorMultipleTypeaHead.razor"
         MyResultTemplate(context)

#line default
#line hidden
#nullable disable
                );
            }
            );
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "ul");
            __builder.AddAttribute(8, "class", "list-group");
#nullable restore
#line 9 "C:\MoviesProject\Client\Pages\Components\SelectorMultipleTypeaHead.razor"
     foreach (var item in ElementosSeleccionados)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "li");
            __builder.AddAttribute(10, "draggable", "true");
            __builder.AddAttribute(11, "ondragstart", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 11 "C:\MoviesProject\Client\Pages\Components\SelectorMultipleTypeaHead.razor"
                                             () => HandleDragStart(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ondragover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 11 "C:\MoviesProject\Client\Pages\Components\SelectorMultipleTypeaHead.razor"
                                                                                          () => HandleDragOver(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "class", "list-group-item list-group-item-action");
            __builder.AddContent(14, 
#nullable restore
#line 13 "C:\MoviesProject\Client\Pages\Components\SelectorMultipleTypeaHead.razor"
             MyListTemplate(item)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "span");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\MoviesProject\Client\Pages\Components\SelectorMultipleTypeaHead.razor"
                              () => ElementosSeleccionados.Remove(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "class", "badge badge-primary badge-pill");
            __builder.AddAttribute(19, "style", "cursor: pointer");
            __builder.AddContent(20, "X");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 17 "C:\MoviesProject\Client\Pages\Components\SelectorMultipleTypeaHead.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\MoviesProject\Client\Pages\Components\SelectorMultipleTypeaHead.razor"
       
    [Parameter]
    public List<T> ElementosSeleccionados { get; set; } = new
        List<T>();
    [Parameter]
    public Func<string, Task<IEnumerable<T>>> SearchMethod
    {
        get; set;
    }
    [Parameter] public RenderFragment<T> MyResultTemplate { get; set; }
    [Parameter] public RenderFragment<T> MyListTemplate { get; set; }
    T sampleItem = default(T);
    T itemArrastrado;
    private void HandleDragStart(T item)
    {
        itemArrastrado = item;
    }
    private void HandleDragOver(T item)
    {
        if (!item.Equals(itemArrastrado))
        {
            var indiceElementoArrastrado =
            ElementosSeleccionados.IndexOf(itemArrastrado);
            var indiceElemento = ElementosSeleccionados.IndexOf(item);
            ElementosSeleccionados[indiceElemento] = itemArrastrado;
            ElementosSeleccionados[indiceElementoArrastrado] = item;
        }
    }
    private void ElementoSeleccionado(T item)
    {
        if (!ElementosSeleccionados.Any(x => x.Equals(item)))
        {
            ElementosSeleccionados.Add(item);
        }
        sampleItem = default(T);
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.MoviesProject.Client.Pages.Components.SelectorMultipleTypeaHead
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCustomTypeaHead_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<TItem>>> __arg0, int __seq1, TItem __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TItem> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg3)
        {
        __builder.OpenComponent<global::MoviesProject.Client.Pages.Components.CustomTypeaHead<TItem>>(seq);
        __builder.AddAttribute(__seq0, "SearchMethod", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ResultTemplate", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
