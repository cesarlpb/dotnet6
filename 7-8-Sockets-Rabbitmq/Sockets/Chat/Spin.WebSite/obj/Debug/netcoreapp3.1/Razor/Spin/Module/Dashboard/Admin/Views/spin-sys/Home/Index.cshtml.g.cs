#pragma checksum "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Dashboard/Admin/Views/spin-sys/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "516a7fdb54529ae5bab34bbd4a1e060aa7c53a45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Module_Dashboard_Admin_Views_spin_sys_Home_Index), @"mvc.1.0.view", @"/Spin/Module/Dashboard/Admin/Views/spin-sys/Home/Index.cshtml")]
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
#line 2 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Dashboard/Admin/Views/spin-sys/Home/Index.cshtml"
using Spin.Modules.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"516a7fdb54529ae5bab34bbd4a1e060aa7c53a45", @"/Spin/Module/Dashboard/Admin/Views/spin-sys/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3ca8c78acceb1c9067e6e5253e8e15db21c1ef", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Module_Dashboard_Admin_Views_spin_sys_Home_Index : Spin.Base.Extend.Page.SpinWebViewPage<IEnumerable<Module>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Dashboard/Admin/Views/spin-sys/Home/Index.cshtml"
  
    SpinViewPage.AddStyle("/Spin/Module/Dashboard/Resource/spin-sys/css/Dashboard-home.css");
    SpinViewPage.AddStyle("/Spin/Module/Dashboard/Resource/spin-sys/css/Dashboard-home-media.css");


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row align-items-center content-module module-dashboard\"");
            BeginWriteAttribute("style", " style=\'", 321, "\'", 413, 3);
            WriteAttributeValue("", 329, "background-image:url(", 329, 21, true);
#nullable restore
#line 8 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Dashboard/Admin/Views/spin-sys/Home/Index.cshtml"
WriteAttributeValue("", 350, SpinViewPage.RelativePath("backend/background-backend.jpg"), 350, 62, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 412, ")", 412, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n    <div class=\"col-12 content-dashboard\">\n");
#nullable restore
#line 10 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Dashboard/Admin/Views/spin-sys/Home/Index.cshtml"
         foreach (var ModuleData in Model)
    {
        string Path = (String.IsNullOrEmpty(ModuleData.InitPath)) ? $"/Admin/{ModuleData.Name}/Home/IndexGenerate" : ModuleData.InitPath;


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"item-module\">\n\n            <a");
            BeginWriteAttribute("href", " href=\"", 696, "\"", 708, 1);
#nullable restore
#line 16 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Dashboard/Admin/Views/spin-sys/Home/Index.cshtml"
WriteAttributeValue("", 703, Path, 703, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <div class=\"content-img-item-module\">\n                    <img class=\"img-item-module\"");
            BeginWriteAttribute("src", " src=\"", 813, "\"", 859, 3);
            WriteAttributeValue("", 819, "/Spin/Module/", 819, 13, true);
#nullable restore
#line 18 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Dashboard/Admin/Views/spin-sys/Home/Index.cshtml"
WriteAttributeValue("", 832, ModuleData.Name, 832, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 850, "/Icon.png", 850, 9, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 860, "\"", 882, 1);
#nullable restore
#line 18 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Dashboard/Admin/Views/spin-sys/Home/Index.cshtml"
WriteAttributeValue("", 866, ModuleData.Name, 866, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                </div>\n                <div class=\"text-item-module\">\n                    ");
#nullable restore
#line 21 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Dashboard/Admin/Views/spin-sys/Home/Index.cshtml"
                Write((String.IsNullOrEmpty(ModuleData.Alias)) ? ModuleData.Name : ModuleData.Alias);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n                <div class=\"select-item-menu\">\n                    <img");
            BeginWriteAttribute("src", " src=\'", 1152, "\'", 1203, 1);
#nullable restore
#line 24 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Dashboard/Admin/Views/spin-sys/Home/Index.cshtml"
WriteAttributeValue("", 1158, SpinViewPage.RelativePath("select-menu.png"), 1158, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                </div>\n            </a>\n        </div>\n        <div class=\"division-dashboard\">\n            <img");
            BeginWriteAttribute("src", " src=\'", 1320, "\'", 1378, 1);
#nullable restore
#line 29 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Dashboard/Admin/Views/spin-sys/Home/Index.cshtml"
WriteAttributeValue("", 1326, SpinViewPage.RelativePath("division-dashboard.png"), 1326, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n        </div>\n");
#nullable restore
#line 31 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Dashboard/Admin/Views/spin-sys/Home/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n<div class=\"footer-login\">\n    <div class=\"row\">\n        <div class=\"col\"></div>\n        <div class=\"col-12\">\n            <img");
            BeginWriteAttribute("src", " src=\'", 1544, "\'", 1616, 1);
#nullable restore
#line 38 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Dashboard/Admin/Views/spin-sys/Home/Index.cshtml"
WriteAttributeValue("", 1550, SpinViewPage.RelativePath("/backend/logo-footer-information.png"), 1550, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"icon-logo-information\" />\n            ");
#nullable restore
#line 39 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Dashboard/Admin/Views/spin-sys/Home/Index.cshtml"
       Write(CompanyFactory.Information.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" VS ");
#nullable restore
#line 39 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Dashboard/Admin/Views/spin-sys/Home/Index.cshtml"
                                           Write(CompanyFactory.Information.Version);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 39 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Dashboard/Admin/Views/spin-sys/Home/Index.cshtml"
                                                                                 Write(CompanyFactory.Information.TypeVersion);

#line default
#line hidden
#nullable disable
            WriteLiteral(") | ?? ");
#nullable restore
#line 39 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Dashboard/Admin/Views/spin-sys/Home/Index.cshtml"
                                                                                                                               Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 39 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Dashboard/Admin/Views/spin-sys/Home/Index.cshtml"
                                                                                                                                                  Write(CompanyFactory.Information.Copyright);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"col\"></div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Module>> Html { get; private set; }
    }
}
#pragma warning restore 1591
