#pragma checksum "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/MenuMobileGenerate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e29bf94ef4f8fb34a958f334d85f8d0975f806e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Themes_Shared_spin_sys_Generator_MenuMobileGenerate), @"mvc.1.0.view", @"/Spin/Themes/Shared/spin-sys/Generator/MenuMobileGenerate.cshtml")]
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
#line 2 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/MenuMobileGenerate.cshtml"
using Spin.Modules.Entity.Backend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e29bf94ef4f8fb34a958f334d85f8d0975f806e8", @"/Spin/Themes/Shared/spin-sys/Generator/MenuMobileGenerate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3ca8c78acceb1c9067e6e5253e8e15db21c1ef", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Themes_Shared_spin_sys_Generator_MenuMobileGenerate : Spin.Base.Extend.Page.SpinWebViewPage<Dictionary<string, BackendContent>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/MenuMobileGenerate.cshtml"
  
    string SelectItem = ViewBag.SelectItem;
    var ItemMenuSelected = Model.FirstOrDefault(a => a.Value.NameController == SelectItem);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-5 module-mobile-title\">\n        ");
#nullable restore
#line 11 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/MenuMobileGenerate.cshtml"
    Write((String.IsNullOrEmpty(SpinViewPage.Module.Alias)) ? SpinViewPage.Module.Name : SpinViewPage.Module.Alias);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div id=\"contentMenu\" class=\"col module-mobile-name\">\n        <button class=\"btn-arrow-menu\" type=\"button\" data-toggle=\"collapse\" data-target=\"#collapseMenu\" aria-expanded=\"false\" aria-controls=\"collapseMenu\">\n");
#nullable restore
#line 15 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/MenuMobileGenerate.cshtml"
             if (ItemMenuSelected.Value != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/MenuMobileGenerate.cshtml"
                 if (!String.IsNullOrEmpty(ItemMenuSelected.Value.Logo))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <i");
            BeginWriteAttribute("class", " class=\"", 799, "\"", 837, 1);
#nullable restore
#line 19 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/MenuMobileGenerate.cshtml"
WriteAttributeValue("", 807, ItemMenuSelected.Value.Logo, 807, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\n");
#nullable restore
#line 20 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/MenuMobileGenerate.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/MenuMobileGenerate.cshtml"
           Write(ItemMenuSelected.Value.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/MenuMobileGenerate.cshtml"
                                            
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/MenuMobileGenerate.cshtml"
             if (Model != null && Model.Count > 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <i class=\"fas fa-chevron-down arrow-menu\"></i>\n");
#nullable restore
#line 26 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/MenuMobileGenerate.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </button>\n    </div>\n\n</div>\n");
#nullable restore
#line 31 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/MenuMobileGenerate.cshtml"
 if (Model != null && Model.Count > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"collapse\" id=\"collapseMenu\">\n        <ul class=\"content-menu-back\">\n");
#nullable restore
#line 35 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/MenuMobileGenerate.cshtml"
             foreach (var ItemMenu in Model.Where(a => a.Value.NameController != SelectItem).OrderBy(a => a.Value.Order))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1404, "\"", 1496, 5);
            WriteAttributeValue("", 1411, "/Admin/", 1411, 7, true);
#nullable restore
#line 38 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/MenuMobileGenerate.cshtml"
WriteAttributeValue("", 1418, SpinViewPage.ModuleName, 1418, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1444, "/", 1444, 1, true);
#nullable restore
#line 38 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/MenuMobileGenerate.cshtml"
WriteAttributeValue("", 1445, ItemMenu.Value.GetNameController(), 1445, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1482, "/IndexGenerate", 1482, 14, true);
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 39 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/MenuMobileGenerate.cshtml"
                         if (!String.IsNullOrEmpty(ItemMenu.Value.Logo))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i");
            BeginWriteAttribute("class", " class=\"", 1628, "\"", 1658, 1);
#nullable restore
#line 41 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/MenuMobileGenerate.cshtml"
WriteAttributeValue("", 1636, ItemMenu.Value.Logo, 1636, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\n");
#nullable restore
#line 42 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/MenuMobileGenerate.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
#nullable restore
#line 43 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/MenuMobileGenerate.cshtml"
                   Write(ItemMenu.Value.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </a>\n                </li>\n");
#nullable restore
#line 46 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/MenuMobileGenerate.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\n    </div>\n");
#nullable restore
#line 49 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/MenuMobileGenerate.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<div class=\"row\">\n    <div class=\"col-12\">\n");
#nullable restore
#line 55 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/MenuMobileGenerate.cshtml"
         if (Model != null && Model.Count > 1)
        {

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n\n\n\n");
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<string, BackendContent>> Html { get; private set; }
    }
}
#pragma warning restore 1591
