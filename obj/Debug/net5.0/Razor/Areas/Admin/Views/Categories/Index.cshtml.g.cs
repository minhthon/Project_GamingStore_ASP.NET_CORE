#pragma checksum "D:\DoAnASP\Areas\Admin\Views\Categories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cf43c7aeb7a431def4daf35f439ca5012914332"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Categories_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Categories/Index.cshtml")]
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
#line 1 "D:\DoAnASP\Areas\Admin\Views\_ViewImports.cshtml"
using DoAnASP.Areas.Admin.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DoAnASP\Areas\Admin\Views\_ViewImports.cshtml"
using DoAnASP.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cf43c7aeb7a431def4daf35f439ca5012914332", @"/Areas/Admin/Views/Categories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5b5ccd8da2c3a4eabbaf5c550bd79192f0d3cb7", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Categories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoAnASP.Areas.Admin.Models.Category>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DoAnASP\Areas\Admin\Views\Categories\Index.cshtml"
  
    ViewData["Title"] = "Danh mục";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--Modal thong bao cap nhap trang thai-->
<div class=""modal fade"" id=""ms_updatestatus"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <p class=""modal-title"" id=""message""></p>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
          
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Đóng</button>
            </div>
        </div>
    </div>
</div>

");
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral(@"<div class=""modal fade"" id=""details"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Thông tin danh mục </h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p style=""color:blueviolet; font-size:24px;text-align:center;"">Tên danh mục</p>
                <p style=""font-size:18px;text-align:center;color:black"" name=""name_details""></p>
                <p style=""color:blueviolet; font-size:24px;text-align:center;"">Hình ảnh</p>
                <div class=""container"">
                    <p name=""img_details""></p>
                </div>
                <p style=""color:blueviolet; fon");
            WriteLiteral(@"t-size:24px;text-align:center;"">Trạng thái</p>
                <p style=""font-size:18px;text-align:center;color:black"" name=""status_details""></p>
            </div>
            <div class=""modal-footer"">

                <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Đóng</button>
            </div>
        </div>
    </div>
</div>
");
            WriteLiteral("<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cf43c7aeb7a431def4daf35f439ca50129143327645", async() => {
                WriteLiteral("Tạo mới");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<section id=\"main-content\">\r\n    <section class=\"wrapper\">\r\n        <div style=\" margin-bottom: 20px;\" id=\"main-bottom\" class=\"container main-bottom\">\r\n            <div class=\"main-left-inner-fixed\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0cf43c7aeb7a431def4daf35f439ca50129143329046", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
        <div class=""container"">
            <button type=""button"" class=""button-toggle btn btn-outline-success btn-block"" onClick=""hiddenMainLeft();"">
                Hiện bảng thông tin để đăng nhập và chỉnh sửa
            </button>
        </div>
        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        Tên Danh Mục
                    </th>
                    <th>
                        Hình ảnh
                    </th>
                    <th>
                        Trạng thái
                    </th>
                    <th>Chức năng</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 87 "D:\DoAnASP\Areas\Admin\Views\Categories\Index.cshtml"
                 foreach (Category item in ViewBag.ListCategory)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr");
            BeginWriteAttribute("id", " id=\"", 3496, "\"", 3517, 1);
#nullable restore
#line 89 "D:\DoAnASP\Areas\Admin\Views\Categories\Index.cshtml"
WriteAttributeValue("", 3501, item.IDCategory, 3501, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <td>\r\n                            ");
#nullable restore
#line 91 "D:\DoAnASP\Areas\Admin\Views\Categories\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0cf43c7aeb7a431def4daf35f439ca501291433211925", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3728, "~/Image/ImageCategory/", 3728, 22, true);
#nullable restore
#line 94 "D:\DoAnASP\Areas\Admin\Views\Categories\Index.cshtml"
AddHtmlAttributeValue("", 3750, Html.DisplayFor(modelItem => item.Image), 3750, 41, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 97 "D:\DoAnASP\Areas\Admin\Views\Categories\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cf43c7aeb7a431def4daf35f439ca501291433213934", async() => {
                WriteLiteral("Chỉnh sửa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "D:\DoAnASP\Areas\Admin\Views\Categories\Index.cshtml"
                                                                                                        WriteLiteral(item.IDCategory);

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
            WriteLiteral("\r\n                            <button style=\"width:100px\" class=\"btn btn-outline-warning\" name=\"btn_update_status\" data-id=\"");
#nullable restore
#line 101 "D:\DoAnASP\Areas\Admin\Views\Categories\Index.cshtml"
                                                                                                                     Write(item.IDCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-status=\"");
#nullable restore
#line 101 "D:\DoAnASP\Areas\Admin\Views\Categories\Index.cshtml"
                                                                                                                                                     Write(item.Status==true? 0:1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-name=\"");
#nullable restore
#line 101 "D:\DoAnASP\Areas\Admin\Views\Categories\Index.cshtml"
                                                                                                                                                                                          Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n");
#nullable restore
#line 102 "D:\DoAnASP\Areas\Admin\Views\Categories\Index.cshtml"
                                 if (item.Status == true)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            WriteLiteral("Ẩn\r\n");
#nullable restore
#line 105 "D:\DoAnASP\Areas\Admin\Views\Categories\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            WriteLiteral("Hiện\r\n");
#nullable restore
#line 109 "D:\DoAnASP\Areas\Admin\Views\Categories\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </button>\r\n                            <button style=\"width:100px\" class=\"btn btn-outline-danger\" data-id=\"");
#nullable restore
#line 111 "D:\DoAnASP\Areas\Admin\Views\Categories\Index.cshtml"
                                                                                           Write(item.IDCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" name=\"btn_delete\" data-name=\"");
#nullable restore
#line 111 "D:\DoAnASP\Areas\Admin\Views\Categories\Index.cshtml"
                                                                                                                                          Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#exampleModal\">\r\n\r\n");
            WriteLiteral("                                    ");
            WriteLiteral("Xóa\r\n");
            WriteLiteral("\r\n                            </button>\r\n                            <button style=\"width:100px\" class=\"btn btn-outline-success\" data-id=\"");
#nullable restore
#line 118 "D:\DoAnASP\Areas\Admin\Views\Categories\Index.cshtml"
                                                                                            Write(item.IDCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" name=\"btn_details\" data-name=\"");
#nullable restore
#line 118 "D:\DoAnASP\Areas\Admin\Views\Categories\Index.cshtml"
                                                                                                                                            Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#details\" onclick=test()>\r\n\r\n");
            WriteLiteral("                                    ");
            WriteLiteral("Thông tin\r\n");
            WriteLiteral("                            </button>\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 127 "D:\DoAnASP\Areas\Admin\Views\Categories\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </section>\r\n</section>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 134 "D:\DoAnASP\Areas\Admin\Views\Categories\Index.cshtml"
       await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script>
       
        function hiddenMainLeft() {
            var hidden = document.getElementById('main-bottom');
            if (hidden.style.display === 'none') hidden.style.display = 'block';
            else hidden.style.display = 'none';
        }
        //script lấy thông tin danh mục
        $('button[name=btn_details]').click(function () {
            var id = $(this).attr('data-id');
            $.ajax({
                method: ""GET"",
                url: ""../api/Categories_API/GetCategory/"" + id,
                contentType: 'application/json; charset=UTF-8',
                data: JSON.stringify({
                    ""IDCategory"": id
                })
            })

                .done(function (msg) {

                    $('p[name=name_details]').html(msg.categoryName);
                    if (msg.status == true) {
                        $('p[name=status_details]').html(""Hiện"");
                    }
                    else {
                        $('p[na");
                WriteLiteral(@"me=status_details]').html(""Ẩn"");
                    }
                    $('p[name=img_details]').html('<img style=""margin-left: auto;margin-right: auto;display: block;"" src=""/Image/ImageCategory/' + msg.image + '""' + 'width = ""300px"" /> ');

                    console.log(msg);
                });


        })
        //script thay đổi trạng thái danh mục
        $('button[name=btn_update_status]').click(function () {
            var id = $(this).attr('data-id');
            var stt = ($(this).attr('data-status') == 0 ? false : true)
            $.ajax({
                method: ""POST"",
                url: ""../api/Categories_API/UpdateStatus/"",
                contentType: 'application/json; charset=UTF-8',
                data: JSON.stringify({
                    ""IDCategory"": id,
                    ""Status"": stt
                })
            })
                .done(function (msg) {
                    if (msg == '0') {
                       
                    }
         ");
                WriteLiteral(@"           else {
                        var r = JSON.parse(msg);
                        if (r.stt == 'True') {
                            $('button[name=btn_update_status][data-id=' + r.id + ']').html('Ẩn');
                        }
                        if (r.stt == 'False') {
                            $('button[name=btn_update_status][data-id=' + r.id + ']').html('Hiện');
                        }
                        $('#ms_updatestatus').modal('show');
                        $('p[id=message]').html('Thay đổi trạng thái danh mục thành công');
                    }

                });

        })
        //script xoa danh muc khoi he thong
        $('button[name=btn_delete]').click(function () {
            var id = $(this).attr('data-id');
            var name = $(this).attr('data-name');
            $.ajax({
                method: ""DELETE"",
                url: ""../api/Categories_API/DeleteCategory/"" + id,
                contentType: 'application/json; charset=UTF-8',");
                WriteLiteral(@"
                data: JSON.stringify({
                    ""IDCategory"": id
                })
            })
                .done(function (msg) {
                    if (msg == 'Success') {
                        document.getElementById(id).remove();
                        $('#ms_updatestatus').modal('show');
                        $('p[id=message]').html('Xóa danh mục thành công');

                    }
                    else {

                        alert('Xóa danh mục thất bại');
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoAnASP.Areas.Admin.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591