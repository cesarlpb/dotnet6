#pragma checksum "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/Controls/AutocompleteSpinFilter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03ac8adb58edbf369e69d307f132f8c2cab0d138"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Shared_spin_sys_Generator_Controls_AutocompleteSpinFilter), @"mvc.1.0.view", @"/Spin/Shared/spin-sys/Generator/Controls/AutocompleteSpinFilter.cshtml")]
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
#line 2 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/Controls/AutocompleteSpinFilter.cshtml"
using Spin.Modules.Entity.Backend.Generator.Select;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03ac8adb58edbf369e69d307f132f8c2cab0d138", @"/Spin/Shared/spin-sys/Generator/Controls/AutocompleteSpinFilter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3ca8c78acceb1c9067e6e5253e8e15db21c1ef", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Shared_spin_sys_Generator_Controls_AutocompleteSpinFilter : Spin.Base.Extend.Page.SpinWebViewPage<AutocompleteSpinFieldSelect>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/Controls/AutocompleteSpinFilter.cshtml"
   
    //https://github.com/ghiden/angucomplete-alt
    //this.SpinViewPage.AddJavaScript("/js/BaseSpinBackAutocomplete.js",false,true,1);
    //this.SpinViewPage.AddStyle("/css/BaseSpinBackAutocomplete.css", false, true, 1);

    string CallBack = (String.IsNullOrEmpty(Model.CallbackMethod)) ? "autocompleteAssign" : Model.CallbackMethod;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!--");
#nullable restore
#line 11 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/Controls/AutocompleteSpinFilter.cshtml"
Write(Model.ModelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\n<div class=\"content-autocomplete\">\n    <angucomplete-alt");
            BeginWriteAttribute("id", " id=\"", 512, "\"", 528, 1);
#nullable restore
#line 13 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/Controls/AutocompleteSpinFilter.cshtml"
WriteAttributeValue("", 517, Model.Name, 517, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", "\n                      placeholder=\"", 529, "\"", 584, 1);
#nullable restore
#line 14 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/Controls/AutocompleteSpinFilter.cshtml"
WriteAttributeValue("", 565, Model.RemarkFilter, 565, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\n                      pause=\"400\"\n                      ata-selected-object-data=\"row\"");
            BeginWriteAttribute("selected-object", "\n                      selected-object=\"", 672, "\"", 721, 1);
#nullable restore
#line 17 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/Controls/AutocompleteSpinFilter.cshtml"
WriteAttributeValue("", 712, CallBack, 712, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("remote-url", "\n                      remote-url=\"", 722, "\"", 767, 1);
#nullable restore
#line 18 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/Controls/AutocompleteSpinFilter.cshtml"
WriteAttributeValue("", 757, Model.URL, 757, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\n                      remote-url-data-field=\"result\"\n                      title-field=\"value\"");
            BeginWriteAttribute("input-class", "\n                      input-class=\"", 863, "\"", 899, 0);
            EndWriteAttribute();
            WriteLiteral(" \n                      text-searching=\"Searching...\"\n                      description-field=\"description\"/>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AutocompleteSpinFieldSelect> Html { get; private set; }
    }
}
#pragma warning restore 1591
