#pragma checksum "c:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\Shared\MyTemplatedComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb185f9dc726bb6fd7213f68556d90c4480cb8a3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ConditionalDivs.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\_Imports.razor"
using ConditionalDivs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\_Imports.razor"
using ConditionalDivs.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\_Imports.razor"
using ConditionalDivs.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\Shared\MyTemplatedComponent.razor"
using System.Linq.Expressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\Shared\MyTemplatedComponent.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
    public partial class MyTemplatedComponent<TValue> : Microsoft.AspNetCore.Components.Forms.InputText
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "c:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\Shared\MyTemplatedComponent.razor"
      
    [Parameter] public EventCallback<string> OnChange { get; set; }

    [Parameter] public int MaxLength { get; set; } = 100;

    [Parameter] public string Label { get; set; } = null;

    [Parameter] public Expression<Func<TValue>> For { get; set; } = null;

    //[Parameter] public int Debounce { get; set; } = 300;

    [Parameter] public string Id { get; set; } = Guid.NewGuid().ToString().Replace("-", "");

    [Parameter] public string BindEvent { get; set; } = "oninput";

    [Parameter] public string FormGroupCssClass { get; set; } = "";


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
