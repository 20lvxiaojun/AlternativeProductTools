#pragma checksum "C:\Users\Bestriven\Desktop\C sharp\Blazor\AlternativeTool\AlternativeTool.Web\Client\Pages\DisplayError.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73e8f62fc55d1db173083b5ecbc68443ea17ac3b"
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
    public partial class DisplayError : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddAttribute(1, "class", "text-danger");
#nullable restore
#line 2 "C:\Users\Bestriven\Desktop\C sharp\Blazor\AlternativeTool\AlternativeTool.Web\Client\Pages\DisplayError.razor"
__builder.AddContent(2, ErrorMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "C:\Users\Bestriven\Desktop\C sharp\Blazor\AlternativeTool\AlternativeTool.Web\Client\Pages\DisplayError.razor"
       
    [Parameter]
    public string ErrorMessage { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591