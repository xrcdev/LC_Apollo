#pragma checksum "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "789a748d3dedd1898459cd249f0f90778f40b457"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Device_UserCodeConfirmation), @"mvc.1.0.view", @"/Views/Device/UserCodeConfirmation.cshtml")]
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
#line 1 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\_ViewImports.cshtml"
using Zhaoxi.AspNetCore31.AuthenticationCenterIds4;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"789a748d3dedd1898459cd249f0f90778f40b457", @"/Views/Device/UserCodeConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cb194b523069b3429237bcdb36d06ee7c1afb7a", @"/Views/_ViewImports.cshtml")]
    public class Views_Device_UserCodeConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Zhaoxi.AspNetCore31.AuthenticationCenterIds4.Device.DeviceAuthorizationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationSummary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ScopeListItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consent-scopecheck"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Callback", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consent-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"page-header\">\n    <div class=\"row page-header\">\n        <div class=\"col-sm-10\">\n");
#nullable restore
#line 6 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
             if (Model.ClientLogoUrl != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"client-logo\"><img");
            BeginWriteAttribute("src", " src=\"", 286, "\"", 312, 1);
#nullable restore
#line 8 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
WriteAttributeValue("", 292, Model.ClientLogoUrl, 292, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></div>\n");
#nullable restore
#line 9 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1>\n                ");
#nullable restore
#line 11 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
           Write(Model.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <small>is requesting your permission</small>\n            </h1>\n        </div>\n    </div>\n\n");
#nullable restore
#line 17 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
     if (Model.ConfirmUserCode)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col-sm-8\">\n                <p>\n                    Please confirm that the authorization request quotes the code: \"");
#nullable restore
#line 22 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
                                                                               Write(Model.UserCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\".\n                </p>\n            </div>\n        </div>\n");
#nullable restore
#line 26 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"row\">\n        <div class=\"col-sm-8\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "789a748d3dedd1898459cd249f0f90778f40b4578598", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "789a748d3dedd1898459cd249f0f90778f40b4579726", async() => {
                WriteLiteral("\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "789a748d3dedd1898459cd249f0f90778f40b4579998", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 33 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserCode);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
                                                   WriteLiteral(Model.UserCode);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n                <div>Uncheck the permissions you do not wish to grant.</div>\n\n");
#nullable restore
#line 37 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
                 if (Model.IdentityScopes.Any())
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""panel panel-default consent-buttons"">
                        <div class=""panel-heading"">
                            <span class=""glyphicon glyphicon-user""></span>
                            Personal Information
                        </div>
                        <ul class=""list-group"">
");
#nullable restore
#line 45 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
                             foreach (var scope in Model.IdentityScopes)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "789a748d3dedd1898459cd249f0f90778f40b45713784", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 47 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = scope;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 48 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </ul>\n                    </div>\n");
#nullable restore
#line 51 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
#nullable restore
#line 53 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
                 if (Model.ResourceScopes.Any())
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""panel panel-default"">
                        <div class=""panel-heading"">
                            <span class=""glyphicon glyphicon-tasks""></span>
                            Application Access
                        </div>
                        <ul class=""list-group"">
");
#nullable restore
#line 61 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
                             foreach (var scope in Model.ResourceScopes)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "789a748d3dedd1898459cd249f0f90778f40b45717296", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 63 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = scope;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 64 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </ul>\n                    </div>\n");
#nullable restore
#line 67 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
#nullable restore
#line 69 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
                 if (Model.AllowRememberConsent)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"consent-remember\">\n                        <label>\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "789a748d3dedd1898459cd249f0f90778f40b45720181", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 73 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RememberConsent);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            <strong>Remember My Decision</strong>\n                        </label>\n                    </div>\n");
#nullable restore
#line 77 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                <div class=\"consent-buttons\">\n                    <button name=\"button\" value=\"yes\" class=\"btn btn-primary\" autofocus>Yes, Allow</button>\n                    <button name=\"button\" value=\"no\" class=\"btn\">No, Do Not Allow</button>\n");
#nullable restore
#line 82 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
                     if (Model.ClientUrl != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a class=\"pull-right btn btn-default\" target=\"_blank\"");
                BeginWriteAttribute("href", " href=\"", 3229, "\"", 3252, 1);
#nullable restore
#line 84 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
WriteAttributeValue("", 3236, Model.ClientUrl, 3236, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                            <span class=\"glyphicon glyphicon-info-sign\"></span>\n                            <strong>");
#nullable restore
#line 86 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
                               Write(Model.ClientName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\n                        </a>\n");
#nullable restore
#line 88 "D:\zhaoxi\Architect\20200918Architect01Course075Apollo\Zhaoxi.Microservice.AdvancedDemo\Zhaoxi.AspNetCore31.AuthenticationCenterIds4\Views\Device\UserCodeConfirmation.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Zhaoxi.AspNetCore31.AuthenticationCenterIds4.Device.DeviceAuthorizationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
