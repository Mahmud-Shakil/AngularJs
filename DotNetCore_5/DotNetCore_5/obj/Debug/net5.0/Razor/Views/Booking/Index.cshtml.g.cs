#pragma checksum "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d84d2b4fa99575cb1dbfb98d9f9f3902a175c2f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Index), @"mvc.1.0.view", @"/Views/Booking/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d84d2b4fa99575cb1dbfb98d9f9f3902a175c2f0", @"/Views/Booking/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1b30d4bc122c4320bbfa4d3217edd978bb658e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookingViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Booking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure to delete?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Booking/_Edit.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Booking/_Details.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Booking Index</h1>\r\n<div>\r\n    <p>\r\n        <button type=\"button\" class=\"btn btn-dark\" data-bs-toggle=\"modal\" data-bs-target=\"#CreateModal\">Create New</button>\r\n    </p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d84d2b4fa99575cb1dbfb98d9f9f3902a175c2f09121", async() => {
                WriteLiteral("\r\n        <div class=\"btnSearch\">\r\n            <p>\r\n                Find by name: <input type=\"text\" name=\"SearchString\"");
                BeginWriteAttribute("value", " value=\"", 465, "\"", 495, 1);
#nullable restore
#line 15 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
WriteAttributeValue("", 473, ViewBag.CurrentFilter, 473, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"submit\" value=\"Search\" class=\"btn btn-info\" /> &nbsp;&nbsp;\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d84d2b4fa99575cb1dbfb98d9f9f3902a175c2f010022", async() => {
                    WriteLiteral("Back to Full List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </p>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<table class=""table table-bordered table-striped list_table"">
    <thead>
        <tr>
            <th>
                SL
            </th>
            <th>
                Customer Name
            </th>
            <th>
                Pick Up Date
            </th>

            <th>
                Drop out Date
            </th>
            <th>
                Total Hiring Days
            </th>
            <th>
                Pick Up Point
            </th>
            <th>
                Drop Point
            </th>
           
            <th>
                ");
#nullable restore
#line 49 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
           Write(Html.ActionLink("City", "Index", new { SortOrder = ViewBag.SortNameParam }, new { @class = "text-decoration-none" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </th>
            <th>
                Post Code
            </th>
            <th>
                Phone No
            </th>
            <th>
                Model
            </th>
            <th>
                Image
            </th>
            <th>
               Daily Hire Rate 
            </th>
            <th>
                Total
            </th>
            <th class=""text-center tbl_action"">Actions</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 73 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
           Write(item.SerialNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
           Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 84 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
           Write(item.PickUpDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 87 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
           Write(item.DropOutDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td >\r\n                ");
#nullable restore
#line 90 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
           Write(item.TotalDaysOfHiring);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 93 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
           Write(item.HirePoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 96 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
           Write(item.DropPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 99 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
           Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 102 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
           Write(item.PostCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 105 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
           Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 108 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
           Write(item.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"text-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d84d2b4fa99575cb1dbfb98d9f9f3902a175c2f017876", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/images/customer_images/");
#nullable restore
#line 111 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
                                       WriteLiteral(item.ImageName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 111 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 114 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
           Write(item.DailyHireRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td >\r\n                ");
#nullable restore
#line 117 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
           Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n\r\n                <a href=\"#\" class=\"btn btn-warning\" name=\"details\"");
            BeginWriteAttribute("onclick", "\r\n                   onclick=\'", 3245, "\'", 3306, 3);
            WriteAttributeValue("", 3275, "EditRecord(\"+", 3275, 13, true);
#nullable restore
#line 122 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
WriteAttributeValue("", 3288, item.BookingId, 3288, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3303, "+\")", 3303, 3, true);
            EndWriteAttribute();
            WriteLiteral(" data-bs-toggle=\"modal\" data-bs-target=\"#EditModal\">Edit</a>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d84d2b4fa99575cb1dbfb98d9f9f3902a175c2f021810", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 123 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
                                                                  WriteLiteral(item.BookingId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </tr>\r\n");
#nullable restore
#line 125 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div id=\"itemsDiv\">\r\n</div>\r\n");
#nullable restore
#line 130 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page = page }),
new X.PagedList.Web.Common.PagedListRenderOptions
{
    ContainerDivClasses = new[] { "navication" },
    LiElementClasses = new[] { "page-item" },
    PageClasses = new[] { "page-link" },
}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"modal fade\" id=\"CreateModal\" tabindex=\"-1\" aria-labelledby=\"CreateModalLabel\" aria-hidden=\"true\">\r\n    <div class=\"modal-dialog\">\r\n        <div class=\"modal-content\">\r\n            ");
#nullable restore
#line 140 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
       Write(await Html.PartialAsync("_Create", new BookingViewModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</div>
<div class=""modal fade"" id=""EditModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header px-md-5"">
                <h3 class=""modal-title"" id=""detailsModalLabel"">Update Booking</h3>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body px-md-5"">
                <div id=""EditDiv"">
");
#nullable restore
#line 153 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
                     if (ViewBag.Details == "Show")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d84d2b4fa99575cb1dbfb98d9f9f3902a175c2f026566", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 156 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
                        ViewBag.Details = "Show";
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""detailsModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header px-md-5"">
                <h3 class=""modal-title"" id=""detailsModalLabel"">Details</h3>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body px-md-5"">
                <div id=""DetailsDiv"">
");
#nullable restore
#line 172 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
                     if (ViewBag.Details == "Show")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d84d2b4fa99575cb1dbfb98d9f9f3902a175c2f028900", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 175 "D:\IDB-IT\AngularAndSingnalR\Evidence\DotNetCore_5\DotNetCore_5\Views\Booking\Index.cshtml"
                        ViewBag.Details = "Show";
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>


<script>
    function EditRecord(BookingId) {
        $.ajax({
            url: ""/Booking/Edit?id="" + BookingId,
            type: ""GET"",
            data: """",
            contentType: 'application/json; charset = utf-8',
            success: function (data) {
                $('#EditDiv').show();
                $('#EditDiv').html(data);
            },
            error: function () {
                alert(""Error occured"")
            }
        })
    };
    function calculateDifference() {

        // Get both values from input field and convert them into Javascript Date object
        var date1 = new Date($(""#PickUpDate"").val());
        var date2 = new Date($(""#DropOutDate"").val());

        // Difference can be calculated by subtracting the first date timestamp from second date timestamp
        var timeDifference = date2.getTime() - date1.getTime();

        // Just for debugging purpose
       ");
            WriteLiteral(@" console.log(timeDifference);
        // There are 1000 milliseconds in 1 second
        var milliSecondsInOneSecond = 1000;

        // There are 3600 seconds in 1 hour
        var secondsInOneHour = 3600;

        // And we all know there are 24 hours in 1 day
        var hoursInOneDay = 24;
        var days = timeDifference / (milliSecondsInOneSecond * secondsInOneHour * hoursInOneDay);
        console.log(days);
        alert(days);
        $(""#TotalDaysOfHiring"").val(days);
    }
    function calcualte() {
        var date = parseInt($('#TotalDaysOfHiring').val());
        var total = parseInt($('#DailyHireRate').val());
        $(""#Total"").val(date * total);
       
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookingViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
