#pragma checksum "C:\Users\bitstudent\OneDrive - Waukesha County Technical College\Advanced Web\ModasAdmin\ModasAdmin\Views\RoleAdmin\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "757fe7cae2d9b82c5fb357d2c778f08bb197c69e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ModasAdmin.Models.RoleAdmin.Views_RoleAdmin_Edit), @"mvc.1.0.view", @"/Views/RoleAdmin/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RoleAdmin/Edit.cshtml", typeof(ModasAdmin.Models.RoleAdmin.Views_RoleAdmin_Edit))]
namespace ModasAdmin.Models.RoleAdmin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\Users\bitstudent\OneDrive - Waukesha County Technical College\Advanced Web\ModasAdmin\ModasAdmin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"757fe7cae2d9b82c5fb357d2c778f08bb197c69e", @"/Views/RoleAdmin/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca6e71f2c832fc95bd929a4555f8805f9d944a18", @"/Views/_ViewImports.cshtml")]
    public class Views_RoleAdmin_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleEditModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 73, true);
            WriteLiteral("\r\n<div class=\"bg-primary m-1 p-1 text-white\"><h4>Edit Role</h4></div>\r\n\r\n");
            EndContext();
            BeginContext(95, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "757fe7cae2d9b82c5fb357d2c778f08bb197c69e5338", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 5 "C:\Users\bitstudent\OneDrive - Waukesha County Technical College\Advanced Web\ModasAdmin\ModasAdmin\Views\RoleAdmin\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(155, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(159, 1565, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "757fe7cae2d9b82c5fb357d2c778f08bb197c69e7092", async() => {
                BeginContext(197, 42, true);
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"roleName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 239, "\"", 263, 1);
#line 8 "C:\Users\bitstudent\OneDrive - Waukesha County Technical College\Advanced Web\ModasAdmin\ModasAdmin\Views\RoleAdmin\Edit.cshtml"
WriteAttributeValue("", 247, Model.Role.Name, 247, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(264, 43, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"roleId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 307, "\"", 329, 1);
#line 9 "C:\Users\bitstudent\OneDrive - Waukesha County Technical College\Advanced Web\ModasAdmin\ModasAdmin\Views\RoleAdmin\Edit.cshtml"
WriteAttributeValue("", 315, Model.Role.Id, 315, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(330, 53, true);
                WriteLiteral(" />\r\n\r\n    <h6 class=\"bg-info p-1 text-white\">Add To ");
                EndContext();
                BeginContext(384, 15, false);
#line 11 "C:\Users\bitstudent\OneDrive - Waukesha County Technical College\Advanced Web\ModasAdmin\ModasAdmin\Views\RoleAdmin\Edit.cshtml"
                                         Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(399, 58, true);
                WriteLiteral("</h6>\r\n    <table class=\"table table-bordered table-sm\">\r\n");
                EndContext();
#line 13 "C:\Users\bitstudent\OneDrive - Waukesha County Technical College\Advanced Web\ModasAdmin\ModasAdmin\Views\RoleAdmin\Edit.cshtml"
         if (Model.NonMembers.Count() == 0)
        {

#line default
#line hidden
                BeginContext(513, 65, true);
                WriteLiteral("            <tr><td colspan=\"2\">All Users Are Members</td></tr>\r\n");
                EndContext();
#line 16 "C:\Users\bitstudent\OneDrive - Waukesha County Technical College\Advanced Web\ModasAdmin\ModasAdmin\Views\RoleAdmin\Edit.cshtml"
        }
        else
        {
            

#line default
#line hidden
#line 19 "C:\Users\bitstudent\OneDrive - Waukesha County Technical College\Advanced Web\ModasAdmin\ModasAdmin\Views\RoleAdmin\Edit.cshtml"
             foreach (AppUser user in Model.NonMembers)
            {

#line default
#line hidden
                BeginContext(686, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(733, 13, false);
#line 22 "C:\Users\bitstudent\OneDrive - Waukesha County Technical College\Advanced Web\ModasAdmin\ModasAdmin\Views\RoleAdmin\Edit.cshtml"
                   Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(746, 95, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        <input type=\"checkbox\" name=\"IdsToAdd\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 841, "\"", 857, 1);
#line 24 "C:\Users\bitstudent\OneDrive - Waukesha County Technical College\Advanced Web\ModasAdmin\ModasAdmin\Views\RoleAdmin\Edit.cshtml"
WriteAttributeValue("", 849, user.Id, 849, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(858, 55, true);
                WriteLiteral(" />\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 27 "C:\Users\bitstudent\OneDrive - Waukesha County Technical College\Advanced Web\ModasAdmin\ModasAdmin\Views\RoleAdmin\Edit.cshtml"
            }

#line default
#line hidden
#line 27 "C:\Users\bitstudent\OneDrive - Waukesha County Technical College\Advanced Web\ModasAdmin\ModasAdmin\Views\RoleAdmin\Edit.cshtml"
             
        }

#line default
#line hidden
                BeginContext(939, 67, true);
                WriteLiteral("    </table>\r\n\r\n    <h6 class=\"bg-info p-1 text-white\">Remove From ");
                EndContext();
                BeginContext(1007, 15, false);
#line 31 "C:\Users\bitstudent\OneDrive - Waukesha County Technical College\Advanced Web\ModasAdmin\ModasAdmin\Views\RoleAdmin\Edit.cshtml"
                                              Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1022, 58, true);
                WriteLiteral("</h6>\r\n    <table class=\"table table-bordered table-sm\">\r\n");
                EndContext();
#line 33 "C:\Users\bitstudent\OneDrive - Waukesha County Technical College\Advanced Web\ModasAdmin\ModasAdmin\Views\RoleAdmin\Edit.cshtml"
         if (Model.Members.Count() == 0)
        {

#line default
#line hidden
                BeginContext(1133, 64, true);
                WriteLiteral("            <tr><td colspan=\"2\">No Users Are Members</td></tr>\r\n");
                EndContext();
#line 36 "C:\Users\bitstudent\OneDrive - Waukesha County Technical College\Advanced Web\ModasAdmin\ModasAdmin\Views\RoleAdmin\Edit.cshtml"
        }
        else
        {
            

#line default
#line hidden
#line 39 "C:\Users\bitstudent\OneDrive - Waukesha County Technical College\Advanced Web\ModasAdmin\ModasAdmin\Views\RoleAdmin\Edit.cshtml"
             foreach (AppUser user in Model.Members)
            {

#line default
#line hidden
                BeginContext(1302, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(1349, 13, false);
#line 42 "C:\Users\bitstudent\OneDrive - Waukesha County Technical College\Advanced Web\ModasAdmin\ModasAdmin\Views\RoleAdmin\Edit.cshtml"
                   Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(1362, 98, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        <input type=\"checkbox\" name=\"IdsToDelete\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1460, "\"", 1476, 1);
#line 44 "C:\Users\bitstudent\OneDrive - Waukesha County Technical College\Advanced Web\ModasAdmin\ModasAdmin\Views\RoleAdmin\Edit.cshtml"
WriteAttributeValue("", 1468, user.Id, 1468, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1477, 55, true);
                WriteLiteral(" />\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 47 "C:\Users\bitstudent\OneDrive - Waukesha County Technical College\Advanced Web\ModasAdmin\ModasAdmin\Views\RoleAdmin\Edit.cshtml"
            }

#line default
#line hidden
#line 47 "C:\Users\bitstudent\OneDrive - Waukesha County Technical College\Advanced Web\ModasAdmin\ModasAdmin\Views\RoleAdmin\Edit.cshtml"
             
        }

#line default
#line hidden
                BeginContext(1558, 91, true);
                WriteLiteral("    </table>\r\n    <button type=\"submit\" class=\"btn btn-outline-primary\">Save</button>\r\n    ");
                EndContext();
                BeginContext(1649, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "757fe7cae2d9b82c5fb357d2c778f08bb197c69e14816", async() => {
                    BeginContext(1705, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1715, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1724, 1, true);
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleEditModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
