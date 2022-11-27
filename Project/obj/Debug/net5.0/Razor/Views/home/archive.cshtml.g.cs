#pragma checksum "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\home\archive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59868a710a52d45e83a969f370f288837bf9c132"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_home_archive), @"mvc.1.0.view", @"/Views/home/archive.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59868a710a52d45e83a969f370f288837bf9c132", @"/Views/home/archive.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e31fbbec8fb4222cf117a26f28137c5b00e63f", @"/Views/_ViewImports.cshtml")]
    public class Views_home_archive : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Project.Models.News>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-archive__search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <section class=""page-index1"">
        <div class=""page-archive__content"">
            <div class=""page-archive__header"">
                <a class=""page-index3__itemFullLinkText page-index3__goBack_link page-archive__link"" href=""/"">
                    ←&nbsp;View the latest
                </a>
                <h1 class=""page-archive__header_text"">The Archive</h1>
                <div class=""page-archive__search"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59868a710a52d45e83a969f370f288837bf9c1324080", async() => {
                WriteLiteral("\r\n                        <input type=\"text\" class=\"page-archive__search-input\" maxlength=\"256\" name=\"Search\" fs-cmsfilter-field=\"*\" data-name=\"Search\" placeholder=\"Search\" id=\"search\" autocomplete=\"off\" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"page-index3__items\">\r\n");
#nullable restore
#line 17 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\home\archive.cshtml"
                 foreach (var news in Model)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\home\archive.cshtml"
                Write(await Html.RenderComponentAsync<Project.Views.Shared.Components.Pages.NewsByCategoryFull>(RenderMode.ServerPrerendered, new
            { id = news.Id, header = news.Header, date = news.CreatedAt.ToLongDateString(), category = news.Category.Name,
               color = news.Category.Color, context = news.Context, image = news.ImageLink}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\home\archive.cshtml"
                                                                                             
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            ");
#nullable restore
#line 24 "C:\Users\Nursultan\Desktop\заказ22\bonsai_version\Project\Views\home\archive.cshtml"
        Write(await Html.RenderComponentAsync<Project.Views.Shared.Components.Pages.GoArchive>(RenderMode.ServerPrerendered, new
            {header = "Back to the present", textlink = "View the latest"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </section>
<script type=""text/javascript"">
    let timeout = null;
    document.getElementById('search').addEventListener('keyup', function (e) {
        clearTimeout(timeout);
        timeout = setTimeout(function () {
            search()
        }, 1);
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Project.Models.News>> Html { get; private set; }
    }
}
#pragma warning restore 1591