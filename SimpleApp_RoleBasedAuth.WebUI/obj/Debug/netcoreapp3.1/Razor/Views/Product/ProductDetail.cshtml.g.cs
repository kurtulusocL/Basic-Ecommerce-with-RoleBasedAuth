#pragma checksum "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\Product\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aacf04a61c2b45d5b38462dfba822c84bccf8160"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductDetail), @"mvc.1.0.view", @"/Views/Product/ProductDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aacf04a61c2b45d5b38462dfba822c84bccf8160", @"/Views/Product/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f57b39989f1a053f12d9535e6cb1fcec7e4852f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\Product\ProductDetail.cshtml"
  
    ViewData["Title"] = Model.Name + " Detail";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\Product\ProductDetail.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<hr />\r\n<div class=\"container\">\r\n    <div>\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">Title</dt>\r\n            <dd class=\"col-sm-10\">");
#nullable restore
#line 13 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\Product\ProductDetail.cshtml"
                             Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n            <dt class=\"col-sm-2\">Description</dt>\r\n            <dd class=\"col-sm-10\">");
#nullable restore
#line 15 "C:\Users\kurtulusocL\Desktop\SimpleApp_RoleBasedAuth\SimpleApp_RoleBasedAuth.WebUI\Views\Product\ProductDetail.cshtml"
                             Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        </dl>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
