#pragma checksum "D:\C#\HomeCare\HomeCare\Areas\Admin\Views\BillOption\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8e83f91360c93a61a47d107c46321c0748880ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BillOption_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/BillOption/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/BillOption/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_BillOption_Index))]
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
#line 1 "D:\C#\HomeCare\HomeCare\Areas\Admin\Views\_ViewImports.cshtml"
using HomeCare;

#line default
#line hidden
#line 2 "D:\C#\HomeCare\HomeCare\Areas\Admin\Views\_ViewImports.cshtml"
using HomeCare.Models;

#line default
#line hidden
#line 3 "D:\C#\HomeCare\HomeCare\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 4 "D:\C#\HomeCare\HomeCare\Areas\Admin\Views\_ViewImports.cshtml"
using HomeCare.Application.ViewModels.Admin;

#line default
#line hidden
#line 5 "D:\C#\HomeCare\HomeCare\Areas\Admin\Views\_ViewImports.cshtml"
using HomeCare.Application.Common;

#line default
#line hidden
#line 6 "D:\C#\HomeCare\HomeCare\Areas\Admin\Views\_ViewImports.cshtml"
using HomeCare.Application.Common.Admin;

#line default
#line hidden
#line 7 "D:\C#\HomeCare\HomeCare\Areas\Admin\Views\_ViewImports.cshtml"
using HomeCare.Utilities.Constants;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8e83f91360c93a61a47d107c46321c0748880ca", @"/Areas/Admin/Views/BillOption/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d829a3d2ae558687171138e8d6512126770ca7b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_BillOption_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-side/controller/FixCss/FixTh.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-side/controller/billoption/index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "20", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "30", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "50", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\C#\HomeCare\HomeCare\Areas\Admin\Views\BillOption\Index.cshtml"
  
    ViewData["Title"] = "BillOption";

#line default
#line hidden
            BeginContext(48, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(69, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(77, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d99b96fa87264dd3aa2159850cd87d4f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(150, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(157, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(177, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(185, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13b617e44796410d8114dc7089424905", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(252, 130, true);
                WriteLiteral("\r\n    <script>        \r\n        loadData();        \r\n        $.when(loadHelperNumber()).done(registerEvents());\r\n    </script>\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(385, 2047, true);
            WriteLiteral(@"

<div class=""page-title"">
    <div class=""title_left"">
        <h3>Bill Options <small>List bill options</small></h3>
    </div>
    <div class=""title_right"">

        <div class=""col-md-5 col-sm-5 col-xs-12 form-group pull-right"">
            <div class=""input-group"">
                <input type=""text"" id=""txtKeyword"" class=""form-control"" placeholder=""Search for..."">
                <span class=""input-group-btn"">
                    <button class=""btn btn-primary"" id=""btnSearch"" type=""button"">Go!</button>
                </span>
            </div>
        </div>

        <div class=""col-md-2 col-sm-12 col-xs-12 form-group pull-right"">
            <button id=""btnCreate"" class=""btn btn-success""><i class=""fa fa-pencil-square-o""></i> Create</button>
        </div>

    </div>
</div>

<div class=""clearfix""></div>

<div class=""row"">
    <div class=""col-md-12 col-sm-12 col-xs-12"">
        <div class=""x_panel"">
            <div class=""x_content"">
                <table class=""table tab");
            WriteLiteral(@"le-bordered"">
                    <thead>
                        <tr>
                            <th class=""index_thead_th"">Workinghours</th>
                            <th class=""index_thead_th"">Acreage</th>
                            <th class=""index_thead_th"">Rooms</th>
                            <th class=""index_thead_th"">Price</th>
                            <th class=""index_thead_th"">Status</th>
                            <th class=""index_thead_th"" width=""20%"">Function</th>
                        </tr>
                    </thead>
                    <tbody id=""tbl-content""></tbody>
                </table>

                <!--Pagination-->
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-sm-5"">
                            <div class=""dataTables_info"" id=""datatable-checkbox_info"" role=""status"" aria-live=""polite"">
                                <select id=""ddlShowPage"">
                                    ");
            EndContext();
            BeginContext(2432, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab8c7fe9e9ce40dcb244d2b7507c93df", async() => {
                BeginContext(2471, 2, true);
                WriteLiteral("10");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2482, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2520, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b31a40666c61429c84f10a8bcd1cdb76", async() => {
                BeginContext(2539, 2, true);
                WriteLiteral("20");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2550, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2588, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f1107925c714bfeadcc3e4f60d40645", async() => {
                BeginContext(2607, 2, true);
                WriteLiteral("30");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2618, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2656, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9a15049084a44b093f80be7dc9f3552", async() => {
                BeginContext(2675, 2, true);
                WriteLiteral("50");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2686, 1274, true);
            WriteLiteral(@"
                                </select>
                                <span class=""item-per-page"">
                                    Record/Page.
                                </span>
                                Total records: <strong id=""lblTotalRecords""></strong>
                            </div>
                        </div>
                        <div class=""col-sm-7"">
                            <div class=""dataTables_paginate paging_simple_numbers"" id=""datatable-checkbox_paginate"">
                                <ul id=""paginationUL""></ul>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</div>
<script id=""table-template"" type=""x-tmpl-mustache"">
    <tr>
        <td>{{workinghours}}</td>
        <td>{{acreage}}</td>
        <td>{{rooms}}</td>
        <td>{{{price}}}</td>
        <td>{{{status}}}</td>
        <th scope=""row"">
            <button cla");
            WriteLiteral("ss=\"btn btn-primary btn-sm btn-edit\" data-id=\"{{Id}}\"><i class=\"fa fa-pencil\"></i></button>\r\n            <button class=\"btn btn-danger btn-sm btn-delete\" data-id=\"{{Id}}\"><i class=\"fa fa-trash\"></i></button>\r\n        </th>\r\n    </tr>\r\n</script>\r\n\r\n\r\n");
            EndContext();
            BeginContext(3961, 47, false);
#line 110 "D:\C#\HomeCare\HomeCare\Areas\Admin\Views\BillOption\Index.cshtml"
Write(await Html.PartialAsync("_AddEditModal.cshtml"));

#line default
#line hidden
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
