#pragma checksum "D:\DoAnASP\Views\Payments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "063649f8026eda42b5a2d597c5875bb63d827d96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payments_Index), @"mvc.1.0.view", @"/Views/Payments/Index.cshtml")]
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
#line 1 "D:\DoAnASP\Views\_ViewImports.cshtml"
using DoAnASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DoAnASP\Views\_ViewImports.cshtml"
using DoAnASP.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DoAnASP\Views\_ViewImports.cshtml"
using DoAnASP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DoAnASP\Views\_ViewImports.cshtml"
using DoAnASP.Areas.Admin.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DoAnASP\Views\_ViewImports.cshtml"
using DoAnASP.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"063649f8026eda42b5a2d597c5875bb63d827d96", @"/Views/Payments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"500275438c6ba83c723959af778b75747be83fea", @"/Views/_ViewImports.cshtml")]
    public class Views_Payments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoAnASP.Areas.Admin.Models.Payment>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section>\r\n    <div class=\"container\">\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 9 "D:\DoAnASP\Views\Payments\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.IDUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 12 "D:\DoAnASP\Views\Payments\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.PaymentMethod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 15 "D:\DoAnASP\Views\Payments\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ShippingUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 18 "D:\DoAnASP\Views\Payments\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Note));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 21 "D:\DoAnASP\Views\Payments\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 24 "D:\DoAnASP\Views\Payments\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Cart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                     <th>Trạng thái đơn hàng</th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 31 "D:\DoAnASP\Views\Payments\Index.cshtml"
                 foreach (Payment item in ViewBag.Payment)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 35 "D:\DoAnASP\Views\Payments\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IDUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 38 "D:\DoAnASP\Views\Payments\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PaymentMethod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 41 "D:\DoAnASP\Views\Payments\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ShippingUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "D:\DoAnASP\Views\Payments\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Note));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "D:\DoAnASP\Views\Payments\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>Chưa hoàn thành</td>\r\n");
#nullable restore
#line 50 "D:\DoAnASP\Views\Payments\Index.cshtml"
                      

                        if (item.Status == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td><p name=\"Status\" data-id=\"");
#nullable restore
#line 54 "D:\DoAnASP\Views\Payments\Index.cshtml"
                                                     Write(item.IDPayment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Đang xử lý</p></td>\r\n                            <td><button class=\"btn btn_primary\"");
            BeginWriteAttribute("id", "  id=\"", 2072, "\"", 2093, 1);
#nullable restore
#line 55 "D:\DoAnASP\Views\Payments\Index.cshtml"
WriteAttributeValue("", 2078, item.IDPayment, 2078, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"CancelOrther\" data-id=\"");
#nullable restore
#line 55 "D:\DoAnASP\Views\Payments\Index.cshtml"
                                                                                                              Write(item.IDPayment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" >Hủy đơn hàng</button   > </td>\r\n");
#nullable restore
#line 56 "D:\DoAnASP\Views\Payments\Index.cshtml"
                        }
                        if (item.Status == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Đang giao</td>\r\n");
#nullable restore
#line 60 "D:\DoAnASP\Views\Payments\Index.cshtml"
                        }
                        if (item.Status == 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Đã hoàn thành</td>\r\n");
#nullable restore
#line 64 "D:\DoAnASP\Views\Payments\Index.cshtml"
                        }
                        if (item.Status == 3)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td >Đã hủy</td>\r\n");
#nullable restore
#line 68 "D:\DoAnASP\Views\Payments\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                   \r\n                </tr>\r\n");
#nullable restore
#line 72 "D:\DoAnASP\Views\Payments\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n</section>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 80 "D:\DoAnASP\Views\Payments\Index.cshtml"
       await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"<script>
    $('button[name=CancelOrther]').click(function () {
        var id = $(this).attr('data-id');
       
        $.ajax({
            method: ""POST"",
            url: ""/api/Payment_API/UpdateStatusCancelOther/"",
            contentType: 'application/json; charset=UTF-8',
            data: JSON.stringify({
                ""ID"": id
               
            })
        })
            .done(function (msg) {
                if (msg == 'Success') {
                    alert('Đơn hàng đã được hủy');
                    $('p[name=Status][data-id=' + id + ']').html('Đã hủy');
                    document.getElementById(id).remove();
                }
                else {

                    alert('Hủy đơn hàng thất bại');
                }

            });

    })
</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoAnASP.Areas.Admin.Models.Payment> Html { get; private set; }
    }
}
#pragma warning restore 1591
