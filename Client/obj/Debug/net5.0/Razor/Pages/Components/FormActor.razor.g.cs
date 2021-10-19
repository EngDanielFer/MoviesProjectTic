#pragma checksum "C:\MoviesProject\Client\Pages\Components\FormActor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d435a22760949ebddbde70ff629953ee34a33d13"
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
    public partial class FormActor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "jumbotron");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "C:\MoviesProject\Client\Pages\Components\FormActor.razor"
                         Actor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "C:\MoviesProject\Client\Pages\Components\FormActor.razor"
                                               OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n            ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "row");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col col-sm-12 col-lg-7 mb-3");
                __builder2.OpenElement(16, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "placeholder", "Actor");
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\MoviesProject\Client\Pages\Components\FormActor.razor"
                                                                          Actor.ActorName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Actor.ActorName = __value, Actor.ActorName))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Actor.ActorName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n                            ");
                __Blazor.MoviesProject.Client.Pages.Components.FormActor.TypeInference.CreateValidationMessage_0(__builder2, 24, 25, 
#nullable restore
#line 12 "C:\MoviesProject\Client\Pages\Components\FormActor.razor"
                                                      ()=>Actor.ActorName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                    ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col col-sm-12 col-lg-5 mb-3");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group");
                __builder2.OpenElement(31, "div");
                __Blazor.MoviesProject.Client.Pages.Components.FormActor.TypeInference.CreateInputDate_1(__builder2, 32, 33, "form-control", 34, 
#nullable restore
#line 18 "C:\MoviesProject\Client\Pages\Components\FormActor.razor"
                                                                              Actor.BirthDate

#line default
#line hidden
#nullable disable
                , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Actor.BirthDate = __value, Actor.BirthDate)), 36, () => Actor.BirthDate);
                __builder2.AddMarkupContent(37, "\r\n                                ");
                __Blazor.MoviesProject.Client.Pages.Components.FormActor.TypeInference.CreateValidationMessage_2(__builder2, 38, 39, 
#nullable restore
#line 19 "C:\MoviesProject\Client\Pages\Components\FormActor.razor"
                                                          ()=>Actor.BirthDate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "row");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "col col-sm-12 col-lg-7 mb-3");
                __builder2.AddMarkupContent(45, "<label for>Créditos</label>\r\n                        ");
                __builder2.OpenElement(46, "div");
                __Blazor.MoviesProject.Client.Pages.Components.FormActor.TypeInference.CreateInputNumber_3(__builder2, 47, 48, "form-control", 49, "Cantidad de créditos", 50, 
#nullable restore
#line 28 "C:\MoviesProject\Client\Pages\Components\FormActor.razor"
                                                                            Actor.KnowCredits

#line default
#line hidden
#nullable disable
                , 51, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Actor.KnowCredits = __value, Actor.KnowCredits)), 52, () => Actor.KnowCredits);
                __builder2.AddMarkupContent(53, "\r\n                            ");
                __Blazor.MoviesProject.Client.Pages.Components.FormActor.TypeInference.CreateValidationMessage_4(__builder2, 54, 55, 
#nullable restore
#line 30 "C:\MoviesProject\Client\Pages\Components\FormActor.razor"
                                                      ()=>Actor.KnowCredits

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                    ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "col col-sm-12 col-lg-5 mb-3");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "form-group");
                __builder2.AddMarkupContent(61, "<label for>Nominaciones</label>\r\n                            ");
                __builder2.OpenElement(62, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(63);
                __builder2.AddAttribute(64, "class", "form-control");
                __builder2.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\MoviesProject\Client\Pages\Components\FormActor.razor"
                                                                              Actor.Nominations

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Actor.Nominations = __value, Actor.Nominations))));
                __builder2.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Actor.Nominations));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\r\n                                ");
                __Blazor.MoviesProject.Client.Pages.Components.FormActor.TypeInference.CreateValidationMessage_5(__builder2, 69, 70, 
#nullable restore
#line 38 "C:\MoviesProject\Client\Pages\Components\FormActor.razor"
                                                          ()=>Actor.Nominations

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "row");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "col mb-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(76);
                __builder2.AddAttribute(77, "class", "form-control");
                __builder2.AddAttribute(78, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "C:\MoviesProject\Client\Pages\Components\FormActor.razor"
                                                                          Actor.Biography

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(79, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Actor.Biography = __value, Actor.Biography))));
                __builder2.AddAttribute(80, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Actor.Biography));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(81, "\r\n                        ");
                __Blazor.MoviesProject.Client.Pages.Components.FormActor.TypeInference.CreateValidationMessage_6(__builder2, 82, 83, 
#nullable restore
#line 46 "C:\MoviesProject\Client\Pages\Components\FormActor.razor"
                                                  ()=>Actor.Biography

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n            ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "form-group");
                __builder2.OpenComponent<MoviesProject.Client.Pages.Components.ImageComponent>(87);
                __builder2.AddAttribute(88, "Label", "photo");
                __builder2.AddAttribute(89, "ImageSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 51 "C:\MoviesProject\Client\Pages\Components\FormActor.razor"
                                                             ImageSelected

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(90, "ImageURL", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "C:\MoviesProject\Client\Pages\Components\FormActor.razor"
                                                                                       ImageURL

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n            ");
                __builder2.AddMarkupContent(92, "<button class=\"btn btn-success\" type=\"submit\">Guardar</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\MoviesProject\Client\Pages\Components\FormActor.razor"
       
    private string ImageURL;
    [Parameter] public Actor Actor { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }

    protected override void OnInitialized()
    {
        if (!string.IsNullOrWhiteSpace(Actor.Picture))
        {
            ImageURL = Actor.Picture;
            Console.WriteLine(ImageURL);
            Actor.Picture = null;
        }
    }

    private void ImageSelected(string imageB64)
    {
        Actor.Picture = imageB64;
        ImageURL = null;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.MoviesProject.Client.Pages.Components.FormActor
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
