#pragma checksum "C:\Users\Ahmed Rabie g\Documents\My-Github\ASP.NetCore-Application\EmployeeManagement\Views\Shared\Errors.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f752d944f2a1d7db855b10e8900e34a38aac139"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Errors), @"mvc.1.0.view", @"/Views/Shared/Errors.cshtml")]
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
#line 1 "C:\Users\Ahmed Rabie g\Documents\My-Github\ASP.NetCore-Application\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ahmed Rabie g\Documents\My-Github\ASP.NetCore-Application\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ahmed Rabie g\Documents\My-Github\ASP.NetCore-Application\EmployeeManagement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f752d944f2a1d7db855b10e8900e34a38aac139", @"/Views/Shared/Errors.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"117034e69b60d022d898ed615c23608ef1431b4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Errors : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Ahmed Rabie g\Documents\My-Github\ASP.NetCore-Application\EmployeeManagement\Views\Shared\Errors.cshtml"
  if (ViewBag.ErrorTitle == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>\r\n            An occured while processing your request.\r\n            The support team is notified and we are working on the fix\r\n        </h3>\r\n        <h5>Please contact us on pragim@pragimtech.com</h5>\r\n");
#nullable restore
#line 8 "C:\Users\Ahmed Rabie g\Documents\My-Github\ASP.NetCore-Application\EmployeeManagement\Views\Shared\Errors.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1 class=\"text-danger\">");
#nullable restore
#line 11 "C:\Users\Ahmed Rabie g\Documents\My-Github\ASP.NetCore-Application\EmployeeManagement\Views\Shared\Errors.cshtml"
                           Write(ViewBag.ErrorTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <h6 class=\"text-danger\">");
#nullable restore
#line 12 "C:\Users\Ahmed Rabie g\Documents\My-Github\ASP.NetCore-Application\EmployeeManagement\Views\Shared\Errors.cshtml"
                           Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 13 "C:\Users\Ahmed Rabie g\Documents\My-Github\ASP.NetCore-Application\EmployeeManagement\Views\Shared\Errors.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
