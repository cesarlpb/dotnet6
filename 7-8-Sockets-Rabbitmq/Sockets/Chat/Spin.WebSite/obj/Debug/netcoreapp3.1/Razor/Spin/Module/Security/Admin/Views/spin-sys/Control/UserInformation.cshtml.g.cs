#pragma checksum "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/UserInformation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4206303130fc1aeac713b561bfec7b5e56495949"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Module_Security_Admin_Views_spin_sys_Control_UserInformation), @"mvc.1.0.view", @"/Spin/Module/Security/Admin/Views/spin-sys/Control/UserInformation.cshtml")]
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
#line 2 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/UserInformation.cshtml"
using Spin.Security.Control;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4206303130fc1aeac713b561bfec7b5e56495949", @"/Spin/Module/Security/Admin/Views/spin-sys/Control/UserInformation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3ca8c78acceb1c9067e6e5253e8e15db21c1ef", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Module_Security_Admin_Views_spin_sys_Control_UserInformation : Spin.Base.Extend.Page.SpinWebViewPage<UserInformation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/UserInformation.cshtml"
  
    this.SpinViewPage.AddStyle("/Spin/Module/Security/Resource/spin-sys/css/controls.css");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"content-user-information\">\n    <div class=\"row\">\n        <div class=\"col-1\">\n            <img class=\"content-user-information-image\"");
            BeginWriteAttribute("ng-src", " ng-src=\"", 294, "\"", 331, 3);
            WriteAttributeValue("", 303, "{{", 303, 2, true);
#nullable restore
#line 10 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/UserInformation.cshtml"
WriteAttributeValue("", 305, Model.ModelName, 305, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 323, ".image}}", 323, 8, true);
            EndWriteAttribute();
            WriteLiteral("  err-src=\"/img/noImage.png\" />\n        </div>\n        <div class=\"col-8 user-information-data\">\n            <div>\n                <strong>\n                    {{");
#nullable restore
#line 15 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/UserInformation.cshtml"
                  Write(Model.ModelName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".firstName}} {{");
#nullable restore
#line 15 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/UserInformation.cshtml"
                                                   Write(Model.ModelName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".lastName}}\n                </strong>\n                \n            </div>\n            <div>\n                {{");
#nullable restore
#line 20 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/UserInformation.cshtml"
              Write(Model.ModelName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".userName}}\n            </div>\n        </div>\n    </div>\n    \n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserInformation> Html { get; private set; }
    }
}
#pragma warning restore 1591
