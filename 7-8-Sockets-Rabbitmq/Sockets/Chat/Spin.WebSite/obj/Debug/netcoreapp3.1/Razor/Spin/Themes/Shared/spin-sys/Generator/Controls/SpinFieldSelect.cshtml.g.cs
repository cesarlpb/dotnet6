#pragma checksum "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/SpinFieldSelect.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef77298da47d9297a9e51a664ee74b658c82ab22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Themes_Shared_spin_sys_Generator_Controls_SpinFieldSelect), @"mvc.1.0.view", @"/Spin/Themes/Shared/spin-sys/Generator/Controls/SpinFieldSelect.cshtml")]
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
#line 2 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/SpinFieldSelect.cshtml"
using Spin.Modules.Entity.Backend.Generator.Select;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/SpinFieldSelect.cshtml"
using Spin.Modules.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef77298da47d9297a9e51a664ee74b658c82ab22", @"/Spin/Themes/Shared/spin-sys/Generator/Controls/SpinFieldSelect.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3ca8c78acceb1c9067e6e5253e8e15db21c1ef", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Themes_Shared_spin_sys_Generator_Controls_SpinFieldSelect : Spin.Base.Extend.Page.SpinWebViewPage<SpinFieldSelect>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 8 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/SpinFieldSelect.cshtml"
 if (Model.InputType == Spin.Modules.Entity.Backend.Generator.Select.InputType.Calendar)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\'text\'");
            BeginWriteAttribute("id", " id=\"", 222, "\"", 241, 1);
#nullable restore
#line 10 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/SpinFieldSelect.cshtml"
WriteAttributeValue("", 227, Model.Name , 227, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ui-date=\"dateOptions\"");
            BeginWriteAttribute("ng-model", " ng-model=\'", 264, "\'", 313, 1);
#nullable restore
#line 10 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/SpinFieldSelect.cshtml"
WriteAttributeValue("", 275, Model.Name.FirstCharacterToLower() , 275, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("ng-focus", " ng-focus=\"", 314, "\"", 381, 3);
            WriteAttributeValue("", 325, "selectedInput(\'#", 325, 16, true);
#nullable restore
#line 10 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/SpinFieldSelect.cshtml"
WriteAttributeValue("", 341, Model.Name.FirstCharacterToLower() , 341, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 379, "\')", 379, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("ng-blur", " ng-blur=\"", 382, "\"", 448, 3);
            WriteAttributeValue("", 392, "selectedInput(\'#", 392, 16, true);
#nullable restore
#line 10 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/SpinFieldSelect.cshtml"
WriteAttributeValue("", 408, Model.Name.FirstCharacterToLower() , 408, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 446, "\')", 446, 2, true);
            EndWriteAttribute();
            WriteLiteral(" />\n");
#nullable restore
#line 11 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/SpinFieldSelect.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\'text\'");
            BeginWriteAttribute("id", " id=\"", 484, "\"", 503, 1);
#nullable restore
#line 14 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/SpinFieldSelect.cshtml"
WriteAttributeValue("", 489, Model.Name , 489, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("ng-model", " ng-model=\'", 504, "\'", 552, 1);
#nullable restore
#line 14 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/SpinFieldSelect.cshtml"
WriteAttributeValue("", 515, Model.Name.FirstCharacterToLower(), 515, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("ng-focus", " ng-focus=\"", 553, "\"", 620, 3);
            WriteAttributeValue("", 564, "selectedInput(\'#", 564, 16, true);
#nullable restore
#line 14 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/SpinFieldSelect.cshtml"
WriteAttributeValue("", 580, Model.Name.FirstCharacterToLower() , 580, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 618, "\')", 618, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("ng-blur", " ng-blur=\"", 621, "\"", 687, 3);
            WriteAttributeValue("", 631, "selectedInput(\'#", 631, 16, true);
#nullable restore
#line 14 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/SpinFieldSelect.cshtml"
WriteAttributeValue("", 647, Model.Name.FirstCharacterToLower() , 647, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 685, "\')", 685, 2, true);
            EndWriteAttribute();
            WriteLiteral(" />\n");
#nullable restore
#line 15 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Themes/Shared/spin-sys/Generator/Controls/SpinFieldSelect.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SpinFieldSelect> Html { get; private set; }
    }
}
#pragma warning restore 1591
