#pragma checksum "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/TranslateLabelSpinField.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b8b472a2352655f59debfd9c57cb0d3bba79760"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Themes_Shared_spin_sys_Generator_Controls_TranslateLabelSpinField), @"mvc.1.0.view", @"/Spin/Themes/Shared/spin-sys/Generator/Controls/TranslateLabelSpinField.cshtml")]
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
#line 2 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/TranslateLabelSpinField.cshtml"
using Spin.Modules.Entity.Backend.Generator.Detail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/TranslateLabelSpinField.cshtml"
using Spin.Modules.API;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b8b472a2352655f59debfd9c57cb0d3bba79760", @"/Spin/Themes/Shared/spin-sys/Generator/Controls/TranslateLabelSpinField.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3ca8c78acceb1c9067e6e5253e8e15db21c1ef", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Themes_Shared_spin_sys_Generator_Controls_TranslateLabelSpinField : Spin.Base.Extend.Page.SpinWebViewPage<TranslateSpinFieldDetail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/TranslateLabelSpinField.cshtml"
  
    var Language = LanguageBL.AllowLanguage.Where(a => a != "en");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"title-ckeck-language\">\n    ");
#nullable restore
#line 9 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/TranslateLabelSpinField.cshtml"
Write(Model.Name.SplitCamelCase());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n<div class=\"content-ckeck-language\">\n");
#nullable restore
#line 12 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/TranslateLabelSpinField.cshtml"
       int IndexLanguage = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/TranslateLabelSpinField.cshtml"
     foreach (string ItemLanguage in Language)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"item-ckeck-language\"");
            BeginWriteAttribute("ng-click", " ng-click=\"", 418, "\"", 465, 3);
            WriteAttributeValue("", 429, "showOrhideTranslate(\'", 429, 21, true);
#nullable restore
#line 15 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/TranslateLabelSpinField.cshtml"
WriteAttributeValue("", 450, Model.Name, 450, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 463, "\')", 463, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("ng-class", " ng-class=\"", 466, "\"", 724, 14);
            WriteAttributeValue("", 477, "{\'item-ckeck-language-created\':", 477, 31, true);
#nullable restore
#line 15 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/TranslateLabelSpinField.cshtml"
WriteAttributeValue("", 508, Model.VariableParentName, 508, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 535, ".spinTranslates[", 535, 16, true);
#nullable restore
#line 15 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/TranslateLabelSpinField.cshtml"
WriteAttributeValue("", 551, IndexLanguage, 551, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 567, "].", 567, 2, true);
#nullable restore
#line 15 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/TranslateLabelSpinField.cshtml"
WriteAttributeValue("", 569, Model.Name.FirstCharacterToLower(), 569, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 606, "!=\'\'", 606, 4, true);
            WriteAttributeValue(" ", 610, "&&", 611, 3, true);
#nullable restore
#line 15 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/TranslateLabelSpinField.cshtml"
WriteAttributeValue(" ", 613, Model.VariableParentName, 614, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 641, ".spinTranslates[", 641, 16, true);
#nullable restore
#line 15 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/TranslateLabelSpinField.cshtml"
WriteAttributeValue("", 657, IndexLanguage, 657, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 673, "].", 673, 2, true);
#nullable restore
#line 15 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/TranslateLabelSpinField.cshtml"
WriteAttributeValue("", 675, Model.Name.FirstCharacterToLower(), 675, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 712, "!=undefined}", 712, 12, true);
            EndWriteAttribute();
            WriteLiteral(">\n            ");
#nullable restore
#line 16 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/TranslateLabelSpinField.cshtml"
       Write(ItemLanguage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n");
#nullable restore
#line 18 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/TranslateLabelSpinField.cshtml"
        IndexLanguage++;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div");
            BeginWriteAttribute("id", " id=\"", 810, "\"", 840, 2);
            WriteAttributeValue("", 815, "btnTranslate", 815, 12, true);
#nullable restore
#line 21 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/TranslateLabelSpinField.cshtml"
WriteAttributeValue("", 827, Model.Name, 827, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-translate\">\n    <i class=\"fas fa-language\"></i>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TranslateSpinFieldDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
