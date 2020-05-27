#pragma checksum "D:\projects\ATB\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\AsyncMethods\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1561471cd07926879c07b8f622fff61b1260279f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AsyncMethods_Index), @"mvc.1.0.view", @"/Views/AsyncMethods/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1561471cd07926879c07b8f622fff61b1260279f", @"/Views/AsyncMethods/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"931ae162f46de7fc281b09500bbe6dbc3f933a4d", @"/Views/_ViewImports.cshtml")]
    public class Views_AsyncMethods_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\projects\ATB\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\AsyncMethods\Index.cshtml"
  
    ViewBag.Title = "异步方法测试页面";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("HeaderContent", async() => {
                WriteLiteral(@"
    <style>

        .asyncWapper {
            text-align: center;
            padding: 30px 30px;
        }

            .asyncWapper h1 {
                text-align: center;
                font-size: 30px;
                padding: 30px;
            }

            .asyncWapper p {
                line-height: 200%;
            }

            .asyncWapper table thead {
                font-weight: bold;
            }

            .asyncWapper td {
                padding: 10px;
                line-height: 150%;
            }

            .asyncWapper ol {
                list-style-type: decimal;
                text-align: left;
            }
    </style>
");
            }
            );
            WriteLiteral(@"<div class=""wrapper asyncWapper"">
    <h1>异步方法测试</h1>
    <hr />
    <div class=""asyncWapper_con"">
        <table>
            <thead>
                <tr>
                    <th>方法</th>
                    <th>说明</th>
                    <th>测试方法</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>临时二维码<br />（QrCodeApi.CreateAsync）</td>
                    <td>打开后会显示最新获取的二维码，使用微信扫一扫，会得到随机的场景值</td>
                    <td>");
#nullable restore
#line 56 "D:\projects\ATB\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\AsyncMethods\Index.cshtml"
                   Write(Html.ActionLink("点击测试", "QrCodeTest", null, new { @class = "txtButton" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>
                <tr>
                    <td>模板消息<br />（TemplateApi.SendTemplateMessageAsync）</td>
                    <td>
                        <ol>
                            <li>关注“盛派网络小助手”公众号</li>
                            <li>输入文字“TM”获取您的验证码，并填写到右侧的“验证码”中</li>
                            <li>点击右侧【点击测试】按钮，将会在公众号上收到通过异步接口发送的模板消息</li>
                        </ol>
                    </td>
                    <td>
");
#nullable restore
#line 68 "D:\projects\ATB\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\AsyncMethods\Index.cshtml"
                         using (Html.BeginForm("TemplateMessageTest", "AsyncMethods", FormMethod.Post))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>\n                                验证码：<input type=\"text\" id=\"tm_checkcode\" name=\"checkcode\" />\n                                <input type=\"submit\" value=\"点击测试\" class=\"ui-button\" />\n                            </p>\n");
#nullable restore
#line 74 "D:\projects\ATB\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\AsyncMethods\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\n                </tr>\n            </tbody>\n        </table>\n    </div>\n</div>\n<div class=\"clear\"></div>\n");
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
