#pragma checksum "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Further\FurtherUserApp\WebApp\Views\User\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e31507397f8c9171e5e62be968ef2babbd2d4f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Users), @"mvc.1.0.view", @"/Views/User/Users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Users.cshtml", typeof(AspNetCore.Views_User_Users))]
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
#line 1 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Further\FurtherUserApp\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#line 2 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Further\FurtherUserApp\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#line 3 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Further\FurtherUserApp\WebApp\Views\_ViewImports.cshtml"
using ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e31507397f8c9171e5e62be968ef2babbd2d4f8", @"/Views/User/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cd13d592e4f0a61ef257bfdc656da9e94aba15e", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("save"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SaveExcel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Further\FurtherUserApp\WebApp\Views\User\Users.cshtml"
  
    ViewData["Title"] = "Users";

#line default
#line hidden
            BeginContext(78, 20, true);
            WriteLiteral("\r\n<h2>Users</h2>\r\n\r\n");
            EndContext();
            BeginContext(98, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e532958c6fe04fe489373114c508d9ea", async() => {
                BeginContext(194, 10, true);
                WriteLiteral("Save excel");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
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
            BeginContext(208, 366, true);
            WriteLiteral(@"

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">First name</th>
            <th scope=""col"">Last name</th>
            <th scope=""col"">Username</th>
            <th scope=""col"">Permission to login</th>
            <th scope=""col"">Company</th>
            <th scope=""col"">Actions</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 23 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Further\FurtherUserApp\WebApp\Views\User\Users.cshtml"
         foreach (var user in Model)
        {

#line default
#line hidden
            BeginContext(623, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(654, 14, false);
#line 26 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Further\FurtherUserApp\WebApp\Views\User\Users.cshtml"
           Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(668, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(692, 13, false);
#line 27 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Further\FurtherUserApp\WebApp\Views\User\Users.cshtml"
           Write(user.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(705, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(729, 13, false);
#line 28 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Further\FurtherUserApp\WebApp\Views\User\Users.cshtml"
           Write(user.Username);

#line default
#line hidden
            EndContext();
            BeginContext(742, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 29 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Further\FurtherUserApp\WebApp\Views\User\Users.cshtml"
             if (user.PermissionToLogin)
            {

#line default
#line hidden
            BeginContext(806, 43, true);
            WriteLiteral("                <td>Allowed to login</td>\r\n");
            EndContext();
#line 32 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Further\FurtherUserApp\WebApp\Views\User\Users.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(897, 47, true);
            WriteLiteral("                <td>Not allowed to login</td>\r\n");
            EndContext();
#line 36 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Further\FurtherUserApp\WebApp\Views\User\Users.cshtml"
            }

#line default
#line hidden
            BeginContext(959, 18, true);
            WriteLiteral("\r\n            <td>");
            EndContext();
            BeginContext(978, 17, false);
#line 38 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Further\FurtherUserApp\WebApp\Views\User\Users.cshtml"
           Write(user.Company.Name);

#line default
#line hidden
            EndContext();
            BeginContext(995, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1018, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4808b7fc1be8434ab17e9906d737c696", async() => {
                BeginContext(1123, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Further\FurtherUserApp\WebApp\Views\User\Users.cshtml"
                                                                                     WriteLiteral(user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1131, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 41 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Further\FurtherUserApp\WebApp\Views\User\Users.cshtml"
        }

#line default
#line hidden
            BeginContext(1164, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
