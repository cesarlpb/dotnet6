#pragma checksum "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a10f5c412733d45e8ddce2ec098eafb5344b227"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Module_Security_Admin_Views_spin_sys_Control_GroupPermissionControl), @"mvc.1.0.view", @"/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml")]
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
#line 1 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml"
using Spin.Modules.API;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml"
using Spin.Base.Generator;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a10f5c412733d45e8ddce2ec098eafb5344b227", @"/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3ca8c78acceb1c9067e6e5253e8e15db21c1ef", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Module_Security_Admin_Views_spin_sys_Control_GroupPermissionControl : Spin.Base.Extend.Page.SpinWebViewPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml"
  
    this.SpinViewPage.AddJavaScript("/Spin/Module/Security/Resource/spin-sys/js/ExtendGroup.js", false, false, 1);
    this.SpinViewPage.AddStyle("/Spin/Module/Security/Resource/spin-sys/css/GroupPermission.css");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""contentPermission"" class=""content-permission"">
    <div class=""row"">
        <div class=""col-2"">
            <button class=""btn-all-selected"" ng-click=""selectAllPermission()"">
                <i class=""fas fa-list-ul""></i>
                Select All
            </button>
        </div>
        <div class=""col-4"">

        </div>

    </div>
");
#nullable restore
#line 20 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml"
     foreach (var ModuleItem in ModuleFactory.Modules)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml"
         if (ModuleItem.Value.BackendContent != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row content-title-module\">\n                <div class=\"col-2\">\n                    <img class=\"logo-module-item\"");
            BeginWriteAttribute("src", " src=\"", 883, "\"", 928, 3);
            WriteAttributeValue("", 889, "/Spin/Module/", 889, 13, true);
#nullable restore
#line 26 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml"
WriteAttributeValue("", 902, ModuleItem.Key, 902, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 919, "/Icon.png", 919, 9, true);
            EndWriteAttribute();
            WriteLiteral(" />\n                    ");
#nullable restore
#line 27 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml"
               Write(ModuleItem.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div class=""col-1 title-check-page"">
                    Show
                </div>
                <div class=""col-1 title-check-page"">
                    Edit
                </div>
                <div class=""col-1 title-check-page"">
                    Show Conf
                </div>
                <div class=""col-1 title-check-page"">
                    Show History
                </div>
            </div>
");
#nullable restore
#line 42 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml"


            foreach (var Item in ModuleItem.Value.BackendContent.OrderBy(a => a.Value.Name))
            {
                string NameContent = ModuleItem.Key + "Admin" + Item.Value.NameController;
                IBackGeneratorController BakendData = System.Activator.CreateInstance(Item.Value.GenerateType) as IBackGeneratorController;

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml"
                 if (Item.Key.Length > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("id", " id=\"", 1853, "\"", 1872, 1);
#nullable restore
#line 51 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml"
WriteAttributeValue("", 1858, NameContent, 1858, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"row content-title-page\">\n                        <div class=\"col-2 title-page\">\n                            <input class=\"module\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2024, "\"", 2056, 1);
#nullable restore
#line 53 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml"
WriteAttributeValue("", 2032, ModuleItem.Value.Name, 2032, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                            <input class=\"controller\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2128, "\"", 2164, 1);
#nullable restore
#line 54 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml"
WriteAttributeValue("", 2136, Item.Value.NameController, 2136, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                            <input class=\"id\" type=\"hidden\" value=\"0\" />\n                            <input class=\"segment\" type=\"hidden\" value=\"Admin\" />\n\n                            <i");
            BeginWriteAttribute("class", " class=\"", 2355, "\"", 2415, 1);
#nullable restore
#line 58 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml"
WriteAttributeValue("", 2363, Item.Value.Logo.Equals("")?"nulo":Item.Value.Logo, 2363, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\n                            ");
#nullable restore
#line 59 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml"
                       Write(Item.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                        <div class=\"col-1 check-page\">\n                            <input type=\"checkbox\" class=\"show-check\"");
            BeginWriteAttribute("ng-click", " ng-click=\"", 2615, "\"", 2656, 3);
            WriteAttributeValue("", 2626, "validateEdit(\'", 2626, 14, true);
#nullable restore
#line 62 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml"
WriteAttributeValue("", 2640, NameContent, 2640, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2654, "\')", 2654, 2, true);
            EndWriteAttribute();
            WriteLiteral(" />\n                        </div>\n                        <div class=\"col-1 check-page \">\n                            <input type=\"checkbox\" class=\"edit-check\"");
            BeginWriteAttribute("ng-click", " ng-click=\"", 2817, "\"", 2858, 3);
            WriteAttributeValue("", 2828, "validateShow(\'", 2828, 14, true);
#nullable restore
#line 65 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml"
WriteAttributeValue("", 2842, NameContent, 2842, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2856, "\')", 2856, 2, true);
            EndWriteAttribute();
            WriteLiteral(" />\n                        </div>\n                        <div class=\"col-1 check-page \">\n                            <input type=\"checkbox\" class=\"configuration-check\"");
            BeginWriteAttribute("ng-click", " ng-click=\"", 3028, "\"", 3078, 3);
            WriteAttributeValue("", 3039, "validateConfiguration(\'", 3039, 23, true);
#nullable restore
#line 68 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml"
WriteAttributeValue("", 3062, NameContent, 3062, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3076, "\')", 3076, 2, true);
            EndWriteAttribute();
            WriteLiteral(" />\n                        </div>\n\n");
#nullable restore
#line 71 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml"
                         if (BakendData.EntityType.GetInterface("IEntityHistory", false) != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-1 check-page text-center\">\n                                <input type=\"checkbox\" class=\"history-check\"");
            BeginWriteAttribute("ng-click", " ng-click=\"", 3386, "\"", 3430, 3);
            WriteAttributeValue("", 3397, "validateHistory(\'", 3397, 17, true);
#nullable restore
#line 74 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml"
WriteAttributeValue("", 3414, NameContent, 3414, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3428, "\')", 3428, 2, true);
            EndWriteAttribute();
            WriteLiteral(" />\n                            </div>\n");
#nullable restore
#line 76 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-1 check-page text-center history-no-check\">\n                                <div>X</div>\n                            </div>\n");
#nullable restore
#line 82 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n");
#nullable restore
#line 85 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml"
                 

            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
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
