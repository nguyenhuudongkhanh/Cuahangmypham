#pragma checksum "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65ad83217a2d10038091cd588285f2d4c8b91f4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Dashboard), @"mvc.1.0.view", @"/Views/Account/Dashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65ad83217a2d10038091cd588285f2d4c8b91f4c", @"/Views/Account/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8e0195ed7d808b9dae80c38130e37e3de706f81", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebBanHangOnline.Models.Customer>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
  

    Layout = "~/Views/Shared/_Layout.cshtml";
    List<Order> listOrder = ViewBag.ListOrder;
    WebBanHangOnline.ModelView.ChangePasswordViewModel changePassword = new WebBanHangOnline.ModelView.ChangePasswordViewModel();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height"" data-bg-image=""assets/images/breadcrumb/bg/1-1-1920x373.jpg"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <h2 class=""breadcrumb-heading"">Product Related</h2>
                        <ul>
                            <li>
                                <a href=""index.html"">Home <i class=""pe-7s-angle-right""></i></a>
                            </li>
                            <li>My Account</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""account-page-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3"">
                    <ul class=""nav myaccount-tab-trigger"" id=""account-page-tab"" role=""tablis");
            WriteLiteral(@"t"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" id=""account-dashboard-tab"" data-bs-toggle=""tab"" href=""#account-dashboard"" role=""tab"" aria-controls=""account-dashboard"" aria-selected=""true"">Thông tin khách hàng</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-orders-tab"" data-bs-toggle=""tab"" href=""#account-orders"" role=""tab"" aria-controls=""account-orders"" aria-selected=""false"">Sản phẩm đã mua</a>
                        </li>
                       
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-details-tab"" data-bs-toggle=""tab"" href=""#account-details"" role=""tab"" aria-controls=""account-details"" aria-selected=""false"">Thay đổi thông tin</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-logout-tab"" href=""/dang-");
            WriteLiteral(@"xuat.html"" role=""tab"" aria-selected=""false"">Logout</a>
                        </li>
                    </ul>
                </div>
                <div class=""col-lg-9"">
                    <div class=""tab-content myaccount-tab-content"" id=""account-page-tab-content"">
                        <div class=""tab-pane fade show active"" id=""account-dashboard"" role=""tabpanel"" aria-labelledby=""account-dashboard-tab"">
                            <div class=""myaccount-dashboard"">
                                <p>
                                    Xin chào, <b>");
#nullable restore
#line 53 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                            Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> \r\n                                </p>\r\n                               \r\n                            </div>\r\n                        </div>\r\n");
            WriteLiteral(@"                        <div class=""tab-pane fade"" id=""account-orders"" role=""tabpanel"" aria-labelledby=""account-address-tab"">
                            <div class=""myaccount-orders"">
                                <h4 class=""small-title"">DANH SÁCH ĐƠN HÀNG</h4>
");
#nullable restore
#line 67 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                 if (listOrder != null && listOrder.Count() > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""table-responsive"">
                                        <table class=""table table-bordered table-hover"">
                                            <tbody>
                                                <tr>
                                                    <th>ORDER</th>
                                                   
                                                    <th>Ngày mua hàng</th>
                                                    <th>Ngày ship hàng</th>
                                                    <th>Trạng thái đơn hàng</th>
                                                    <th>Tổng tiền</th>
                                                    <th></th>
                                                </tr>
");
#nullable restore
#line 81 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                                 foreach (var item in listOrder)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td><a class=\"account-order-id\" href=\"javascript:void(0)\">#");
#nullable restore
#line 84 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                                                                                      Write(item.OrdersId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                               \r\n                                                <td>");
#nullable restore
#line 86 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                               Write(item.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 87 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                               Write(item.ShipDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 88 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                               Write(item.TransactStatus.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 89 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                               Write(item.TotalMoney.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</td>\r\n                                                <td>\r\n                                                    <a class=\"xemdonhang\" href=\"javascript:void(0)\" data-madonhang=\"");
#nullable restore
#line 91 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                                                                                               Write(item.OrdersId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Xem đơn hàng</a>\r\n                                                </td>\r\n                                                \r\n                                            </tr>\r\n");
#nullable restore
#line 95 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                            </tbody>
                                        </table>
                                        <div id=""records_table"">

                                        </div>
                                    </div>
");
#nullable restore
#line 104 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>Chưa có đơn hàng</p>\r\n");
#nullable restore
#line 108 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                              
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""account-details"" role=""tabpanel"" aria-labelledby=""account-details-tab"">
                            
                            ");
#nullable restore
#line 117 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                       Write(await Html.PartialAsync("ChanggePasswordPartial", changePassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <h4 class=\"card-title\">Thông tin khách hàng: ");
#nullable restore
#line 128 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                                Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
        <div class=""table-responsive"">
            <table class=""product-info-table m-t-20"">
                <tbody>

                    <tr>
                        <td>Tên khách hàng:</td>
                        <td class=""text-dark font-weight-semibold"">");
#nullable restore
#line 135 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                                              Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n\r\n                    <tr>\r\n                        <td>Ngày sinh:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 141 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                                              Write(Model.Birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Ảnh khách hàng:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 146 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                                              Write(Model.Avatar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Địa chỉ khách hàng:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 151 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                                              Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n\r\n                    <tr>\r\n                        <td>Email:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 157 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                                              Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Số điện thoại:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 162 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                                              Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Ngày tham gia:</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 167 "D:\ThuMucLuuBaiMVC\DuAnBanHangOnline\WebBanHangOnline\WebBanHangOnline\Views\Account\Dashboard.cshtml"
                                                              Write(Model.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    \r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
<script>
    $(document).ready(function () {
        $("".xemdonhang"").click(function () {
            var madonhang = $(this).attr(""data-madonhang"")
            $.ajax({
                url: '/DonHang/Details',
                datatype: ""json"",
                type: ""POST"",
                data: { id: madonhang },
                async: true,
                success: function (results) {
                    $(""#records_table"").html("""");
                    $(""#records_table"").html(results);


                },
                error: function (xhr) {
                    alert('erorr');
                }

            });
        });

    });
</script>

");
            }
            );
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