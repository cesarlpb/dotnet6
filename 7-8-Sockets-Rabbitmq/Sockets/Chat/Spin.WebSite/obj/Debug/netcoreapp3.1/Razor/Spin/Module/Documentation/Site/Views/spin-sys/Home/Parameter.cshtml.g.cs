#pragma checksum "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Documentation/Site/Views/spin-sys/Home/Parameter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17482a1b22c074bea65243ee9c8ec81117ba7c1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Module_Documentation_Site_Views_spin_sys_Home_Parameter), @"mvc.1.0.view", @"/Spin/Module/Documentation/Site/Views/spin-sys/Home/Parameter.cshtml")]
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
#line 3 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/_ViewImports.cshtml"
using Spin.WebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/_ViewImports.cshtml"
using Spin.Base.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/_ViewImports.cshtml"
using Spin.Helper.Extend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/_ViewImports.cshtml"
using Spin.Modules.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/_ViewImports.cshtml"
using Spin.Base.Helper.Extend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/_ViewImports.cshtml"
using Spin.Base.Helper.Company;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Documentation/Site/Views/spin-sys/Home/Parameter.cshtml"
using Spin.Base.Documentation.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Documentation/Site/Views/spin-sys/Home/Parameter.cshtml"
using Spin.Base.Documentation.Language;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17482a1b22c074bea65243ee9c8ec81117ba7c1a", @"/Spin/Module/Documentation/Site/Views/spin-sys/Home/Parameter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3ca8c78acceb1c9067e6e5253e8e15db21c1ef", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Module_Documentation_Site_Views_spin_sys_Home_Parameter : Spin.Base.Extend.Page.SpinWebViewPage<MemberDocument>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 8 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Documentation/Site/Views/spin-sys/Home/Parameter.cshtml"
 if (Model.Parameters != null && Model.Parameters.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"content-information\">\n        <h2>");
#nullable restore
#line 11 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Documentation/Site/Views/spin-sys/Home/Parameter.cshtml"
       Write(DocumentationLanguage.Parameters);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n");
#nullable restore
#line 13 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Documentation/Site/Views/spin-sys/Home/Parameter.cshtml"
         foreach (var ItemParameters in Model.Parameters)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row item-content-information\">\n                <div class=\"col\">\n                    ");
#nullable restore
#line 17 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Documentation/Site/Views/spin-sys/Home/Parameter.cshtml"
               Write(ItemParameters.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 17 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Documentation/Site/Views/spin-sys/Home/Parameter.cshtml"
                                      Write(ItemParameters.TypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n\n                <div class=\"col\">\n                    ");
#nullable restore
#line 21 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Documentation/Site/Views/spin-sys/Home/Parameter.cshtml"
               Write(ItemParameters.GetTranslate(a => a.Summary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n\n            </div>\n");
#nullable restore
#line 25 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Documentation/Site/Views/spin-sys/Home/Parameter.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n");
#nullable restore
#line 27 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Documentation/Site/Views/spin-sys/Home/Parameter.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MemberDocument> Html { get; private set; }
    }
}
#pragma warning restore 1591
