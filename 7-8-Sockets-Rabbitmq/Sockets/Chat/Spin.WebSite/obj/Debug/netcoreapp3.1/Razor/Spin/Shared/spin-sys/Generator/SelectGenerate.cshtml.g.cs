#pragma checksum "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70f3d4b0a569ff3c41e6d5d3c84c8e4fecf6b1fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Shared_spin_sys_Generator_SelectGenerate), @"mvc.1.0.view", @"/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml")]
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
#line 2 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml"
using Spin.Modules.Entity.Backend.Generator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml"
using Spin.Modules.Entity.Backend.Generator.Select;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70f3d4b0a569ff3c41e6d5d3c84c8e4fecf6b1fe", @"/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3ca8c78acceb1c9067e6e5253e8e15db21c1ef", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Shared_spin_sys_Generator_SelectGenerate : Spin.Base.Extend.Page.SpinWebViewPage<SpinWebGeneral>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml"
  
    var SelectTop = ViewBag.SelectTemplatesTop as List<string>;
    var SelectBottom = ViewBag.SelectTemplatesBottom as List<string>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<script type=\"text/ng-template\" id=\"select.htm\">\n\n    <div class=\"row no-gutters content-header\">\n        <div class=\"d-block d-md-none col-12\">\n            ");
