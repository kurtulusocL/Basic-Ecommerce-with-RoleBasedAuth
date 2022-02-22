#pragma checksum "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\User\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "960fa92db0afd8766664d8d14a0c5e19875bd515"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Profile), @"mvc.1.0.view", @"/Views/User/Profile.cshtml")]
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
#line 1 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\_ViewImports.cshtml"
using SimpleApp_RoleBasedAuth.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\_ViewImports.cshtml"
using SimpleApp_RoleBasedAuth.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\_ViewImports.cshtml"
using SimpleApp_RoleBasedAuth.Core.CrossCuttingConcern.Dtos.AccountDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\_ViewImports.cshtml"
using SimpleApp_RoleBasedAuth.Core.IoC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\_ViewImports.cshtml"
using SimpleApp_RoleBasedAuth.Core.Utilities.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\_ViewImports.cshtml"
using SimpleApp_RoleBasedAuth.Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\_ViewImports.cshtml"
using SimpleApp_RoleBasedAuth.Entities.Concrete.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"960fa92db0afd8766664d8d14a0c5e19875bd515", @"/Views/User/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f57b39989f1a053f12d9535e6cb1fcec7e4852f8", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\User\Profile.cshtml"
  
    TempData["Title"] = "Here your profile " + User.Identity.Name;
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\User\Profile.cshtml"
Write(TempData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<hr />\r\n<div class=\"container\">\r\n    <div>\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">Email Address</dt>\r\n            <dd class=\"col-sm-10\">");
#nullable restore
#line 13 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\User\Profile.cshtml"
                             Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n            <dt class=\"col-sm-2\">Username</dt>\r\n            <dd class=\"col-sm-10\">");
#nullable restore
#line 15 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\User\Profile.cshtml"
                             Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n            <dt class=\"col-sm-2\">Phone Number</dt>\r\n");
#nullable restore
#line 17 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\User\Profile.cshtml"
             if (Model.PhoneNumber != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dd class=\"col-sm-10\">");
#nullable restore
#line 19 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\User\Profile.cshtml"
                                 Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n");
#nullable restore
#line 20 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\User\Profile.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dd class=\"col-sm-10\">No Data</dd>\r\n");
#nullable restore
#line 24 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\User\Profile.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">Email Confirmed</dt>\r\n");
#nullable restore
#line 26 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\User\Profile.cshtml"
             if (Model.EmailConfirmed == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dd class=\"col-sm-10\">Email Confirmed</dd>\r\n");
#nullable restore
#line 29 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\User\Profile.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dd class=\"col-sm-10\">Email Not Confirmed</dd>\r\n");
#nullable restore
#line 33 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\User\Profile.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">Phone Number Confirmed</dt>\r\n");
#nullable restore
#line 35 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\User\Profile.cshtml"
             if (Model.PhoneNumberConfirmed == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dd class=\"col-sm-10\">Phone Number Confirmed</dd>\r\n");
#nullable restore
#line 38 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\User\Profile.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dd class=\"col-sm-10\">Phone Number Not Confirmed</dd>\r\n");
#nullable restore
#line 42 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\User\Profile.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">Register Date</dt>\r\n            <dd class=\"col-sm-10\">");
#nullable restore
#line 44 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\User\Profile.cshtml"
                             Write(Model.CreatedDate.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        </dl>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591