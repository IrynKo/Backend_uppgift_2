#pragma checksum "C:\Users\IRINA\source\repos\Uppgift2\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3183bb3e1c06760edca3ac87dc1c3779e395d11"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-ocnk4r8tjs");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "main");
            __builder.AddAttribute(5, "b-ocnk4r8tjs");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "top-menu px-4");
            __builder.AddAttribute(8, "b-ocnk4r8tjs");
            __builder.OpenComponent<Client.Shared.NavMenu>(9);
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenComponent<Client.Shared.TopMenu>(11);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "content px-4");
            __builder.AddAttribute(15, "b-ocnk4r8tjs");
            __builder.AddContent(16, 
#nullable restore
#line 14 "C:\Users\IRINA\source\repos\Uppgift2\Client\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(18);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
