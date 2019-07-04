#pragma checksum "C:\Users\Administrator\source\repos\Shoes\TokenServiceApi\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d0a1a9037e81f9addfe98b98d0a0ab7673fd43a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "C:\Users\Administrator\source\repos\Shoes\TokenServiceApi\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Administrator\source\repos\Shoes\TokenServiceApi\Views\_ViewImports.cshtml"
using TokenServiceApi;

#line default
#line hidden
#line 3 "C:\Users\Administrator\source\repos\Shoes\TokenServiceApi\Views\_ViewImports.cshtml"
using TokenServiceApi.Models;

#line default
#line hidden
#line 4 "C:\Users\Administrator\source\repos\Shoes\TokenServiceApi\Views\_ViewImports.cshtml"
using IdentityServer4.Quickstart.UI;

#line default
#line hidden
#line 5 "C:\Users\Administrator\source\repos\Shoes\TokenServiceApi\Views\_ViewImports.cshtml"
using TokenServiceApi.Models.AccountViewModels;

#line default
#line hidden
#line 6 "C:\Users\Administrator\source\repos\Shoes\TokenServiceApi\Views\_ViewImports.cshtml"
using TokenServiceApi.Models.ManageViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d0a1a9037e81f9addfe98b98d0a0ab7673fd43a", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62da5d790b2a5cc226916b9ca76937dd9d65f81d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IdentityServer4.Quickstart.UI.ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Administrator\source\repos\Shoes\TokenServiceApi\Views\Shared\Error.cshtml"
  
    var error = Model?.Error?.Error;
    var request_id = Model?.Error?.RequestId;

#line default
#line hidden
            BeginContext(140, 232, true);
            WriteLiteral("\n<div class=\"error-page\">\n    <div class=\"page-header\">\n        <h1>Error</h1>\n    </div>\n\n    <div class=\"row\">\n        <div class=\"col-sm-6\">\n            <div class=\"alert alert-danger\">\n                Sorry, there was an error\n\n");
            EndContext();
#line 17 "C:\Users\Administrator\source\repos\Shoes\TokenServiceApi\Views\Shared\Error.cshtml"
                 if (error != null)
                {

#line default
#line hidden
            BeginContext(426, 88, true);
            WriteLiteral("                    <strong>\n                        <em>\n                            : ");
            EndContext();
            BeginContext(515, 5, false);
#line 21 "C:\Users\Administrator\source\repos\Shoes\TokenServiceApi\Views\Shared\Error.cshtml"
                         Write(error);

#line default
#line hidden
            EndContext();
            BeginContext(520, 61, true);
            WriteLiteral("\n                        </em>\n                    </strong>\n");
            EndContext();
#line 24 "C:\Users\Administrator\source\repos\Shoes\TokenServiceApi\Views\Shared\Error.cshtml"
                }

#line default
#line hidden
            BeginContext(599, 20, true);
            WriteLiteral("            </div>\n\n");
            EndContext();
#line 27 "C:\Users\Administrator\source\repos\Shoes\TokenServiceApi\Views\Shared\Error.cshtml"
             if (request_id != null)
            {

#line default
#line hidden
            BeginContext(670, 52, true);
            WriteLiteral("                <div class=\"request-id\">Request Id: ");
            EndContext();
            BeginContext(723, 10, false);
#line 29 "C:\Users\Administrator\source\repos\Shoes\TokenServiceApi\Views\Shared\Error.cshtml"
                                               Write(request_id);

#line default
#line hidden
            EndContext();
            BeginContext(733, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
#line 30 "C:\Users\Administrator\source\repos\Shoes\TokenServiceApi\Views\Shared\Error.cshtml"
            }

#line default
#line hidden
            BeginContext(754, 32, true);
            WriteLiteral("        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityServer4.Quickstart.UI.ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