#nullable restore
#line 16 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml"
       Write(await Html.SpinRenderActionAsync("MenuMobileGenerate", new { NameController = SpinViewPage.ControllerName }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>

    <!--Content Filter-->
    <div class=""content-select-general"">
        <div class=""row no-gutters justify-content-center content-select"">
            <div class=""col-12 "">

                <div class=""row content-header content-select-filters"">
                    <div class=""col-12 filter-container"">
                        ");
#nullable restore
#line 27 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml"
                   Write(await Html.SpinRenderActionAsync("FilterGenerate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"template-top-select\">\n");
#nullable restore
#line 32 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml"
                     foreach (string Template in SelectTop)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml"
                   Write(await Html.SpinRenderActionAsync(Template));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml"
                                                                   
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>

                <div class=""row content-header content-select-buttons"">
                    <div class=""col-2""></div>
                    <div class=""col-8 float-right"">
                        <div class=""row no-gutters content-pagination"">
                            <div class=""col-md-12 col-lg-12 col-sm-12 col-12"">
                                <!--if use all rows in client-->
                                <dir-pagination-controls ng-if=""useSelectAll"" ng boundary-links=""false"" on-page-change=""pageChangeHandler(newPageNumber)"" template-url=""/template/pagination/dirPagination.tpl.htm""></dir-pagination-controls>
                                <!--else use all rows in client-->
                                <div class=""item-pagination-number"" ng-if=""!useSelectAll"">
                                    ");
#nullable restore
#line 47 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml"
                               Write(await Html.SpinRenderActionAsync("PaginationServer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </div>\n                            </div>\n                        </div>\n                    </div>\n                    <div class=\"col-2 content-button float-right\">\n");
#nullable restore
#line 53 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml"
                         foreach (var ItemButton in Model.GeneralAttribute.Where(a => a is SpinButtonSelect && a.TypeAttribute == "Button" && a.Enabled).Select(a => (SpinButton)a).OrderBy(a => a.Order))
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"content-select-btn-top content-right-select-btn-top\">\n                                ");
#nullable restore
#line 57 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml"
                           Write(ItemButton.Render(this.Context));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </div>\n");
#nullable restore
#line 59 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>

                <div id=""loadingTop"" class=""loader""></div>
                <div class=""row no-gutters row-height select-row-title"">

                    <div class=""col-md-12 col-lg-12 col-12 col-sm-12 col-height text-item-title"">
                        <div class=""row"">
");
#nullable restore
#line 68 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml"
                             foreach (var ItemColumns in Model.WebTypes.Where(a => a.SelectField != null && a.SelectField.Show).OrderBy(a => a.SelectField.Order))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div");
            BeginWriteAttribute("class", " class=\"", 3311, "\"", 3482, 8);
            WriteAttributeValue("", 3319, "col-xl-", 3319, 7, true);
#nullable restore
#line 70 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml"
WriteAttributeValue("", 3326, ItemColumns.SelectField.SizeColumn, 3326, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3363, "col-md-", 3364, 8, true);
#nullable restore
#line 70 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml"
WriteAttributeValue("", 3371, ItemColumns.SelectField.SizeColumn, 3371, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3408, "col-lg-", 3409, 8, true);
#nullable restore
#line 70 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml"
WriteAttributeValue("", 3416, ItemColumns.SelectField.SizeColumn, 3416, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3453, "col-12", 3454, 7, true);
            WriteAttributeValue(" ", 3460, "title-select-generate", 3461, 22, true);
            EndWriteAttribute();
            WriteLiteral(">\n                                    ");
#nullable restore
#line 71 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml"
                                Write((String.IsNullOrEmpty(ItemColumns.SelectField.Title) ? ItemColumns.Name.SplitCamelCase() : ItemColumns.SelectField.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </div>\n");
#nullable restore
#line 73 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>

                    <div class=""col-md-1 col-lg-1 col-12 col-sm-12 col-height text-item icon-delete-item"">

                    </div>
                </div>


                <!--Detail -->

                <input id=""pageSizeInfo"" type=""hidden"" ng-model=""pageSize"">
                <div id=""item{{itemList.id}}"" class=""row no-gutters row-height select-item-row content-item "" dir-paginate="" itemList in entityList | filter:(useSelectAll)?itemListFilter:itemListFilterOther | itemsPerPage: pageSize"" current-page=""currentPage"">

                    <div class=""col-md-12 col-lg-12 col-12 col-sm-12 col-height text-item"">

                        <div class=""row no-gutters"">
");
#nullable restore
#line 91 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml"
                             foreach (var ItemColumns in Model.WebTypes.Where(a => a.SelectField != null && a.SelectField.Show).OrderBy(a => a.SelectField.Order))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div");
            BeginWriteAttribute("class", " class=\"", 4679, "\"", 4856, 9);
            WriteAttributeValue("", 4687, "col-xl-", 4687, 7, true);
#nullable restore
#line 93 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml"
WriteAttributeValue("", 4694, ItemColumns.SelectField.SizeColumn, 4694, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 4731, "col-md-", 4732, 8, true);
#nullable restore
#line 93 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml"
WriteAttributeValue("", 4739, ItemColumns.SelectField.SizeColumn, 4739, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 4776, "col-lg-", 4777, 8, true);
#nullable restore
#line 93 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml"
WriteAttributeValue("", 4784, ItemColumns.SelectField.SizeColumn, 4784, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 4821, "col-10", 4822, 7, true);
            WriteAttributeValue(" ", 4828, "col-sm-10", 4829, 10, true);
            WriteAttributeValue(" ", 4838, "align-self-center", 4839, 18, true);
            EndWriteAttribute();
            WriteLiteral(">\n                                    <a class=\"link-content-item-column\" ng-click=\"changeView(\'detail/\' + itemList.id)\">\n                                        ");
#nullable restore
#line 95 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml"
                                   Write(ItemColumns.SelectField.Render(this.Context));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </a>\n                                </div>\n");
#nullable restore
#line 98 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            <div class=""item-select-arrow"" ng-click=""changeView('detail/' + itemList.id)"">
                                <i class=""fa fa-angle-right"" aria-hidden=""true""></i>
                            </div>


                            <div class=""col align-self-center col-height text-item-button icon-delete-item"" ng-mouseover=""hoverIn(itemList.id)"" ng-mouseleave=""hoverOut(itemList.id)"">
                                <div ng-click=""delete(itemList)"" class=""d-none d-md-block"">
                                    <i class=""far fa-trash-alt"" aria-hidden=""true""></i>
                                </div>

                                <div ng-click=""delete(itemList)"" class=""d-block d-md-none btn-delete"">
                                    <i class=""far fa-trash-alt"" aria-hidden=""true""></i>
                                    DELETE
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

");
            WriteLiteral(@"                <div class=""row no-gutters content-pagination"">
                    <div class=""col-md-12 col-lg-12 col-sm-12 col-12 content-pagination item-back-pagination-number"">
                        <!--if use all rows in client-->
                        <dir-pagination-controls ng-if=""useSelectAll"" ng boundary-links=""false"" on-page-change=""pageChangeHandler(newPageNumber)"" template-url=""/template/pagination/dirPagination.tpl.htm""></dir-pagination-controls>
                        <!--else use all rows in client-->
                        <div class=""item-pagination-number"" ng-if=""!useSelectAll"">
                            ");
#nullable restore
#line 126 "/home/ubuntu20/Documents/dotnet6/7-8-Sockets-Rabbitmq/Sockets/Chat/Spin.WebSite/Spin/Shared/spin-sys/Generator/SelectGenerate.cshtml"
                       Write(await Html.SpinRenderActionAsync("PaginationServer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n\n            </div>\n        </div>\n    </div>\n\n</script>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SpinWebGeneral> Html { get; private set; }
    }
}
#pragma warning restore 1591
