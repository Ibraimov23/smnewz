#pragma checksum "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\MainNewses.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87132133de3389d222f0ae9fdc8afa9fbd62bd22"
// <auto-generated/>
#pragma warning disable 1591
namespace Project.Views.Shared.Components.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    public partial class MainNewses : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "li");
            __builder.AddAttribute(1, "class", "page-index1__listContentUl_li");
            __builder.OpenElement(2, "a");
            __builder.AddAttribute(3, "class", "page-index1__listContentUl_A");
            __builder.AddAttribute(4, "href", "/details?id=" + (
#nullable restore
#line 3 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\MainNewses.razor"
                                                                       id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(5, "h2");
            __builder.AddAttribute(6, "class", "page-index1__listContentUl_header");
            __builder.AddContent(7, 
#nullable restore
#line 4 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\MainNewses.razor"
                                                               header

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.OpenElement(9, "p");
            __builder.AddAttribute(10, "class", "page-index1__listContentUl_desc");
            __builder.OpenElement(11, "span");
            __builder.AddAttribute(12, "class", "page-index1__listContentUl_descText");
            __builder.AddContent(13, 
#nullable restore
#line 6 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\MainNewses.razor"
                                                                       date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.AddMarkupContent(15, "<span class=\"page-index1__listContentUl_descText accent\">&nbsp;⁃&nbsp;</span>\r\n                    ");
            __builder.OpenElement(16, "span");
            __builder.AddAttribute(17, "class", "page-index1__listContentUl_descText");
            __builder.AddAttribute(18, "style", "color:" + " " + (
#nullable restore
#line 8 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\MainNewses.razor"
                                                                                     color

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddContent(19, 
#nullable restore
#line 8 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\MainNewses.razor"
                                                                                              category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\MainNewses.razor"
       
    [Parameter]
    public int id { get; set; }

    [Parameter]
    public string header { get; set; }

    [Parameter]
    public string date { get; set; }

    [Parameter]
    public string category { get; set; }

    [Parameter]
    public string color { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
