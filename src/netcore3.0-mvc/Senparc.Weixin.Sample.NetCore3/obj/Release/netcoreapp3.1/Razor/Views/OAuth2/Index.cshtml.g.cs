#pragma checksum "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbd095674575dae47f38df305bf21f95b5c0e4ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OAuth2_Index), @"mvc.1.0.view", @"/Views/OAuth2/Index.cshtml")]
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
#line 1 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\_ViewImports.cshtml"
using Senparc.Weixin.Sample.NetCore3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\_ViewImports.cshtml"
using Senparc.Weixin.Sample.NetCore3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbd095674575dae47f38df305bf21f95b5c0e4ad", @"/Views/OAuth2/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"931ae162f46de7fc281b09500bbe6dbc3f933a4d", @"/Views/_ViewImports.cshtml")]
    public class Views_OAuth2_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbd095674575dae47f38df305bf21f95b5c0e4ad4852", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\" />\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>OAuth2.0授权测试</title>\n    <style>\n        .green {\n            color: green;\n        }\n    </style>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbd095674575dae47f38df305bf21f95b5c0e4ad5323", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbd095674575dae47f38df305bf21f95b5c0e4ad6420", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbd095674575dae47f38df305bf21f95b5c0e4ad7517", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbd095674575dae47f38df305bf21f95b5c0e4ad9316", async() => {
                WriteLiteral("\n\n    <h2>OAuth2.0授权测试</h2>\n    <p>注意：此页面仅供测试，测试号随时可能过期。请将此DEMO部署到您自己的服务器上，并使用自己的appid和secret。</p>\n    <p>\n        当前returnUrl：\n");
#nullable restore
#line 27 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\Index.cshtml"
         if (ViewData["returnUrl"] == null || ViewData["returnUrl"] as string == "")
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <span>
                <strong>不带returnUrl</strong>。
            </span><br />
            <span class=""green"">使用不带returnUrl的页面会停留在Callback页面，此页面如果刷新（或后退到此页面），会导致code过期的错误，只建议在测试阶段使用。</span>
            <br />
            <span>
                测试带returnUrl");
#nullable restore
#line 35 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\Index.cshtml"
                        Write(Html.ActionLink("点击这里", "Index", new { returnUrl = Url.Action("TestReturnUrl") }));

#line default
#line hidden
#nullable disable
                WriteLiteral("。\n            </span>\n");
#nullable restore
#line 37 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <span><strong>");
#nullable restore
#line 40 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\Index.cshtml"
                     Write(ViewData["returnUrl"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>。</span><br />\n            <span class=\"green\">携带returnUrl后，页面最终会跳转到returnUrl对应页面，避免刷新页面导致code的错误。</span>\n");
#nullable restore
#line 42 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </p>\n    <p><a");
                BeginWriteAttribute("href", " href=\"", 1335, "\"", 1366, 1);
#nullable restore
#line 44 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\Index.cshtml"
WriteAttributeValue("", 1342, ViewData["UrlUserInfo"], 1342, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">点击这里测试snsapi_userinfo</a></p>\n    <p>\n        将要链接到的地址：<br />\n        <textarea rows=\"10\" cols=\"40\">");
#nullable restore
#line 47 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\Index.cshtml"
                                 Write(ViewData["UrlUserInfo"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\n    </p>\n    <p><a");
                BeginWriteAttribute("href", " href=\"", 1522, "\"", 1549, 1);
#nullable restore
#line 49 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\Index.cshtml"
WriteAttributeValue("", 1529, ViewData["UrlBase"], 1529, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">点击这里测试snsapi_base</a></p>\n    <p>\n        将要链接到的地址：<br />\n        <textarea rows=\"10\" cols=\"40\">");
#nullable restore
#line 52 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\Index.cshtml"
                                 Write(ViewData["UrlBase"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\n    </p>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
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
