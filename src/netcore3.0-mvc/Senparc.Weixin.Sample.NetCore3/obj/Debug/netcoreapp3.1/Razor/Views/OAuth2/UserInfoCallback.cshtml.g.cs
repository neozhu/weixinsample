#pragma checksum "D:\projects\ATB\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\UserInfoCallback.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c5cc0bc6f42531efc9e57f09be76cd5aab28ba7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OAuth2_UserInfoCallback), @"mvc.1.0.view", @"/Views/OAuth2/UserInfoCallback.cshtml")]
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
#line 1 "D:\projects\ATB\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\_ViewImports.cshtml"
using Senparc.Weixin.Sample.NetCore3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\projects\ATB\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\_ViewImports.cshtml"
using Senparc.Weixin.Sample.NetCore3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c5cc0bc6f42531efc9e57f09be76cd5aab28ba7", @"/Views/OAuth2/UserInfoCallback.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"931ae162f46de7fc281b09500bbe6dbc3f933a4d", @"/Views/_ViewImports.cshtml")]
    public class Views_OAuth2_UserInfoCallback : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Senparc.Weixin.MP.AdvancedAPIs.OAuth.OAuthUserInfo>
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
#line 3 "D:\projects\ATB\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\UserInfoCallback.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c5cc0bc6f42531efc9e57f09be76cd5aab28ba73619", async() => {
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>OAuth2.0授权测试授权成功</title>\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c5cc0bc6f42531efc9e57f09be76cd5aab28ba74681", async() => {
                WriteLiteral("\n    <h2>OAuth2.0授权测试授权成功！</h2>\n");
#nullable restore
#line 14 "D:\projects\ATB\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\UserInfoCallback.cshtml"
     if (ViewData.ContainsKey("ByBase"))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p><strong>您看到的这个页面来自于snsapi_base授权，因为您已关注本微信，所以才能查询到详细用户信息，否则只能进行常规的授权。</strong></p>\n");
#nullable restore
#line 17 "D:\projects\ATB\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\UserInfoCallback.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p><strong>您看到的这个页面来自于snsapi_userinfo授权，可以直接获取到用户详细信息。</strong></p>\n");
#nullable restore
#line 21 "D:\projects\ATB\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\UserInfoCallback.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <p>下面是通过授权得到的您的部分个人信息：</p>\n    <p>openid:");
#nullable restore
#line 23 "D:\projects\ATB\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\UserInfoCallback.cshtml"
         Write(Model.openid);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n    <p>nickname:");
#nullable restore
#line 24 "D:\projects\ATB\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\UserInfoCallback.cshtml"
           Write(Model.nickname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n    <p>country:");
#nullable restore
#line 25 "D:\projects\ATB\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\UserInfoCallback.cshtml"
          Write(Model.country);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n    <p>province:");
#nullable restore
#line 26 "D:\projects\ATB\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\UserInfoCallback.cshtml"
           Write(Model.province);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n    <p>city:");
#nullable restore
#line 27 "D:\projects\ATB\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\UserInfoCallback.cshtml"
       Write(Model.city);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n    <p>sex:");
#nullable restore
#line 28 "D:\projects\ATB\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\UserInfoCallback.cshtml"
      Write(Model.sex);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n");
#nullable restore
#line 29 "D:\projects\ATB\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\UserInfoCallback.cshtml"
     if (Model.unionid != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p>unionid:");
#nullable restore
#line 31 "D:\projects\ATB\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\UserInfoCallback.cshtml"
              Write(Model.unionid);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n");
#nullable restore
#line 32 "D:\projects\ATB\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\UserInfoCallback.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <p>\n        头像：<br />\n        <img");
                BeginWriteAttribute("src", " src=\"", 859, "\"", 882, 1);
#nullable restore
#line 35 "D:\projects\ATB\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\OAuth2\UserInfoCallback.cshtml"
WriteAttributeValue("", 865, Model.headimgurl, 865, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width: 50%\" />（直接调用可能看不到，需要抓取）\n    </p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Senparc.Weixin.MP.AdvancedAPIs.OAuth.OAuthUserInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
