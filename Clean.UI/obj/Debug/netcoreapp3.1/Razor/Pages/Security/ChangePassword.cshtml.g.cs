#pragma checksum "D:\ComplainTracking\MOE\Clean.UI\Pages\Security\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ae26d34b816848ec9d0102c003d284c82f3f223"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Clean.UI.Pages.Security.Pages_Security_ChangePassword), @"mvc.1.0.razor-page", @"/Pages/Security/ChangePassword.cshtml")]
namespace Clean.UI.Pages.Security
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
#line 1 "D:\ComplainTracking\MOE\Clean.UI\Pages\_ViewImports.cshtml"
using Clean.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ComplainTracking\MOE\Clean.UI\Pages\Security\ChangePassword.cshtml"
using System.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{handler?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ae26d34b816848ec9d0102c003d284c82f3f223", @"/Pages/Security/ChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4e588d119d3749322bd1c215836697b37532af0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Security_ChangePassword : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Save", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("save"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("dv_Security_ChangePassword"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form main-form page-component"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("prefix", new global::Microsoft.AspNetCore.Html.HtmlString("cp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\ComplainTracking\MOE\Clean.UI\Pages\Security\ChangePassword.cshtml"
  
    ViewData["Title"] = "تغییر رمز عبور";
    Layout = "~/Pages/Shared/_MasterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "D:\ComplainTracking\MOE\Clean.UI\Pages\Security\ChangePassword.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"panel panel-flat\" >\r\n        <div class=\"panel-heading\">\r\n            <div class=\"panel-title\">\r\n                ");
#nullable restore
#line 13 "D:\ComplainTracking\MOE\Clean.UI\Pages\Security\ChangePassword.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"panel-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ae26d34b816848ec9d0102c003d284c82f3f2237189", async() => {
                WriteLiteral("\r\n                <fieldset class=\"content-group\">\r\n                    <legend class=\"text-bold\">جهت تغییر رمز عبور خویش از این صفحه استفاده نمائید</legend>\r\n                    <input type=\"hidden\" id=\"cpusername\" name=\"cpUserName\"");
                BeginWriteAttribute("value", " value=\"", 788, "\"", 814, 1);
#nullable restore
#line 21 "D:\ComplainTracking\MOE\Clean.UI\Pages\Security\ChangePassword.cshtml"
WriteAttributeValue("", 796, Model.CurrentUser, 796, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    <div class=""row"">
                        <div class=""col-md-offset-4 col-md-4"">
                            <div class=""form-group"">
                                <label class=""text-bold"">
                                    رمز عبور
                                </label>
                                <input type=""password"" id=""cpcurrentpassword"" name=""cpCurrentPassword"" class=""form-control search"" placeholder=""لطفا رمز عبور فعلی خود را تایپ نمائید"" required />
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-offset-4 col-md-4"">
                            <div class=""form-group"">
                                <label class=""text-bold"">
                                    رمز عبور جدید
                                </label>
                                <input type=""password"" id=""cpnewpassword"" name=""cpNewPassword"" class=""form-control");
                WriteLiteral(@" search"" placeholder=""لطفا رمز عبور جدید خود را تایپ نمائید"" required />
                            </div>
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-md-offset-4 col-md-4"">
                            <div class=""form-group"">
                                <label class=""text-bold"">
                                    تائید رمز عبور جدید
                                </label>
                                <input type=""password"" id=""cpnewpasswordconfirmation"" name=""cpNewPasswordConfirmation"" class=""form-control search"" placeholder=""رمز عبور جدید خویش را مجددا تایپ نمائید"" required />
                            </div>
                        </div>
                    </div>
                </fieldset>
                <hr />

                <div class=""row div-form-control main-form-detail"">
                    <div class=""col-md-12"">
                        <div class=""form-group actions"">
");
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ae26d34b816848ec9d0102c003d284c82f3f22310269", async() => {
                    WriteLiteral("<i class=\"icon-floppy-disk position-left\"></i>");
#nullable restore
#line 59 "D:\ComplainTracking\MOE\Clean.UI\Pages\Security\ChangePassword.cshtml"
                                                                                                                                                         Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n");
            DefineSection("PageScripts", async() => {
                WriteLiteral("\r\n\r\n            <script>\r\n\r\n    $(document).ajaxSuccess(function (event, request, settings) {\r\n\r\n        console.log(request.responseJSON.status);\r\n\r\n        if (request.responseJSON.status == 1) {\r\n             window.ApplicationBaseUrl = ");
#nullable restore
#line 76 "D:\ComplainTracking\MOE\Clean.UI\Pages\Security\ChangePassword.cshtml"
                                    Write(Html.Raw(HttpUtility.JavaScriptStringEncode(Url.Content("~/"), true)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n            var timer = setTimeout(function () { window.location = window.ApplicationBaseUrl + \'Security/Logout\' }, 1000);\r\n        }\r\n    });\r\n            </script>\r\n\r\n        ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Clean.UI.Pages.Security.ChangePasswordModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Clean.UI.Pages.Security.ChangePasswordModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Clean.UI.Pages.Security.ChangePasswordModel>)PageContext?.ViewData;
        public Clean.UI.Pages.Security.ChangePasswordModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591