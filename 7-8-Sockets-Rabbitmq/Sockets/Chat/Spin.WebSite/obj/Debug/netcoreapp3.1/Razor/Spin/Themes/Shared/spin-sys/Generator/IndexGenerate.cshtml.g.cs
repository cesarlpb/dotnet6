#pragma checksum "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/IndexGenerate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a109fc0286eaee7620cfe925b1eb415a243dade"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Themes_Shared_spin_sys_Generator_IndexGenerate), @"mvc.1.0.view", @"/Spin/Themes/Shared/spin-sys/Generator/IndexGenerate.cshtml")]
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
#line 1 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/IndexGenerate.cshtml"
using Spin.Modules.API;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a109fc0286eaee7620cfe925b1eb415a243dade", @"/Spin/Themes/Shared/spin-sys/Generator/IndexGenerate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3ca8c78acceb1c9067e6e5253e8e15db21c1ef", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Themes_Shared_spin_sys_Generator_IndexGenerate : Spin.Base.Extend.Page.SpinWebViewPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/IndexGenerate.cshtml"
   
    this.SpinViewPage.AddTryStyle("/css/Generator/GeneratorExtend.css");
    this.SpinViewPage.AddTryStyle("/css/Generator/GeneratorExtend-media.css");
    this.SpinViewPage.AddTryJavaScript($"/Spin/Module/{SpinViewPage.ModuleName}/Resource/js/{SpinViewPage.ControllerName}/ExtendController.js", false, false, 0);  
    this.SpinViewPage.AddTryStyle($"/Spin/Module/{SpinViewPage.ModuleName}/Resource/css/{SpinViewPage.ControllerName}/ExternalStyle.css", false);
    
    //Language
    var Language = LanguageBL.AllowLanguage;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div ng-app=\"SpinApp\" class=\"content-controller\">\n\n    <!--Add by use Angular-->\n    <input type=\"hidden\" name=\"module\" id=\"module\"");
            BeginWriteAttribute("value", " value=\"", 688, "\"", 720, 1);
#nullable restore
#line 14 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/IndexGenerate.cshtml"
WriteAttributeValue("", 696, SpinViewPage.ModuleName, 696, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    <input type=\"hidden\" name=\"controller\" id=\"controller\"");
            BeginWriteAttribute("value", " value=\"", 783, "\"", 819, 1);
#nullable restore
#line 15 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/IndexGenerate.cshtml"
WriteAttributeValue("", 791, SpinViewPage.ControllerName, 791, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    <input type=\"hidden\" name=\"action\" id=\"action\"");
            BeginWriteAttribute("value", " value=\"", 874, "\"", 906, 1);
#nullable restore
#line 16 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/IndexGenerate.cshtml"
WriteAttributeValue("", 882, SpinViewPage.ActionName, 882, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    <input type=\"hidden\" name=\"segment\" id=\"segment\"");
            BeginWriteAttribute("value", " value=\"", 963, "\"", 996, 1);
#nullable restore
#line 17 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/IndexGenerate.cshtml"
WriteAttributeValue("", 971, SpinViewPage.SegmentName, 971, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    <input type=\"hidden\" name=\"TotalCountRows\" id=\"TotalCountRows\"");
            BeginWriteAttribute("value", " value=\"", 1067, "\"", 1098, 1);
#nullable restore
#line 18 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/IndexGenerate.cshtml"
WriteAttributeValue("", 1075, ViewBag.TotalCountRows, 1075, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    <input type=\"hidden\" id=\"isAdmin\" name=\"isAdmin\"");
            BeginWriteAttribute("value", " value=\"", 1155, "\"", 1253, 1);
#nullable restore
#line 19 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/IndexGenerate.cshtml"
WriteAttributeValue("", 1163, ViewBag.Security.User.IdGroup != 1 && ViewBag.Security.User.IdGroup != 5?"false":"true", 1163, 90, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n\n    <!--Select Script Template-->\n\n    ");
#nullable restore
#line 23 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/IndexGenerate.cshtml"
Write(await Html.SpinRenderActionAsync("SelectGenerate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n    <!--Detail Script Template-->\n    ");
#nullable restore
#line 27 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/IndexGenerate.cshtml"
Write(await Html.SpinRenderActionAsync("DetailGenerate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n    <div id=\"viewContent\" class=\"content-view\" ng-view>\n    </div>\n\n\n</div>\n\n");
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
