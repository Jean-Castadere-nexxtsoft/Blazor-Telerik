#pragma checksum "C:\__CODEBASE\BlazorTelerik\Blazor.Server.Sample\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "763baadfbb3400105fc782aeba5e10fa8e55ab18"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Server.Sample
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\__CODEBASE\BlazorTelerik\Blazor.Server.Sample\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\__CODEBASE\BlazorTelerik\Blazor.Server.Sample\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\__CODEBASE\BlazorTelerik\Blazor.Server.Sample\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\__CODEBASE\BlazorTelerik\Blazor.Server.Sample\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\__CODEBASE\BlazorTelerik\Blazor.Server.Sample\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\__CODEBASE\BlazorTelerik\Blazor.Server.Sample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\__CODEBASE\BlazorTelerik\Blazor.Server.Sample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\__CODEBASE\BlazorTelerik\Blazor.Server.Sample\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\__CODEBASE\BlazorTelerik\Blazor.Server.Sample\_Imports.razor"
using Blazor.Server.Sample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\__CODEBASE\BlazorTelerik\Blazor.Server.Sample\_Imports.razor"
using Blazor.Server.Sample.Shared;

#line default
#line hidden
#nullable disable
    public partial class App : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.Router>(2);
                __builder2.AddAttribute(3, "AppAssembly", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Reflection.Assembly>(
#nullable restore
#line 2 "C:\__CODEBASE\BlazorTelerik\Blazor.Server.Sample\App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "PreferExactMatches", 
#nullable restore
#line 2 "C:\__CODEBASE\BlazorTelerik\Blazor.Server.Sample\App.razor"
                                                                         true

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(5, "Found", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(6);
                    __builder3.AddAttribute(7, "RouteData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 4 "C:\__CODEBASE\BlazorTelerik\Blazor.Server.Sample\App.razor"
                                            routeData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "DefaultLayout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 4 "C:\__CODEBASE\BlazorTelerik\Blazor.Server.Sample\App.razor"
                                                                       typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(9, "NotFound", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::Microsoft.AspNetCore.Components.LayoutView>(10);
                    __builder3.AddAttribute(11, "Layout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 7 "C:\__CODEBASE\BlazorTelerik\Blazor.Server.Sample\App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(13, "<p>Sorry, there\'s nothing at this address.</p>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
