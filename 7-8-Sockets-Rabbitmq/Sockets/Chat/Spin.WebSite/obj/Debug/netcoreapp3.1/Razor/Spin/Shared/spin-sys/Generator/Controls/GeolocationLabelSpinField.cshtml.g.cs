#pragma checksum "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/Controls/GeolocationLabelSpinField.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43fb420adf4b19565b978d712f8a283a484dd454"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Shared_spin_sys_Generator_Controls_GeolocationLabelSpinField), @"mvc.1.0.view", @"/Spin/Shared/spin-sys/Generator/Controls/GeolocationLabelSpinField.cshtml")]
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
#line 2 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/Controls/GeolocationLabelSpinField.cshtml"
using Spin.Modules.Entity.Backend.Generator.Detail;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43fb420adf4b19565b978d712f8a283a484dd454", @"/Spin/Shared/spin-sys/Generator/Controls/GeolocationLabelSpinField.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3ca8c78acceb1c9067e6e5253e8e15db21c1ef", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Shared_spin_sys_Generator_Controls_GeolocationLabelSpinField : Spin.Base.Extend.Page.SpinWebViewPage<GeolocationSpinFieldDetail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div");
            BeginWriteAttribute("id", " id=\"", 96, "\"", 119, 2);
            WriteAttributeValue("", 101, "label", 101, 5, true);
#nullable restore
#line 6 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/Controls/GeolocationLabelSpinField.cshtml"
WriteAttributeValue("", 106, Model.Name, 106, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n    <div class=\"row\">\n        <div class=\"col\">\n            <div class=\"title-ckeck-language\">\n                <label>\n                    ");
#nullable restore
#line 11 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/Controls/GeolocationLabelSpinField.cshtml"
               Write(Model.Name.SplitCamelCase());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </label>\n                 <div class=\"show-location open-geolocation\">\n                    <i class=\"fas fa-globe\"></i>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GeolocationSpinFieldDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
