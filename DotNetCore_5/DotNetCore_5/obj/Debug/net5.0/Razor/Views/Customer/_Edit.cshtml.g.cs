#pragma checksum "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Customer\_Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc2f9f37880ec3ee9daf16f311bd952661acecac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer__Edit), @"mvc.1.0.view", @"/Views/Customer/_Edit.cshtml")]
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
#line 1 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\_ViewImports.cshtml"
using DotNetCore_5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\_ViewImports.cshtml"
using DotNetCore_5.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\_ViewImports.cshtml"
using DotNetCore_5.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\_ViewImports.cshtml"
using DotNetCore_5.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\_ViewImports.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc2f9f37880ec3ee9daf16f311bd952661acecac", @"/Views/Customer/_Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1b30d4bc122c4320bbfa4d3217edd978bb658e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer__Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/CustomJS/JavaScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12 mx-auto\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc2f9f37880ec3ee9daf16f311bd952661acecac5913", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" ng-model=\"clickedCustomer.CustomerId\" />\r\n            <input type=\"hidden\" ng-model=\"clickedCustomer.ImageName\" />\r\n            <div class=\"col-md-12 mx-auto\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc2f9f37880ec3ee9daf16f311bd952661acecac6397", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 13 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Customer\_Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                <div class=""form-group mb-3"">
                    <label class=""form-label"">First Name</label>
                    <input type=""text"" class=""form-control"" ng-model=""clickedCustomer.FirstName"" />
                </div>
                <div class=""form-group mb-3"">
                    <label class=""form-label"">Last Name</label>

                    <input type=""text"" class=""form-control"" ng-model=""clickedCustomer.LastName"" />

                </div>
                <div class=""form-group position-relative mb-3"">
                    <label class=""form-label""> Date of Birth</label>
                    <input type=""date"" class=""form-control"" ng-model=""clickedCustomer.DateOfBirth"" />
                    

                </div>
                <div class=""form-group mb-3"">
                    <label class=""form-label"">Email </label>
                    <input type=""text"" class=""form-control"" ng-model=""clickedCustomer.Email"" />
                </div>
                <div class=""");
                WriteLiteral(@"form-group mb-3"">
                    <label class=""form-label"">City</label>
                    <input type=""text"" class=""form-control"" ng-model=""clickedCustomer.City"" />
                </div>
                <div class=""form-group mb-3"">
                    <label class=""form-label"">Address</label>
                    <input type=""text"" class=""form-control"" ng-model=""clickedCustomer.Address"" />
                </div>
                <div class=""form-group mb-3"">
                    <label class=""form-label"">Post Code</label>
                    <input type=""text"" class=""form-control"" ng-model=""clickedCustomer.PostCode"" />
                </div>
                <div class=""form-group mb-3"">
                    <label class=""form-label"">Phone Number</label>
                    <input type=""text"" class=""form-control"" ng-model=""clickedCustomer.PhoneNumber"" />
                </div>
                <div class=""form-group mb-3"">
                    <label class=""form-label mb-3"">Image</label>
 ");
                WriteLiteral(@"                   <img ng-src=""/images/customer_images/{{clickedCustomer.ImageName}}"" style=""height:90px!important; width:auto!important;"" class=""form-control change_edit mb-3"" />
                    <input class=""form-control change_image"" type=""file"" ngf-select=""UploadFiles($files)""  />
                </div>
            </div>
            <div class=""form-group"">
                <div class=""col-sm-offset-2 col-sm-10"">
    
                    <button type=""submit"" class=""btn btn-primary clear-photo"" data-bs-dismiss=""modal"" ng-click=""UpdateCustomer()"">Edit</button>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc2f9f37880ec3ee9daf16f311bd952661acecac12014", async() => {
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
