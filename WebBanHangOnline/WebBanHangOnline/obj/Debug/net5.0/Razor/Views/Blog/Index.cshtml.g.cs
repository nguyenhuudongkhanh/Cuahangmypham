#pragma checksum "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e0d4d43010c6426d1c8f911191ec09d7ccf153d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\_ViewImports.cshtml"
using WebBanHangOnline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\_ViewImports.cshtml"
using WebBanHangOnline.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Blog\Index.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e0d4d43010c6426d1c8f911191ec09d7ccf153d", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8e0195ed7d808b9dae80c38130e37e3de706f81", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<WebBanHangOnline.Models.News>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:550px;height:250px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Blog\Index.cshtml"
  
    
    Layout = "~/Views/Shared/_Layout.cshtml";
    int PageCurrent = ViewBag.CurrentPage;
    int Pagenext = PageCurrent + 1;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height"" data-bg-image=""~/assets/images/breadcrumb/bg/1-1-1920x373.jpg"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <h2 class=""breadcrumb-heading"">Tin nổi bật</h2>
                        <ul>
                            <li>
                                <a href=""index.html"">Home <i class=""pe-7s-angle-right""></i></a>
                            </li>
                            <li>Blog Default</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""blog-area blog-column-2 section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
");
#nullable restore
#line 32 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Blog\Index.cshtml"
                 if (Model != null && Model.Count() > 0)
                {

                    foreach (var item in Model)
                    {
                        string url = $"/tin-tuc/{item.Alias}-{item.PostId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-6\">\r\n                            <div class=\"blog-item\">\r\n                                <div class=\"blog-img img-zoom-effect\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1577, "\"", 1588, 1);
#nullable restore
#line 41 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1584, url, 1584, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8e0d4d43010c6426d1c8f911191ec09d7ccf153d6472", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1692, "~/images/news/", 1692, 14, true);
#nullable restore
#line 42 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 1706, item.Thumb, 1706, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 42 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 1724, item.Tiltle, 1724, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </a>
                                </div>
                                <div class=""blog-content"">
                                    <div class=""blog-meta text-dim-gray pb-3"">
                                        <ul>
                                            <li class=""date""><i class=""fa fa-calendar-o me-2""></i>");
#nullable restore
#line 48 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Blog\Index.cshtml"
                                                                                             Write(item.CreteDate.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                            <li>
                                                <span class=""comments me-3"">
                                                    <a href=""javascript:void(0)"">2 Comments</a>
                                                </span>
                                                <span class=""link-share"">
                                                    <a href=""javascript:void(0)"">Share</a>
                                                </span>
                                            </li>
                                        </ul>
                                    </div>
                                    <h5 class=""title mb-4"">
                                        <a");
            BeginWriteAttribute("href", " href=\"", 2905, "\"", 2916, 1);
#nullable restore
#line 60 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2912, url, 2912, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 60 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Blog\Index.cshtml"
                                                  Write(item.Tiltle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </h5>\r\n                                    <p class=\"short-desc mb-5\">");
#nullable restore
#line 62 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Blog\Index.cshtml"
                                                          Write(item.Scontents);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n                                    <div class=\"button-wrap\">\r\n                                        <a class=\"btn btn-custom-size lg-size btn-dark rounded-0\"");
            BeginWriteAttribute("href", " href=\"", 3224, "\"", 3235, 1);
#nullable restore
#line 64 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Blog\Index.cshtml"
WriteAttributeValue("", 3231, url, 3231, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Read More</a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 69 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Blog\Index.cshtml"

                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                <div class=\"col-lg-12\">\r\n                    <div class=\"pagination-area pt-10\">\r\n                        <nav aria-label=\"Page navigation example\">\r\n                            <ul class=\"pagination justify-content-center\">\r\n");
#nullable restore
#line 78 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Blog\Index.cshtml"
                                 if (PageCurrent > 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">\r\n                                        <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3904, "\"", 3946, 2);
            WriteAttributeValue("", 3911, "/blogs.html?page=", 3911, 17, true);
#nullable restore
#line 81 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Blog\Index.cshtml"
WriteAttributeValue("", 3928, PageCurrent - 1, 3928, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                                            <span class=\"fa fa-chevron-left\"></span>\r\n                                        </a>\r\n                                    </li>\r\n");
#nullable restore
#line 85 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Blog\Index.cshtml"
                                }
                                else

                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <li class=""page-item"">
                                        <a class=""page-link"" href=""/blogs.html"" aria-label=""Previous"">
                                            <span class=""fa fa-chevron-left""></span>
                                        </a>
                                    </li>
");
#nullable restore
#line 94 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Blog\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <li class=\"page-item active\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4718, "\"", 4754, 2);
            WriteAttributeValue("", 4725, "/blogs.html?page=", 4725, 17, true);
#nullable restore
#line 96 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Blog\Index.cshtml"
WriteAttributeValue("", 4742, PageCurrent, 4742, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 96 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Blog\Index.cshtml"
                                                                                                                      Write(PageCurrent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                    <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4857, "\"", 4890, 2);
            WriteAttributeValue("", 4864, "/blogs.html?page=", 4864, 17, true);
#nullable restore
#line 97 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Blog\Index.cshtml"
WriteAttributeValue("", 4881, Pagenext, 4881, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 97 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Blog\Index.cshtml"
                                                                                                            Write(Pagenext);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                    <li class=\"page-item\">\r\n                                        <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 5032, "\"", 5065, 2);
            WriteAttributeValue("", 5039, "/blogs.html?page=", 5039, 17, true);
#nullable restore
#line 99 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Blog\Index.cshtml"
WriteAttributeValue("", 5056, Pagenext, 5056, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""Next"">
                                            <span class=""fa fa-chevron-right""></span>
                                        </a>
                                    </li>
                                </ul>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
    </div>
</main>

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<WebBanHangOnline.Models.News>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591