#pragma checksum "c:\Users\SHREE\source\repos\Sample\Pages\Accordians.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a66fa9921c6025131c4a170a960c4b4812620078"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Sample.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\SHREE\source\repos\Sample\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\SHREE\source\repos\Sample\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\SHREE\source\repos\Sample\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\SHREE\source\repos\Sample\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\SHREE\source\repos\Sample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\SHREE\source\repos\Sample\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\SHREE\source\repos\Sample\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\SHREE\source\repos\Sample\_Imports.razor"
using Sample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\SHREE\source\repos\Sample\_Imports.razor"
using Sample.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Accordians")]
    public partial class Accordians : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "c:\Users\SHREE\source\repos\Sample\Pages\Accordians.razor"
 
    string imageURL1 = "https://images.samash.com/sa/H13/H1305XXX3-P.fpx?cvt=jpg";
    bool show = false;

    private void click(MouseEventArgs e)
    {
        show = true;
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
