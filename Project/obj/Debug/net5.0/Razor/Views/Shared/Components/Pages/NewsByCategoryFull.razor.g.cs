#pragma checksum "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryFull.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59321e83af1088de8b18a65eaf2c43c6fc92a5b2"
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
#line 1 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryFull.razor"
using Project.Models;

#line default
#line hidden
#nullable disable
    public partial class NewsByCategoryFull : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-index3__itemFull .page-index3__item-absolute");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "page-index3__itemFullBlock");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "page-index3__itemFullRelativ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "page-index3__itemFullContent");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "page-index3__itemFullHeader");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "page-index3__itemFullHeaderText");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "page-index3__itemContentTextCateg_category");
            __builder.AddAttribute(14, "style", "background-color:" + " " + (
#nullable restore
#line 9 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryFull.razor"
                                                                                                          color

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.OpenElement(15, "span");
            __builder.AddContent(16, 
#nullable restore
#line 10 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryFull.razor"
                                   category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "a");
            __builder.AddAttribute(19, "class", "page-index3__itemContentTextHead_a");
            __builder.AddAttribute(20, "href", "/details?id=" + (
#nullable restore
#line 12 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryFull.razor"
                                                                                         id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(21, "h3");
            __builder.AddAttribute(22, "class", "page-index3__itemContentTextHead_header");
            __builder.AddContent(23, 
#nullable restore
#line 13 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryFull.razor"
                                                                                 header

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "p");
            __builder.AddAttribute(26, "class", "page-index3__itemContentTextCateg_date");
            __builder.AddContent(27, 
#nullable restore
#line 15 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryFull.razor"
                                                                           date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "class", "page-index3__itemFullLinkText");
            __builder.AddAttribute(31, "href", "/details?id=" + (
#nullable restore
#line 17 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryFull.razor"
                                                                                id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "\r\n                        Go deeper&nbsp;→\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "page-index3__itemFullContext");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "page-index3__itemFullContextText");
            __builder.AddMarkupContent(38, "<h6 class=\"page-index3__itemFullContextText_header\">The context</h6>\r\n                        ");
            __builder.OpenElement(39, "p");
            __builder.AddAttribute(40, "class", "page-index3__itemFullContextText_desc");
            __builder.AddContent(41, 
#nullable restore
#line 24 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryFull.razor"
                                                                          context

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.AddMarkupContent(43, "<div class=\"page-index3__itemContentLink\"><div class=\"page-index3__itemLinkBlock\"><img class=\"page-index3__itemLinkIcon\" src=\"./images/twitterIcon.svg\">\r\n                            <a class=\"social-share-code\" href=\"https://twitter.com/intent/tweet?\" target=\"_blank\" alt=\"Tweet This\" title=\"Tweet\" onclick=\"window.open(\'https://twitter.com/intent/tweet?text=%20Check this out! \' + encodeURIComponent(document.URL) + \'&amp;t=\' + encodeURIComponent(document.URL), \'targetWindow\', \'toolbar=no,location=0,status=no,menubar=no,scrollbars=yes,resizable=yes,width=600,height=250\'); return false;\"></a></div>\r\n                        <div class=\"page-index3__itemLinkBlock\"><img class=\"page-index3__itemLinkIcon\" src=\"./images/facebookIcon.svg\">\r\n                            <a class=\"social-share-code\" href=\"https://www.facebook.com/sharer/sharer.php?u=&amp;t=\" title=\"Share on Facebook\" target=\"_blank\" onclick=\"window.open(\'https://www.facebook.com/sharer/sharer.php?u=\' + encodeURIComponent(document.URL) + \'&amp;t=\' + encodeURIComponent(document.URL), \'targetWindow\', \'toolbar=no,location=0,status=no,menubar=no,scrollbars=yes,resizable=yes,width=600,height=250\');\r\n                                        return false;\"></a></div>\r\n                        <div class=\"page-index3__itemLinkBlock\"><img class=\"page-index3__itemLinkIcon\" src=\"./images/linkedinIcon.svg\">\r\n                            <a class=\"social-share-code\" href=\"http://www.linkedin.com/shareArticle?mini=true&amp;url=&amp;title=&amp;summary=&amp;source=\" target=\"_blank\" title=\"Share on LinkedIn\" onclick=\"window.open(\'http://www.linkedin.com/shareArticle?mini=true&amp;url=\' + encodeURIComponent(document.URL) + \'&amp;t=\' + encodeURIComponent(document.URL), \'targetWindow\', \'toolbar=no,location=0,status=no,menubar=no,scrollbars=yes,resizable=yes,width=600,height=600\'); return false;\"></a></div>\r\n                        <div class=\"page-index3__itemLinkBlock\"><img class=\"page-index3__itemLinkIcon\" src=\"./images/emailIcon.svg\">\r\n                            <a class=\"social-share-code\" href=\"mailto:?subject=&amp;body=:%20\" target=\"_blank\" title=\"Email\" onclick=\"window.open(\'mailto:?subject=\' + \'&amp;body=\' + encodeURIComponent(document.URL));\r\n                            \t\t   return false;\"></a></div>\r\n                        <div class=\"page-index3__itemLinkBlock\"><img class=\"page-index3__itemLinkIcon\" src=\"./images/redditIcon.svg\">\r\n                            <a class=\"social-share-code\" href=\"http://www.reddit.com/submit?url=&amp;title=\" target=\"_blank\" title=\"Submit to Reddit\" onclick=\"window.open(\'http://www.reddit.com/submit?url=\' + encodeURIComponent(document.URL) + \'&amp;t=\' + encodeURIComponent(document.URL), \'targetWindow\', \'toolbar=no,location=0,status=no,menubar=no,scrollbars=yes,resizable=yes,width=600,height=600\'); return false;\"></a></div>\r\n                        <div class=\"page-index3__itemLinkBlock\"><img class=\"page-index3__itemLinkIcon\" src=\"./images/whatsappIcon.svg\">\r\n                            <a class=\"social-share-code\" href=\"#\" target=\"_blank\"></a></div></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "a");
            __builder.AddAttribute(46, "class", "page-index3__itemFullImage");
            __builder.AddAttribute(47, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 62 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryFull.razor"
                                                  image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.AddAttribute(48, "href", "#");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "page-index3__itemFullContentMobile");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "page-index3__itemFullContentMobileHeader");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "page-index3__itemFullContentMobileHeader2377");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "page-index3__itemContentTextCateg");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "page-index3__itemContentTextCateg_category");
            __builder.AddAttribute(60, "style", "background-color:" + " " + (
#nullable restore
#line 70 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryFull.razor"
                                                                                                              color

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.OpenElement(61, "span");
            __builder.AddContent(62, 
#nullable restore
#line 71 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryFull.razor"
                                       category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                            ");
            __builder.OpenElement(64, "p");
            __builder.AddAttribute(65, "class", "page-index3__itemContentTextCateg_date");
            __builder.AddContent(66, 
#nullable restore
#line 73 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryFull.razor"
                                                                               date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                        ");
            __builder.OpenElement(68, "a");
            __builder.AddAttribute(69, "class", "page-index3__itemContentTextHead_a");
            __builder.AddAttribute(70, "href");
            __builder.OpenElement(71, "h3");
            __builder.AddAttribute(72, "class", "page-index3__itemContentTextHead_header");
            __builder.AddContent(73, 
#nullable restore
#line 76 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryFull.razor"
                                                                                 header

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                    ");
            __builder.OpenElement(75, "a");
            __builder.AddAttribute(76, "class", "page-index3__itemFullImage page-index3__itemFullImageMobile");
            __builder.AddAttribute(77, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 80 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryFull.razor"
                                                      image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.AddAttribute(78, "href", "#");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "page-index3__itemFullContentMobileDesc");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "page-index3__itemFullContentMobileDesc2377");
            __builder.AddMarkupContent(84, "<h6 class=\"page-index3__itemFullContentMobileDesc_header\">The context</h6>\r\n                        ");
            __builder.OpenElement(85, "p");
            __builder.AddAttribute(86, "class", "page-index3__itemFullContentMobileDesc_desc");
            __builder.AddContent(87, 
#nullable restore
#line 87 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryFull.razor"
                                                                                context

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                    ");
            __builder.OpenElement(89, "a");
            __builder.AddAttribute(90, "class", "page-index3__itemFullLinkText");
            __builder.AddAttribute(91, "href", "/details?id=" + (
#nullable restore
#line 89 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryFull.razor"
                                                                                id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(92, "\r\n                        Go deeper&nbsp;→\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                ");
            __builder.AddMarkupContent(94, @"<div class=""page-index3__itemContentLink""><div class=""page-index3__itemLinkBlock""><img class=""page-index3__itemLinkIcon"" src=""./images/twitterIcon.svg""></div>
                    <div class=""page-index3__itemLinkBlock""><img class=""page-index3__itemLinkIcon"" src=""./images/facebookIcon.svg""></div>
                    <div class=""page-index3__itemLinkBlock""><img class=""page-index3__itemLinkIcon"" src=""./images/linkedinIcon.svg""></div>
                    <div class=""page-index3__itemLinkBlock""><img class=""page-index3__itemLinkIcon"" src=""./images/emailIcon.svg""></div>
                    <div class=""page-index3__itemLinkBlock""><img class=""page-index3__itemLinkIcon"" src=""./images/redditIcon.svg""></div>
                    <div class=""page-index3__itemLinkBlock""><img class=""page-index3__itemLinkIcon"" src=""./images/whatsappIcon.svg""></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n        <div class=\"page-index3__itemLine\"></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 119 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\Shared\Components\Pages\NewsByCategoryFull.razor"
       
    [Parameter]
    public int id { get; set; }

    [Parameter]
    public string header { get; set; }

    [Parameter]
    public string date { get; set; }
    [Parameter]
    public string context { get; set; }
    [Parameter]
    public string image { get; set; }

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
