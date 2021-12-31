#pragma checksum "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Chat/Site/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "934cff02d9b375cf65792419450e42eb3175e616"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Module_Chat_Site_Views_Home_Index), @"mvc.1.0.view", @"/Spin/Module/Chat/Site/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"934cff02d9b375cf65792419450e42eb3175e616", @"/Spin/Module/Chat/Site/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3ca8c78acceb1c9067e6e5253e8e15db21c1ef", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Module_Chat_Site_Views_Home_Index : Spin.Base.Extend.Page.SpinWebViewPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Module/Chat/Site/Views/Home/Index.cshtml"
  
    //Add Style
    this.SpinViewPage.AddStyle("/Spin/Module/Chat/Resources/css/home.css");

    //Add Javascript
    this.SpinViewPage.AddJavaScript("/Spin/Module/Chat/Resources/js/jquery.simple.websocket.js");
    this.SpinViewPage.AddJavaScript("/Spin/Module/Chat/Resources/js/index.js");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""chat-content"">
    <div class=""row justify-content-center"">
        <div class=""col-5"">
            <h1>Chat</h1>
            <div>
                <div id=""connect"" class=""disconnect"">
                    <div class=""row"">
                        <div class=""col-2"">
                            <label>Name</label>
                        </div>
                        <div class=""col"">
                            <input id=""userName"" name=""userName"" />
                        </div>
                        <div class=""col-3"">
                            <button id=""btnConnect"">
                                <i class=""fas fa-plug""></i>
                                Connect
                            </button>
                        </div>
                    </div>
                </div>
                <div id=""disconnect"" class=""connect"">
                    <div class=""row"">
                        <div class=""col"">
                            <button id=""btnDisconnect"">
                 ");
            WriteLiteral(@"               <i class=""fas fa-times""></i>
                                Disconnect
                            </button>
                        </div>
                    </div>
                </div>

                <div id=""chat"" class=""connect"">
                    <div id=""chatRecive"">

                    </div>
                    <div class=""row"">
                        <div class=""col-2"">
                            <label>Message</label>
                        </div>
                        <div class=""col"">
                            <input id=""name"" />
                        </div>
                        <div class=""col-2"">
                            <select id=""users"">
                            </select>
                        </div>
                        <div class=""col-3"">
                            <button id=""btnSend"">
                                <i class=""far fa-paper-plane""></i>
                                Send
                            </button>
                 ");
            WriteLiteral("       </div>\n                    </div>\n                </div>\n\n\n            </div>\n        </div>\n    </div>\n</div>\n");
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
