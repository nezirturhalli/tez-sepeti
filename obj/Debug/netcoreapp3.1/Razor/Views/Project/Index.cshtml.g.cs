#pragma checksum "C:\Users\nezir\Desktop\Bitirme Projesi - Kopya\TezSepeti\Views\Project\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06122c126a9baf30187de6842da130540193d9af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Index), @"mvc.1.0.view", @"/Views/Project/Index.cshtml")]
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
#line 1 "C:\Users\nezir\Desktop\Bitirme Projesi - Kopya\TezSepeti\Views\_ViewImports.cshtml"
using TezSepeti;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nezir\Desktop\Bitirme Projesi - Kopya\TezSepeti\Views\_ViewImports.cshtml"
using TezSepeti.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06122c126a9baf30187de6842da130540193d9af", @"/Views/Project/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de35d6dd075fcaaa36cdf42406dfa87249abc741", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-material form-horizontal m-t-40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""page-wrapper"">
    <!-- ============================================================== -->
    <!-- Container fluid  -->
    <!-- ============================================================== -->
    <div class=""container-fluid"">
        <!-- ============================================================== -->
        <!-- Bread crumb and right sidebar toggle -->
        <!-- ============================================================== -->
        <div class=""row page-titles"">
            <div class=""col-md-5 align-self-center"">
                <h4 class=""text-themecolor"">Proje Ekle</h4>
            </div>
            <div class=""col-md-7 align-self-center text-right"">
                <div class=""d-flex justify-content-end align-items-center"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""javascript:void(0)"">Proje</a></li>
                        <li class=""breadcrumb-item active"">Tezi Düzenle</li>
                    </o");
            WriteLiteral(@"l>
                    <button type=""button"" class=""btn btn-info d-none d-lg-block m-l-15""><i class=""fa fa-plus-circle""></i> Yeni Proje</button>
                </div>
            </div>
        </div>
        <!-- ============================================================== -->
        <!-- End Bread crumb and right sidebar toggle -->
        <!-- ============================================================== -->
        <!-- ============================================================== -->
        <!-- Start Page Content -->
        <!-- ============================================================== -->
        <div class=""row"">
            <div class=""col-sm-12"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h5 class=""card-title text-uppercase"">TEZ DETAYLARI</h5>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06122c126a9baf30187de6842da130540193d9af6061", async() => {
                WriteLiteral(@"
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label class=""col-md-12"" for=""example-text"">
                                        Course Name</span>
                                    </label>
                                    <div class=""col-md-12"">
                                        <input type=""text"" id=""example-text"" name=""example-text"" class=""form-control text-muted"" placeholder=""Web Development"" value=""Web Development"">
                                    </div>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label class=""col-md-12"" for=""bdate"">
                                        Course Start Date</span>
                                    </label>
                                    <div class=""col-md-12"">
          ");
                WriteLiteral(@"                              <input type=""text"" id=""bdate"" name=""bdate"" class=""form-control mydatepicker text-muted"" placeholder=""11/01/2017"" value=""11/01/2017"">
                                    </div>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label class=""col-md-12"" for=""bdate"">
                                        Course Duration</span>
                                    </label>
                                    <div class=""col-md-12"">
                                        <input type=""text"" id=""bdate"" name=""bdate"" class=""form-control text-muted"" placeholder=""6 Months"" value=""6 Months"">
                                    </div>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <div class=""row"">
       ");
                WriteLiteral(@"                             <label class=""col-md-12"" for=""bdate"">
                                        Course Price</span>
                                    </label>
                                    <div class=""col-md-12"">
                                        <input type=""text"" id=""bdate"" name=""bdate"" class=""form-control text-muted"" placeholder=""$150.00"" value=""$150.00"">
                                    </div>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label class=""col-md-12"" for=""bdate"">
                                        Course Professor</span>
                                    </label>
                                    <div class=""col-md-12"">
                                        <input type=""text"" id=""bdate"" name=""bdate"" class=""form-control text-muted"" placeholder=""Jane Doe"" value=""Jane Doe"">
    ");
                WriteLiteral(@"                                </div>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label class=""col-sm-12"">Profile Image</label>
                                    <div class=""col-sm-12"">
                                        <img class=""img-responsive"" src=""dist/images/big/c2.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 5619, "\"", 5625, 0);
                EndWriteAttribute();
                WriteLiteral(@" style=""max-width:120px;"">
                                    </div>
                                    <div class=""col-sm-12"">
                                        <div class=""fileinput fileinput-new input-group"" data-provides=""fileinput"">
                                            <div class=""form-control"" data-trigger=""fileinput""> <i class=""glyphicon glyphicon-file fileinput-exists""></i> <span class=""fileinput-filename""></span></div> <span class=""input-group-addon btn btn-default btn-file"">
                                                <span class=""fileinput-new"">Select file</span> <span class=""fileinput-exists"">Change</span>
                                                <input type=""file"" name=""..."">
                                            </span> <a href=""#"" class=""input-group-addon btn btn-default fileinput-exists"" data-dismiss=""fileinput"">Remove</a>
                                        </div>
                                    </div>
                                </div>
 ");
                WriteLiteral(@"                           </div>
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label class=""col-sm-12"" for=""dept"">Department</label>
                                    <div class=""col-sm-12"">
                                        <select class=""form-control text-muted"" id=""dept"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06122c126a9baf30187de6842da130540193d9af11766", async() => {
                    WriteLiteral("Select Department");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06122c126a9baf30187de6842da130540193d9af12836", async() => {
                    WriteLiteral("Computer");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06122c126a9baf30187de6842da130540193d9af13984", async() => {
                    WriteLiteral("Mechanical");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06122c126a9baf30187de6842da130540193d9af15047", async() => {
                    WriteLiteral("Electrical");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06122c126a9baf30187de6842da130540193d9af16110", async() => {
                    WriteLiteral("Medical");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06122c126a9baf30187de6842da130540193d9af17170", async() => {
                    WriteLiteral("BCA/MCA");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </select>
                                    </div>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label class=""col-md-12"" for=""position"">
                                        Year</span>
                                    </label>
                                    <div class=""col-md-12"">
                                        <input type=""text"" id=""position"" name=""position"" class=""form-control text-muted"" placeholder=""Third Year"" value=""Third Year"">
                                    </div>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label class=""col-md-12"">Description</label>
                                  ");
                WriteLiteral(@"  <div class=""col-md-12"">
                                        <textarea class=""form-control text-muted"" rows=""3"">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation.</textarea>
                                    </div>
                                </div>
                            </div>
                            <button type=""submit"" class=""btn btn-info waves-effect waves-light m-r-10"">Submit</button>
                            <button type=""submit"" class=""btn btn-dark waves-effect waves-light"">Cancel</button>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <!-- ============================================================== -->
        <!-- End PAge Content -->
        <!-- ============================================================== -->
        <!-- ============================================================== -->
        <!-- Right sidebar -->
        <!-- ============================================================== -->
        <!-- .right-sidebar -->
        <div class=""right-sidebar"">
            <div class=""slimscrollright"">
                <div class=""rpanel-title""> Service Panel <span><i class=""ti-close right-side-toggle""></i></span> </div>
                <div class=""r-panel-body"">
                    <ul id=""themecolors"" class=""m-t-20"">
                        <li><b>With Light sidebar</b></li>
                        <li><a href=""javascript:void(0)"" data-skin=""skin-default"" class=""default-theme"">1</a></li>
                        <li><a ");
            WriteLiteral(@"href=""javascript:void(0)"" data-skin=""skin-green"" class=""green-theme"">2</a></li>
                        <li><a href=""javascript:void(0)"" data-skin=""skin-red"" class=""red-theme"">3</a></li>
                        <li><a href=""javascript:void(0)"" data-skin=""skin-blue"" class=""blue-theme working"">4</a></li>
                        <li><a href=""javascript:void(0)"" data-skin=""skin-purple"" class=""purple-theme"">5</a></li>
                        <li><a href=""javascript:void(0)"" data-skin=""skin-megna"" class=""megna-theme"">6</a></li>
                        <li class=""d-block m-t-30""><b>With Dark sidebar</b></li>
                        <li><a href=""javascript:void(0)"" data-skin=""skin-default-dark"" class=""default-dark-theme "">7</a></li>
                        <li><a href=""javascript:void(0)"" data-skin=""skin-green-dark"" class=""green-dark-theme"">8</a></li>
                        <li><a href=""javascript:void(0)"" data-skin=""skin-red-dark"" class=""red-dark-theme"">9</a></li>
                        <li><a href=""javas");
            WriteLiteral(@"cript:void(0)"" data-skin=""skin-blue-dark"" class=""blue-dark-theme"">10</a></li>
                        <li><a href=""javascript:void(0)"" data-skin=""skin-purple-dark"" class=""purple-dark-theme"">11</a></li>
                        <li><a href=""javascript:void(0)"" data-skin=""skin-megna-dark"" class=""megna-dark-theme "">12</a></li>
                    </ul>
                    <ul class=""m-t-20 chatonline"">
                        <li><b>Chat option</b></li>
                        <li>
                            <a href=""javascript:void(0)""><img src=""../assets/images/users/1.jpg"" alt=""user-img"" class=""img-circle""> <span>Varun Dhavan <small class=""text-success"">online</small></span></a>
                        </li>
                        <li>
                            <a href=""javascript:void(0)""><img src=""../assets/images/users/2.jpg"" alt=""user-img"" class=""img-circle""> <span>Genelia Deshmukh <small class=""text-warning"">Away</small></span></a>
                        </li>
                        <li>");
            WriteLiteral(@"
                            <a href=""javascript:void(0)""><img src=""../assets/images/users/3.jpg"" alt=""user-img"" class=""img-circle""> <span>Ritesh Deshmukh <small class=""text-danger"">Busy</small></span></a>
                        </li>
                        <li>
                            <a href=""javascript:void(0)""><img src=""../assets/images/users/4.jpg"" alt=""user-img"" class=""img-circle""> <span>Arijit Sinh <small class=""text-muted"">Offline</small></span></a>
                        </li>
                        <li>
                            <a href=""javascript:void(0)""><img src=""../assets/images/users/5.jpg"" alt=""user-img"" class=""img-circle""> <span>Govinda Star <small class=""text-success"">online</small></span></a>
                        </li>
                        <li>
                            <a href=""javascript:void(0)""><img src=""../assets/images/users/6.jpg"" alt=""user-img"" class=""img-circle""> <span>John Abraham<small class=""text-success"">online</small></span></a>
                  ");
            WriteLiteral(@"      </li>
                        <li>
                            <a href=""javascript:void(0)""><img src=""../assets/images/users/7.jpg"" alt=""user-img"" class=""img-circle""> <span>Hritik Roshan<small class=""text-success"">online</small></span></a>
                        </li>
                        <li>
                            <a href=""javascript:void(0)""><img src=""../assets/images/users/8.jpg"" alt=""user-img"" class=""img-circle""> <span>Pwandeep rajan <small class=""text-success"">online</small></span></a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <!-- ============================================================== -->
        <!-- End Right sidebar -->
        <!-- ============================================================== -->
    </div>
    <!-- ============================================================== -->
    <!-- End Container fluid  -->
    <!-- =========================================================");
            WriteLiteral("===== -->\r\n</div>");
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
