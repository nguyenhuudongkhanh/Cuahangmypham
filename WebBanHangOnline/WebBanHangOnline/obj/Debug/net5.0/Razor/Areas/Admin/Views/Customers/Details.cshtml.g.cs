#pragma checksum "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8431c5535ead40d59f7dece2e419af68263a55b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Customers_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Customers/Details.cshtml")]
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
#line 1 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\_ViewImports.cshtml"
using WebBanHangOnline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\_ViewImports.cshtml"
using WebBanHangOnline.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8431c5535ead40d59f7dece2e419af68263a55b7", @"/Areas/Admin/Views/Customers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8e0195ed7d808b9dae80c38130e37e3de706f81", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Customers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebBanHangOnline.Models.Customer>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/Admin_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Customer</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Avatar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Avatar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LocationId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.LocationId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.District));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.District));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ward));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ward));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Salt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Salt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastLogin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastLogin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8431c5535ead40d59f7dece2e419af68263a55b714318", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Areas\Admin\Views\Customers\Details.cshtml"
                           WriteLiteral(Model.CustomersId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8431c5535ead40d59f7dece2e419af68263a55b716505", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebBanHangOnline.Models.Customer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
