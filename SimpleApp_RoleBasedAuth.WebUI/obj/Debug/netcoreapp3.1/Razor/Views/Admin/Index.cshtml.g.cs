#pragma checksum "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ec17c16e8b5509792d3b68d54940897720ca36c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ec17c16e8b5509792d3b68d54940897720ca36c", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f57b39989f1a053f12d9535e6cb1fcec7e4852f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Admin Home";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 6 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\Admin\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>");
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