#pragma checksum "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\home\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f45e434e909c12a3069bed6cab5517be9cd88a47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_home_index), @"mvc.1.0.view", @"/Views/home/index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\_ViewImports.cshtml"
using Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\_ViewImports.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f45e434e909c12a3069bed6cab5517be9cd88a47", @"/Views/home/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e31fbbec8fb4222cf117a26f28137c5b00e63f", @"/Views/_ViewImports.cshtml")]
    public class Views_home_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project.ViewModels.NewsHomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section class=\"page-index1\">\r\n    <div class=\"page-index1__content\">\r\n        ");
#nullable restore
#line 5 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\home\index.cshtml"
    Write(Model.MainNews != null ? await Html.RenderComponentAsync<Project.Views.Shared.Components.Pages.MainTodayNews>(RenderMode.ServerPrerendered, new
    { id = Model.MainNews.Id, header = Model.MainNews.Header,date = Model.MainNews.CreatedAt.ToLongDateString(),
        category = Model.MainNews.Category.Name, color = Model.MainNews.Category.Color,image = Model.MainNews.ImageLink,context = Model.MainNews.Context }): null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"page-index1__list\">\r\n            <div class=\"page-index1__listHeader\">\r\n                <h6 class=\"page-index1__listHeader_text\">Discover something new</h6>\r\n            </div>\r\n            <ul class=\"page-index1__listContent\">\r\n");
#nullable restore
#line 13 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\home\index.cshtml"
                 foreach (var news in Model.MainNewses)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\home\index.cshtml"
                Write(await Html.RenderComponentAsync<Project.Views.Shared.Components.Pages.MainNewses>(RenderMode.ServerPrerendered, new
                { id = news.Id,header = news.Header, date = news.CreatedAt.ToLongDateString(), category = news.Category.Name, color = news.Category.Color }
               ));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\home\index.cshtml"
                 
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n</section>\r\n<section class=\"page-index2\">\r\n    ");
#nullable restore
#line 24 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\home\index.cshtml"
Write(await Html.RenderComponentAsync<Project.Views.Shared.Components.Pages.FillEmail>(RenderMode.ServerPrerendered));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</section>\r\n<section class=\"page-index3\">\r\n    ");
#nullable restore
#line 27 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\home\index.cshtml"
Write(await Html.RenderComponentAsync<Project.Views.Shared.Components.Pages.FilterMenu>(RenderMode.ServerPrerendered));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"page-index3__items page-index3__resultsItems\">\r\n");
#nullable restore
#line 30 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\home\index.cshtml"
         foreach (var news in Model.News)
        {
            if (news.Descriptions.Count <= 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\home\index.cshtml"
            Write(await Html.RenderComponentAsync<Project.Views.Shared.Components.Pages.NewsByCategoryDemo>(RenderMode.ServerPrerendered, new
            { header = news.Header, date = news.CreatedAt.ToLongDateString(), category = news.Category.Name,
                color = news.Category.Color, context = news.Context }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\home\index.cshtml"
                                                                       
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\home\index.cshtml"
            Write(await Html.RenderComponentAsync<Project.Views.Shared.Components.Pages.NewsByCategoryFull>(RenderMode.ServerPrerendered, new
            { id = news.Id, header = news.Header, date = news.CreatedAt.ToLongDateString(), category = news.Category.Name,
               color = news.Category.Color, context = news.Context, image = news.ImageLink}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\home\index.cshtml"
                                                                                             
            }

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    ");
#nullable restore
#line 47 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\home\index.cshtml"
Write(await Html.RenderComponentAsync<Project.Views.Shared.Components.Pages.GoArchive>(RenderMode.ServerPrerendered, new
            {header = "Go back in time", textlink = "View archive"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</section>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project.ViewModels.NewsHomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
