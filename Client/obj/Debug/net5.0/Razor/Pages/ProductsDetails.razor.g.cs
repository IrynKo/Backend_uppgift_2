#pragma checksum "C:\Users\IRINA\source\repos\Uppgift2\Client\Pages\ProductsDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ba57947153ee3690a3c3b60d9f826f0e6d36a93"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\IRINA\source\repos\Uppgift2\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\IRINA\source\repos\Uppgift2\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\IRINA\source\repos\Uppgift2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\IRINA\source\repos\Uppgift2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\IRINA\source\repos\Uppgift2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\IRINA\source\repos\Uppgift2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\IRINA\source\repos\Uppgift2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\IRINA\source\repos\Uppgift2\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\IRINA\source\repos\Uppgift2\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\IRINA\source\repos\Uppgift2\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\IRINA\source\repos\Uppgift2\Client\_Imports.razor"
using SharedLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\IRINA\source\repos\Uppgift2\Client\_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\IRINA\source\repos\Uppgift2\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\IRINA\source\repos\Uppgift2\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\IRINA\source\repos\Uppgift2\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\IRINA\source\repos\Uppgift2\Client\_Imports.razor"
using Client.Services.CartService;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/{id}")]
    public partial class ProductsDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex product-details");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "media-img-big-wrapper ");
            __builder.OpenElement(4, "img");
            __builder.AddAttribute(5, "class", "media-img-big mr-3");
            __builder.AddAttribute(6, "src", 
#nullable restore
#line 11 "C:\Users\IRINA\source\repos\Uppgift2\Client\Pages\ProductsDetails.razor"
                                              product.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "alt", 
#nullable restore
#line 11 "C:\Users\IRINA\source\repos\Uppgift2\Client\Pages\ProductsDetails.razor"
                                                                   product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "media-body");
            __builder.OpenElement(11, "h2");
            __builder.AddAttribute(12, "class", "mb-4");
            __builder.AddContent(13, 
#nullable restore
#line 14 "C:\Users\IRINA\source\repos\Uppgift2\Client\Pages\ProductsDetails.razor"
                          product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "p");
            __builder.AddAttribute(16, "class", "mb-2");
            __builder.AddContent(17, 
#nullable restore
#line 15 "C:\Users\IRINA\source\repos\Uppgift2\Client\Pages\ProductsDetails.razor"
                          product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "p");
            __builder.AddAttribute(20, "class", "item-price mb-2");
            __builder.AddMarkupContent(21, "??");
            __builder.AddContent(22, 
#nullable restore
#line 16 "C:\Users\IRINA\source\repos\Uppgift2\Client\Pages\ProductsDetails.razor"
                                      product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(24);
            __builder.AddAttribute(25, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "C:\Users\IRINA\source\repos\Uppgift2\Client\Pages\ProductsDetails.razor"
                         cartItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "style", "width: 80%;");
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group");
                __Blazor.Client.Pages.ProductsDetails.TypeInference.CreateInputNumber_0(__builder2, 30, 31, "quantity", 32, "form-control", 33, 
#nullable restore
#line 19 "C:\Users\IRINA\source\repos\Uppgift2\Client\Pages\ProductsDetails.razor"
                                                        cartItem.Quantity

#line default
#line hidden
#nullable disable
                , 34, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cartItem.Quantity = __value, cartItem.Quantity)), 35, () => cartItem.Quantity);
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "btn btn-primary mt-3");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\IRINA\source\repos\Uppgift2\Client\Pages\ProductsDetails.razor"
                                                       AddToCard

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Add to Cart");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\IRINA\source\repos\Uppgift2\Client\Pages\ProductsDetails.razor"
       
    private Product product = new Product();

    private CartItem cartItem = new CartItem { Quantity = 1 };


    [Parameter]
    public string Id { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        product = await Http.GetFromJsonAsync<Product>($"https://localhost:44310/api/Products/{Id}");

    }


    private async Task AddToCard()

    {
        cartItem.Title = product.Title;
        cartItem.Image = product.Image;
        cartItem.Price = product.Price;
        cartItem.ProductId = product.Id;
        

        await CartService.AddToCart(cartItem, product);
       
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService CartService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.Client.Pages.ProductsDetails
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
