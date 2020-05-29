#pragma checksum "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Cache\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa5413da8d0d24d2612d1e3f3df92678e3d168e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cache_Test), @"mvc.1.0.view", @"/Views/Cache/Test.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa5413da8d0d24d2612d1e3f3df92678e3d168e5", @"/Views/Cache/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"931ae162f46de7fc281b09500bbe6dbc3f933a4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Cache_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Cache\Test.cshtml"
  
    ViewBag.Title = "微信分布式缓存策略测试";
    Layout = "~/Views/Shared/_Layout.cshtml";

//DPBMARK_FILE Redis
//DPBMARK_FILE Memcached

#line default
#line hidden
#nullable disable
            DefineSection("HeaderContent", async() => {
                WriteLiteral(@"
    <style>
        .wrapper h2 {
            text-align: center;
            font-size: 30px;
            padding: 30px;
        }

        .result {
            padding: 0px 0px 0px 30px;
            font-size: 110%;
            float: right;
            width: 55%;
        }

            .result h1 {
                margin: 30px;
                font-weight: bold;
                font-size: 120%;
            }

        #resultText {
            border: 1px solid #66cdaa;
            padding: 10px;
        }

        .description {
            float: left;
            width: 45%;
            padding: 40px 0;
        }

            .description h1 {
                font-weight: bold;
                font-size: 120%;
                padding-bottom: 30px;
            }

            .description ol, .description li {
                list-style: decimal;
            }

            .description ol {
                padding-left: 25px;
            }

            .desc");
                WriteLiteral(@"ription li {
                line-height: 200%;
                font-size: 120%;
            }

        #cacheNote a {
            color: darkcyan;
            text-decoration-line: underline;
        }

        p#testCacheType{padding:8px; text-align:center;}
        p#testCacheType a{text-decoration:underline;}

        .currentTestCache{font-weight:bold;}
    </style>
    <script>
        $(function() {
            runTest(");
#nullable restore
#line 72 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Cache\Test.cshtml"
               Write(ViewData["id"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(");\r\n        });\r\n\r\n        function runTest(id) {\r\n            id = id || 0;\r\n            $(\'#cacheTest_\' + id).addClass(\'currentTestCache\').siblings().removeClass(\'currentTestCache\');\r\n            $(\'#resultText\').html(\'缓存测试运行中……\');\r\n            $.post(\'");
#nullable restore
#line 79 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Cache\Test.cshtml"
               Write(Url.Action("RunTest"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\', {id:id}, function(html) {\r\n                $(\'#resultText\').html(html);\r\n            });\r\n        }\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"<div class=""wrapper"">
    <h2>缓存测试</h2>
    <div class=""description"" id=""cacheNote"">
        <h1>CO2NET.Cache 及 Weixin.Cache 缓存测试过程</h1>
        <p>
            <ol>
                <li>使用分布式缓存及本地缓存进行多重全面测试；</li>
                <li>交换使用缓存策略及 ContainerCache（<a href=""https://v.qq.com/x/page/a0917lmkono.html"" target=""_blank"">领域缓存</a>）进行测试，以全面测试 CO2NET.Cache 和 Weixin.Cache 的可用性以及性能；</li>
                <li>进行写入测试，不设置缓存过期时间，并检测结果；</li>
                <li>使用 ContainerCache（<a href=""https://v.qq.com/x/page/a0917lmkono.html"" target=""_blank"">领域缓存</a>）进行写入测试，并设置缓存过期时间，通过底层缓存策略及 ContainerCache（<a href=""https://v.qq.com/x/page/a0917lmkono.html"" target=""_blank"">领域缓存</a>）分别获取同一个缓存对象，检测其一致性；</li>
                <li>进行自动等待后，检查过期缓存数据是否已被自动清除；</li>
                <li>进行删除测试，对新写入的数据进行删除，并检查结果。</li>
            </ol>
        </p>
    </div>
    <div class=""result"">
        <h1>测试结果：</h1>
        <p id=""testCacheType"">
            <a href=""javascript:void(0)"" onclick=""runTest('')"" id=""cacheTest_0"">本地缓存</a> ");
            WriteLiteral("|\r\n");
            WriteLiteral("            <a href=\"javascript:void(0)\" onclick=\"runTest(\'1\')\" id=\"cacheTest_1\">StackExchange.Redis</a> [<a href=\"http://nuget.org/packages/Senparc.Weixin.Cache.Redis\" target=\"_blank\">nuget</a>] |\r\n");
            WriteLiteral("            <a href=\"javascript:void(0)\" onclick=\"runTest(\'2\')\" id=\"cacheTest_2\">CsRedis</a> [<a href=\"http://nuget.org/packages/Senparc.Weixin.Cache.CsRedis\" target=\"_blank\">nuget</a>] |\r\n");
            WriteLiteral("            <a href=\"javascript:void(0)\" onclick=\"runTest(\'-1\')\" id=\"cacheTest_-1\">当前系统</a>\r\n        </p>\r\n        <p id=\"resultText\"></p>\r\n    </div>\r\n</div>\r\n<div class=\"clear\"></div>\r\n");
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
