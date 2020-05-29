#pragma checksum "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OpenOAuth\OpenOAuthCallback.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebbcb2272cb2fafb0981f9df9a9993258b77b7ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OpenOAuth_OpenOAuthCallback), @"mvc.1.0.view", @"/Views/OpenOAuth/OpenOAuthCallback.cshtml")]
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
#nullable restore
#line 1 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OpenOAuth\OpenOAuthCallback.cshtml"
using Senparc.Weixin.Open.ComponentAPIs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebbcb2272cb2fafb0981f9df9a9993258b77b7ed", @"/Views/OpenOAuth/OpenOAuthCallback.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"931ae162f46de7fc281b09500bbe6dbc3f933a4d", @"/Views/_ViewImports.cshtml")]
    public class Views_OpenOAuth_OpenOAuthCallback : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OpenOAuth\OpenOAuthCallback.cshtml"
  
    Layout = null;

    var authInfo = ViewData["QueryAuthorizationInfo"] as AuthorizationInfo;
    var autherInfo = ViewData["GetAuthorizerInfoResult"] as AuthorizerInfo;

    if (autherInfo == null)
    {
        throw new Exception("SS");
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebbcb2272cb2fafb0981f9df9a9993258b77b7ed4093", async() => {
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>成功授权</title>\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebbcb2272cb2fafb0981f9df9a9993258b77b7ed5143", async() => {
                WriteLiteral("\n    <h1>账号已成功授权</h1>\n    <section>\n        <h2>授权信息</h2>\n        <p>authorizer_access_token：");
#nullable restore
#line 24 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OpenOAuth\OpenOAuthCallback.cshtml"
                              Write(authInfo.authorizer_access_token);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n        <p>authorizer_appid：");
#nullable restore
#line 25 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OpenOAuth\OpenOAuthCallback.cshtml"
                       Write(authInfo.authorizer_appid);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n        <p>authorizer_refresh_token：");
#nullable restore
#line 26 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OpenOAuth\OpenOAuthCallback.cshtml"
                               Write(authInfo.authorizer_refresh_token);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n        <p>expires_in：");
#nullable restore
#line 27 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OpenOAuth\OpenOAuthCallback.cshtml"
                 Write(authInfo.expires_in);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n        <p>\n            func_info：<br />\n");
#nullable restore
#line 30 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OpenOAuth\OpenOAuthCallback.cshtml"
             if (authInfo.func_info != null)
            {
                foreach (var item in authInfo.func_info)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <span>&nbsp; &nbsp; ");
#nullable restore
#line 34 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OpenOAuth\OpenOAuthCallback.cshtml"
                                    Write(item.funcscope_category != null ? item.funcscope_category.id.ToString() : "空（异常情况）");

#line default
#line hidden
#nullable disable
                WriteLiteral("</span><br />\n");
#nullable restore
#line 35 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OpenOAuth\OpenOAuthCallback.cshtml"
                }
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <span>空（异常情况）</span>\n");
#nullable restore
#line 40 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OpenOAuth\OpenOAuthCallback.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </p>\n    </section>\n    <section>\n        <h2>授权公众号信息</h2>\n        <p>\n            <img");
                BeginWriteAttribute("src", " src=\"", 1280, "\"", 1306, 1);
#nullable restore
#line 46 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OpenOAuth\OpenOAuthCallback.cshtml"
WriteAttributeValue("", 1286, autherInfo.head_img, 1286, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width: 100px;\" />\n            <img");
                BeginWriteAttribute("src", " src=\"", 1349, "\"", 1377, 1);
#nullable restore
#line 47 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OpenOAuth\OpenOAuthCallback.cshtml"
WriteAttributeValue("", 1355, autherInfo.qrcode_url, 1355, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width: 100px;\" />\n        </p>\n        <p>alias：");
#nullable restore
#line 49 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OpenOAuth\OpenOAuthCallback.cshtml"
            Write(autherInfo.alias);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n        <p>nick_name：");
#nullable restore
#line 50 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OpenOAuth\OpenOAuthCallback.cshtml"
                Write(autherInfo.nick_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n        <p>user_name：");
#nullable restore
#line 51 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OpenOAuth\OpenOAuthCallback.cshtml"
                Write(autherInfo.user_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n        <p>service_type_info：");
#nullable restore
#line 52 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OpenOAuth\OpenOAuthCallback.cshtml"
                        Write(autherInfo.service_type_info.id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n        <p>verify_type_info：");
#nullable restore
#line 53 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OpenOAuth\OpenOAuthCallback.cshtml"
                       Write(autherInfo.verify_type_info.id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n        <h2>授权信息</h2>\n        <p>appid：");
#nullable restore
#line 55 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OpenOAuth\OpenOAuthCallback.cshtml"
            Write(authInfo.authorizer_appid);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n    </section>\n    <section>\n        <h2>查看授权缓存信息</h2>\n        <p>\n            ");
#nullable restore
#line 60 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OpenOAuth\OpenOAuthCallback.cshtml"
       Write(Html.ActionLink("点击查看", "GetAuthorizerInfoResult", "OpenOAuth", new { authorizerId = authInfo.authorizer_appid }, new { target = "_blank" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\n        </p>\n        <p>\n            ");
#nullable restore
#line 63 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OpenOAuth\OpenOAuthCallback.cshtml"
       Write(Html.ActionLink("刷新AuthorizerAccessToken", "RefreshAuthorizerAccessToken", "OpenOAuth", new { authorizerId = authInfo.authorizer_appid }, new { target = "_blank" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\n        </p>\n    </section>\n    <section>\n        <h2>用户授权测试</h2>\n        <p>\n\n            ");
#nullable restore
#line 70 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OpenOAuth\OpenOAuthCallback.cshtml"
       Write(Html.ActionLink("点击开始用户授权测试", "Index", "OpenOAuth", new { appId = authInfo.authorizer_appid }, null));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\n            注意：测试之前请先确认您的公众号有OAuth的权限，否则可能会返回错误：Scope 参数错误或没有 Scope 权限。\n        </p>\n    </section>\n\n");
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
