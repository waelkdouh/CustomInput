#pragma checksum "C:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "158e81e64237d90324b39a442a053d51ebae0d67"
// <auto-generated/>
#pragma warning disable 1591
namespace ConditionalDivs.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\_Imports.razor"
using ConditionalDivs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\_Imports.razor"
using ConditionalDivs.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\_Imports.razor"
using ConditionalDivs.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Custom Input</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "C:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\Pages\Index.razor"
                FormData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\r\n\r\n    ");
                __Blazor.ConditionalDivs.Pages.Index.TypeInference.CreateCustomInput_0(__builder2, 7, 8, "From Name", 9, "col-3 space-sides", 10, 
#nullable restore
#line 18 "C:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\Pages\Index.razor"
                                    50

#line default
#line hidden
#nullable disable
                , 11, "FromName", 12, "From Name", 13, 
#nullable restore
#line 21 "C:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\Pages\Index.razor"
                                () => FormData.Name

#line default
#line hidden
#nullable disable
                , 14, 
#nullable restore
#line 22 "C:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\Pages\Index.razor"
                                       FormData.Name

#line default
#line hidden
#nullable disable
                , 15, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => FormData.Name = __value, FormData.Name)), 16, () => FormData.Name);
                __builder2.AddMarkupContent(17, "\r\n\r\n\r\n    <input type=\"submit\" value=\"Submit\" class=\"btn btn-primary\">\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\waekdo\Desktop\ConditionalDivs\ConditionalDivs\Pages\Index.razor"
       
    Person FormData = new Person();

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.ConditionalDivs.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCustomInput_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Int32 __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5, int __seq6, global::System.String __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<global::System.String> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<global::System.String>> __arg8)
        {
        __builder.OpenComponent<global::ConditionalDivs.Shared.CustomInput<TValue>>(seq);
        __builder.AddAttribute(__seq0, "placeholder", __arg0);
        __builder.AddAttribute(__seq1, "FormGroupCssClass", __arg1);
        __builder.AddAttribute(__seq2, "MaxLength", __arg2);
        __builder.AddAttribute(__seq3, "Id", __arg3);
        __builder.AddAttribute(__seq4, "Label", __arg4);
        __builder.AddAttribute(__seq5, "For", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
