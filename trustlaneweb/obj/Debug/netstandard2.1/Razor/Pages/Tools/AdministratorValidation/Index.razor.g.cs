#pragma checksum "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Tools/AdministratorValidation/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b1cb37db51d5cceb85e22bd96b2717a43cc7c1d"
// <auto-generated/>
#pragma warning disable 1591
namespace trustlaneweb.Pages.Tools.AdministratorValidation
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using trustlaneweb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using trustlaneweb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Tools/AdministratorValidation/Index.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<h3>Administrator Tools</h3>
<br>
Validate your administrator status to add discovery features into the solution.
<br>
<br>
Consider the current network connectivity if it's better to connect from the secure Azure portal (IP range), this computer's IP, or the same when the local PC is connected to a VPN (todo have a HTTP get host to verify via blazor)

For each app, configure usage of the refresh token with this::::::
");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-lg-12 control-section");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "control_wrapper");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<Syncfusion.Blazor.DropDowns.SfMultiSelect<string[]>>(7);
            __builder.AddAttribute(8, "Placeholder", "Select countries");
            __builder.AddAttribute(9, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Tools/AdministratorValidation/Index.razor"
                                                                                     IpOriginList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "AllowCustomValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Tools/AdministratorValidation/Index.razor"
                                                                                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.DropDowns.VisualMode>(
#nullable restore
#line 14 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Tools/AdministratorValidation/Index.razor"
                                                                                                                                  VisualMode.Box

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.MultiSelectFieldSettings>(14);
                __builder2.AddAttribute(15, "Text", "Name");
                __builder2.AddAttribute(16, "Value", "Code");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\ntodo: define this globally, per app, like in a treeview\r\n\r\n");
            __builder.AddMarkupContent(21, "<style>\r\n\r\n    .control_wrapper {\r\n        width: 350px;\r\n        margin: 0 auto;\r\n        padding-top: 70px;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Tools/AdministratorValidation/Index.razor"
      
    public class IPOrigins
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
    private List<IPOrigins> IpOriginList = new List<IPOrigins>
    {
        new IPOrigins() { Name = "Trustlane outbound API (5.6.7.0/30) - default", Code = "default" },
        new IPOrigins() { Name = "2.3.4.5 (This IP as Temporary)", Code = "AU" },
        new IPOrigins() { Name = "2.3.4.5 (This IP as Permanant)", Code = "BM" },
        new IPOrigins() { Name = "http://intranet/vpnactivetext.txt", Code = "intranet" },
        new IPOrigins() { Name = "Tor endpoint", Code = "tor" },
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591