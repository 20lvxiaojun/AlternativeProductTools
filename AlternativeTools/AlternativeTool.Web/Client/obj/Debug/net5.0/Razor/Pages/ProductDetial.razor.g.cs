#pragma checksum "C:\Users\Bestriven\Desktop\C sharp\Blazor\AlternativeTool\AlternativeTool.Web\Client\Pages\ProductDetial.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "947272a77f1ad3df24b6821d2bfa6b647c553aaa"
// <auto-generated/>
#pragma warning disable 1591
namespace AlternativeTool.Web.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bestriven\Desktop\C sharp\Blazor\AlternativeTool\AlternativeTool.Web\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bestriven\Desktop\C sharp\Blazor\AlternativeTool\AlternativeTool.Web\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bestriven\Desktop\C sharp\Blazor\AlternativeTool\AlternativeTool.Web\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bestriven\Desktop\C sharp\Blazor\AlternativeTool\AlternativeTool.Web\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bestriven\Desktop\C sharp\Blazor\AlternativeTool\AlternativeTool.Web\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bestriven\Desktop\C sharp\Blazor\AlternativeTool\AlternativeTool.Web\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bestriven\Desktop\C sharp\Blazor\AlternativeTool\AlternativeTool.Web\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bestriven\Desktop\C sharp\Blazor\AlternativeTool\AlternativeTool.Web\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bestriven\Desktop\C sharp\Blazor\AlternativeTool\AlternativeTool.Web\Client\_Imports.razor"
using AlternativeTool.Web.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Bestriven\Desktop\C sharp\Blazor\AlternativeTool\AlternativeTool.Web\Client\_Imports.razor"
using AlternativeTool.Web.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ProductDetail/{ProductName}")]
    public partial class ProductDetial : ProductDetialBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ProductDetial</h3>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<h1>ProductCompetitives Name</h1>\r\n");
            __builder.OpenElement(2, "div");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table table-hover table-striped");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 10 "C:\Users\Bestriven\Desktop\C sharp\Blazor\AlternativeTool\AlternativeTool.Web\Client\Pages\ProductDetial.razor"
         foreach (var item in Product.CometitiveProductNames)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
#nullable restore
#line 13 "C:\Users\Bestriven\Desktop\C sharp\Blazor\AlternativeTool\AlternativeTool.Web\Client\Pages\ProductDetial.razor"
__builder.AddContent(8, item);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\Bestriven\Desktop\C sharp\Blazor\AlternativeTool\AlternativeTool.Web\Client\Pages\ProductDetial.razor"
        
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591