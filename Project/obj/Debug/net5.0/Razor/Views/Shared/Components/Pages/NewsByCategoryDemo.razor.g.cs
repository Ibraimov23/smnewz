#pragma checksum "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryDemo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0be2be809b6984c070f8d26470a7321ed1a25c45"
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
#nullable restore
#line 1 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryDemo.razor"
using Project.Models;

#line default
#line hidden
#nullable disable
    public partial class NewsByCategoryDemo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-index3__item .page-index3__item-absolute");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "page-index3__itemBlock");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "page-index3__itemContent");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "page-index3__itemContentText");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "page-index3__itemContentTextCateg");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "page-index3__itemContentTextCateg_category");
            __builder.AddAttribute(12, "style", "background-color:" + " " + (
#nullable restore
#line 8 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryDemo.razor"
                                                                                                      color

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.OpenElement(13, "span");
            __builder.AddContent(14, 
#nullable restore
#line 9 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryDemo.razor"
                               category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "p");
            __builder.AddAttribute(17, "class", "page-index3__itemContentTextCateg_date");
            __builder.AddContent(18, 
#nullable restore
#line 11 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryDemo.razor"
                                                                       date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "page-index3__itemContentTextHead");
            __builder.OpenElement(22, "h3");
            __builder.AddAttribute(23, "class", "page-index3__itemContentTextHead_header");
            __builder.AddContent(24, 
#nullable restore
#line 14 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryDemo.razor"
                                                                         header

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "page-index3__itemContentTextContx");
            __builder.AddMarkupContent(28, "<h6 class=\"page-index3__itemContentTextHead_headContx\">The context</h6>\r\n                    ");
            __builder.OpenElement(29, "p");
            __builder.AddAttribute(30, "class", "page-index3__itemContentTextHead_descContx");
            __builder.AddContent(31, 
#nullable restore
#line 18 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryDemo.razor"
                                                                           context

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.AddMarkupContent(33, "<div class=\"page-index3__itemContentLink\"><div class=\"page-index3__itemLinkBlock\"><img class=\"page-index3__itemLinkIcon\" src=\"./images/twitterIcon.svg\">\r\n                    <a class=\"social-share-code\" href=\"https://twitter.com/intent/tweet?\" target=\"_blank\" alt=\"Tweet This\" title=\"Tweet\" onclick=\"window.open(\'https://twitter.com/intent/tweet?text=%20Check this out! \' + encodeURIComponent(document.URL) + \'&amp;t=\' + encodeURIComponent(document.URL), \'targetWindow\', \'toolbar=no,location=0,status=no,menubar=no,scrollbars=yes,resizable=yes,width=600,height=250\'); return false;\"></a></div>\r\n                <div class=\"page-index3__itemLinkBlock\"><img class=\"page-index3__itemLinkIcon\" src=\"./images/facebookIcon.svg\">\r\n                    <a class=\"social-share-code\" href=\"https://www.facebook.com/sharer/sharer.php?u=&amp;t=\" title=\"Share on Facebook\" target=\"_blank\" onclick=\"window.open(\'https://www.facebook.com/sharer/sharer.php?u=\' + encodeURIComponent(document.URL) + \'&amp;t=\' + encodeURIComponent(document.URL), \'targetWindow\', \'toolbar=no,location=0,status=no,menubar=no,scrollbars=yes,resizable=yes,width=600,height=250\');\r\n                                        return false;\"></a></div>\r\n                <div class=\"page-index3__itemLinkBlock\"><img class=\"page-index3__itemLinkIcon\" src=\"./images/linkedinIcon.svg\">\r\n                    <a class=\"social-share-code\" href=\"http://www.linkedin.com/shareArticle?mini=true&amp;url=&amp;title=&amp;summary=&amp;source=\" target=\"_blank\" title=\"Share on LinkedIn\" onclick=\"window.open(\'http://www.linkedin.com/shareArticle?mini=true&amp;url=\' + encodeURIComponent(document.URL) + \'&amp;t=\' + encodeURIComponent(document.URL), \'targetWindow\', \'toolbar=no,location=0,status=no,menubar=no,scrollbars=yes,resizable=yes,width=600,height=600\'); return false;\"></a></div>\r\n                <div class=\"page-index3__itemLinkBlock\"><img class=\"page-index3__itemLinkIcon\" src=\"./images/emailIcon.svg\">\r\n                    <a class=\"social-share-code\" href=\"mailto:?subject=&amp;body=:%20\" target=\"_blank\" title=\"Email\" onclick=\"window.open(\'mailto:?subject=\' + \'&amp;body=\' + encodeURIComponent(document.URL));\r\n                            \t\t   return false;\"></a></div>\r\n                <div class=\"page-index3__itemLinkBlock\"><img class=\"page-index3__itemLinkIcon\" src=\"./images/redditIcon.svg\">\r\n                    <a class=\"social-share-code\" href=\"http://www.reddit.com/submit?url=&amp;title=\" target=\"_blank\" title=\"Submit to Reddit\" onclick=\"window.open(\'http://www.reddit.com/submit?url=\' + encodeURIComponent(document.URL) + \'&amp;t=\' + encodeURIComponent(document.URL), \'targetWindow\', \'toolbar=no,location=0,status=no,menubar=no,scrollbars=yes,resizable=yes,width=600,height=600\'); return false;\"></a></div>\r\n                <div class=\"page-index3__itemLinkBlock\"><img class=\"page-index3__itemLinkIcon\" src=\"./images/whatsappIcon.svg\">\r\n                    <a class=\"social-share-code\" href=\"#\" target=\"_blank\"></a></div></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        <div class=\"page-index3__itemLine\"></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryDemo.razor"
       
    [Parameter]
    public string header { get; set; }

    [Parameter]
    public string date { get; set; }

    [Parameter]
    public string context { get; set; }

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
