#pragma checksum "C:\Users\bure\Desktop\UTB\5. semestr\PWT\cviko\eshop\eshop\Views\Shared\ErrorCodeStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51711e9f21991b2e3d7ae10ab4b8e5c25e403812"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ErrorCodeStatus), @"mvc.1.0.view", @"/Views/Shared/ErrorCodeStatus.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ErrorCodeStatus.cshtml", typeof(AspNetCore.Views_Shared_ErrorCodeStatus))]
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
#line 1 "C:\Users\bure\Desktop\UTB\5. semestr\PWT\cviko\eshop\eshop\Views\_ViewImports.cshtml"
using eshop;

#line default
#line hidden
#line 2 "C:\Users\bure\Desktop\UTB\5. semestr\PWT\cviko\eshop\eshop\Views\_ViewImports.cshtml"
using eshop.Models;

#line default
#line hidden
#line 3 "C:\Users\bure\Desktop\UTB\5. semestr\PWT\cviko\eshop\eshop\Views\_ViewImports.cshtml"
using eshop.Models.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51711e9f21991b2e3d7ae10ab4b8e5c25e403812", @"/Views/Shared/ErrorCodeStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ba79d71e7729b9ec2dfae0bd2c8bef63a5b8172", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ErrorCodeStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorCodeStatusViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\bure\Desktop\UTB\5. semestr\PWT\cviko\eshop\eshop\Views\Shared\ErrorCodeStatus.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
            BeginContext(74, 52, true);
            WriteLiteral("\r\n<h1 class=\"text-danger\">Status Code Error</h1>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\bure\Desktop\UTB\5. semestr\PWT\cviko\eshop\eshop\Views\Shared\ErrorCodeStatus.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(150, 55, true);
            WriteLiteral("    <p>\r\n        <strong> Status Code: </strong> <code>");
            EndContext();
            BeginContext(206, 16, false);
#line 11 "C:\Users\bure\Desktop\UTB\5. semestr\PWT\cviko\eshop\eshop\Views\Shared\ErrorCodeStatus.cshtml"
                                         Write(Model.StatusCode);

#line default
#line hidden
            EndContext();
            BeginContext(222, 19, true);
            WriteLiteral("</code>\r\n    </p>\r\n");
            EndContext();
            BeginContext(243, 55, true);
            WriteLiteral("    <p>\r\n        <strong> Original URL </strong> <code>");
            EndContext();
            BeginContext(299, 17, false);
#line 15 "C:\Users\bure\Desktop\UTB\5. semestr\PWT\cviko\eshop\eshop\Views\Shared\ErrorCodeStatus.cshtml"
                                         Write(Model.OriginalURL);

#line default
#line hidden
            EndContext();
            BeginContext(316, 19, true);
            WriteLiteral("</code>\r\n    </p>\r\n");
            EndContext();
#line 17 "C:\Users\bure\Desktop\UTB\5. semestr\PWT\cviko\eshop\eshop\Views\Shared\ErrorCodeStatus.cshtml"
}

#line default
#line hidden
            BeginContext(338, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorCodeStatusViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
