#pragma checksum "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f4cd0604c0cfc98c375f8903c11589dd9d5e355"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Gymone.Web.Models.Admin.Views_Admin_GetUsers), @"mvc.1.0.view", @"/Views/Admin/GetUsers.cshtml")]
namespace Gymone.Web.Models.Admin
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
#line 1 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\_ViewImports.cshtml"
using Gymone.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\_ViewImports.cshtml"
using Gymone.Web.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\_ViewImports.cshtml"
using Gymone.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f4cd0604c0cfc98c375f8903c11589dd9d5e355", @"/Views/Admin/GetUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0445f3f2fa0ae63abf34a76feb20125f2dcc8f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GetUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gymone.Web.Models.PaginatedList<ApplicationWebUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetUsers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("get"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-update", new global::Microsoft.AspNetCore.Html.HtmlString("#divGrid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-mode", new global::Microsoft.AspNetCore.Html.HtmlString("replace"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-loading", new global::Microsoft.AspNetCore.Html.HtmlString("#divloader"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
  ViewData["Title"] = "Get Users";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div id=\"divGrid\">\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f4cd0604c0cfc98c375f8903c11589dd9d5e3556237", async() => {
                WriteLiteral("\n        <br/>\n        <br/>\n        <h2 style=\"text-align:center;\">Get Users</h2>\n        <br/>\n        <br/>\n");
                WriteLiteral("\n        <div class=\"form-actions no-color\">\n            <p>\n                Find by name: <input type=\"text\" name=\"SearchString\"");
                BeginWriteAttribute("value", " value=\"", 868, "\"", 902, 1);
#nullable restore
#line 26 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
WriteAttributeValue("", 876, ViewData["CurrentFilter"], 876, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                <input type=\"submit\" value=\"Search\" class=\"btn btn-primary\" />  \n");
                WriteLiteral("            </p>\n        </div>\n\n\n        <table class=\"table\">\n            <thead>\n                <tr>\n                    <th>\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f4cd0604c0cfc98c375f8903c11589dd9d5e3557464", async() => {
                    WriteLiteral("First Name");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                                     WriteLiteral(ViewData["NameSortParm"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                                         WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                                     Write(Url.Action("GetUsers","Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral("?sortOrder=");
#nullable restore
#line 43 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                                                                               Write(ViewData["NameSortParm"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("&currentFilter=");
#nullable restore
#line 43 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                                                                                                                       Write(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("data-ajax-url", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    </th>\n                    <th>\n                        Last Name\n                    </th>\n                    <th>\n                        User Name\n                    </th>\n                    <th>\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f4cd0604c0cfc98c375f8903c11589dd9d5e35512385", async() => {
                    WriteLiteral("Email ID");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                                                          WriteLiteral(ViewData["EmailSortParm"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                                        WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                                     Write(Url.Action("GetUsers","Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral("?sortOrder=");
#nullable restore
#line 56 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                                                                               Write(ViewData["EmailSortParm"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("&currentFilter=");
#nullable restore
#line 56 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                                                                                                                        Write(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("data-ajax-url", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </th>
                    <th>
                        Email Confirmed
                    </th>
                    <th>
                        Mobile Number
                    </th>

                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 69 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\n                    <td>\n                        ");
#nullable restore
#line 73 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 76 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 79 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 82 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 85 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EmailConfirmed));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 88 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </td>\n");
                WriteLiteral("                </tr>\n");
#nullable restore
#line 103 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\n        </table>\n\n");
#nullable restore
#line 107 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
           var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
            var nextDisabled = !Model.HasNextPage ? "disabled" : ""; 

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f4cd0604c0cfc98c375f8903c11589dd9d5e35520412", async() => {
                    WriteLiteral("\n            Previous\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                    WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 112 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                      WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 113 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                        WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 5160, "btn", 5160, 3, true);
                AddHtmlAttributeValue(" ", 5163, "btn-default", 5164, 12, true);
#nullable restore
#line 114 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
AddHtmlAttributeValue(" ", 5175, prevDisabled, 5176, 13, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 116 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                     Write(Url.Action("GetUsers","Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral("?sortOrder=");
#nullable restore
#line 116 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                                                               Write(ViewData["CurrentSort"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("&pageNumber=");
#nullable restore
#line 116 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                                                                                                    Write(Model.PageIndex - 1);

#line default
#line hidden
#nullable disable
                WriteLiteral("&currentFilter=");
#nullable restore
#line 116 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                                                                                                                                        Write(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("data-ajax-url", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f4cd0604c0cfc98c375f8903c11589dd9d5e35526768", async() => {
                    WriteLiteral("\n            Next\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 120 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                    WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 121 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                      WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                        WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 5729, "btn", 5729, 3, true);
                AddHtmlAttributeValue(" ", 5732, "btn-default", 5733, 12, true);
#nullable restore
#line 123 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
AddHtmlAttributeValue(" ", 5744, nextDisabled, 5745, 13, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 125 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                     Write(Url.Action("GetUsers","Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral("?sortOrder=");
#nullable restore
#line 125 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                                                               Write(ViewData["CurrentSort"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("&pageNumber=");
#nullable restore
#line 125 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                                                                                                    Write(Model.PageIndex + 1);

#line default
#line hidden
#nullable disable
                WriteLiteral("&currentFilter=");
#nullable restore
#line 125 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                                                                                                                                        Write(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("data-ajax-url", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "D:\Personal\Profissional\GymOneCore\Gymone\Gymone.Web\Views\Admin\GetUsers.cshtml"
                                                                         Write(Url.Action("GetUsers", "Admin"));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-ajax-url", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gymone.Web.Models.PaginatedList<ApplicationWebUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
