#pragma checksum "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Home\QueryDoc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7955f75e9189dc5aa025d163c1067b7af829e02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_QueryDoc), @"mvc.1.0.view", @"/Views/Home/QueryDoc.cshtml")]
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
#line 1 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Home\QueryDoc.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7955f75e9189dc5aa025d163c1067b7af829e02", @"/Views/Home/QueryDoc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"931ae162f46de7fc281b09500bbe6dbc3f933a4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_QueryDoc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Senparc.Weixin.Sample.NetCore3.Models.VD.Home_IndexVD>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/notifications/toastr/toastr.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/notifications/toastr/toastr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery.serializeJSON/jquery.serializejson.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/moment-with-locales.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("queryform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Home\QueryDoc.cshtml"
  
    ViewBag.Title = "";


#line default
#line hidden
#nullable disable
            DefineSection("styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d7955f75e9189dc5aa025d163c1067b7af829e026570", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <style>
        .timeline ul {
            padding: 1em 0 0 2em;
            margin: 0;
            list-style: none;
            position: relative;
        }

            .timeline ul::before {
                content: "" "";
                height: 100%;
                width: 1px;
                background-color: #d9d9d9;
                position: absolute;
                top: 0;
                left: 2.5em;
                z-index: -1;
            }

        .timeline li div {
            display: inline-block;
            margin: 1em 0;
            vertical-align: top;
        }

        .timeline .bullet {
            width: 1em;
            height: 1em;
            box-sizing: border-box;
            border-radius: 50%;
            background: #fff;
            z-index: 1;
            margin-right: 1em;
        }

            .timeline .bullet.pink {
                border: 2px solid #f93b69;
            }

            .timeline .bullet.green {
           ");
                WriteLiteral(@"     border: 2px solid #b0e8e2;
            }

            .timeline .bullet.orange {
                border: 2px solid #eb8b6e;
            }

        .timeline .time {
            width: 30%;
            font-size: 0.75em;
            padding-top: 0.25em;
        }

        .timeline .desc {
            width: 50%;
        }

        .timeline h3 {
            font-size: 0.9em;
            font-weight: 400;
            margin: 0;
        }

        .timeline h4 {
            margin: 0;
            font-size: 0.7em;
            font-weight: 400;
            color: #808080;
        }

        .timeline .people img {
            width: 30px;
            height: 30px;
            border-radius: 50%;
        }

        .credits,
        .video {
            position: absolute;
            bottom: 10px;
            color: #808080;
            font-size: 100%;
            text-decoration: underline;
        }

        .credits {
            left: 10px;
        }

  ");
                WriteLiteral("      .video {\r\n            right: 10px;\r\n        }\r\n    </style>\r\n");
            }
            );
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n        <script src=\"http://res.wx.qq.com/open/js/jweixin-1.6.0.js\"></script>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7955f75e9189dc5aa025d163c1067b7af829e0210149", async() => {
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
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7955f75e9189dc5aa025d163c1067b7af829e0211253", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7955f75e9189dc5aa025d163c1067b7af829e0212357", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        <script>
        const statusarray = { APLY: '提交审核', APRV: '审核通过', APL: '海关提交审核', APR: '海关审核通过' };
        var vehicle_no = localStorage.getItem(""vehicle_no"");
        var vehicle_color = localStorage.getItem(""vehicle_color"");
        var openid = localStorage.getItem(""openid"");
        var token = localStorage.getItem(""token"");

        $('#querybtn').on('click', function () {
            var form = document.getElementById(""queryform"");
            if (form.reportValidity()) {
                var input = $('#queryform').serializeJSON();
                if (input.gno || input.bno ) {
                    console.log(input);
                    query(token, openid, input.gno, input.bno);



                } else {
                    bootbox.alert(
                        {
                            message: ""请输入查询条件"",
                            backdrop: true
                        });
                }
            }
            else {
                //form.classList.a");
                WriteLiteral(@"dd('was-validated');
            }
        });

         function query(token, openid, gpno,bno) {
            var dialog = bootbox.dialog({
                message: '<p class=""text-center mb-0""><i class=""fal fa-spin fa-spinner""></i> 请等待...</p>',
                closeButton: false
            });
            var input = JSON.stringify({ PASSPORT_NO: gpno, RLT_NO: bno });
             var url = `");
#nullable restore
#line 145 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Home\QueryDoc.cshtml"
                   Write(ViewBag.apihost);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/api/passport/getacmpinfoToD?token=${token}&loginMark=${openid}&data=${input}`;
             $.post(url).done(res => {
                 console.log(res);
                 setTimeout(() => {
                     dialog.modal('hide');
                 }, 500)
                 if (res.code == 410) {
                     showinfo('登录过期')
                     localStorage.setItem(""token"", '');
                     window.location.href = '/Home/BindUser';
                 } else if (res.code == 200) {
                     var ic = res.data.passport.head[0].VEHICLE_IC_NO;
                     var veh = res.data.passport.head[0].VEHICLE_NO;
                     var vehcolor = res.data.passport.head[0].VEHICLE_COLOR;
                     var passno = res.data.passport.head[0].PASSPORT_NO;
                     localStorage.setItem(""vehicle_no"", veh);
                     localStorage.setItem(""vehicle_color"", vehcolor);
                     localStorage.setItem(""passport_no"", passno);
                 ");
                WriteLiteral(@"    localStorage.setItem(""ic"", ic);
                     showinfo('获取数据成功');
                     showresult(res.data.passport.head);
                     queryresult = res.data.passport.head;
                 } else {
                     bootbox.alert(res.info);
                     localStorage.setItem(""vehicle_no"", veh);
                     localStorage.setItem(""vehicle_color"", '');
                     localStorage.setItem(""passport_no"", '');
                     localStorage.setItem(""ic"", '');
                     queryresult = [];
                     $('#resultdiv').hide();
                 }
             });
            
            }
            function showresult(items) {
                $('#resultdiv').show();
                $('#queryresult').empty();
                items.forEach(item => {
                    let bind = '';
                    if (item.BIND_TYPECD == '1') {
                        bind = '一车多票';
                    } else if (item.BIND_TYPECD == '2') {
");
                WriteLiteral(@"                        bind = '一车一票';
                    } else {
                        bind = '一票多车';
                    }

                    var html = `<div id=""c_1"" class=""card border shadow-0 mb-g shadow-sm-hover"" data-filter-tags=""oliver kopyov"">
            <div class=""card-body pb-0 px-4 collapse show"">
                <div class=""d-flex align-items-center demo-h-spacing py-2"">
                    <div class=""d-inline-flex align-items-center text-dark"">
                        核放单号:
                    </div>
                    <a href=""javascript:showlog('${item.ETPS_PREENT_NO}')"" class=""text-dark fw-500"">
                        ${item.PASSPORT_NO||'空'}
                    </a>
                </div>
                <div class=""d-flex align-items-center demo-h-spacing py-2"">
                    <div class=""d-inline-flex align-items-center text-dark"">
                        进出标志:
                    </div>
                    <a href=""javascript:void(0);"" class=""text-dark ");
                WriteLiteral(@"fw-500"">
                        ${item.IO_TYPECD == '1' ? '进口' : '出口'}
                    </a>
                </div>
                <div class=""d-flex align-items-center demo-h-spacing py-2"">
                    <div class=""d-inline-flex align-items-center text-dark"">
                        车牌&nbsp;&nbsp;&nbsp;号:
                    </div>
                    <a href=""javascript:void(0);"" class=""text-dark fw-500"">
                        ${item.VEHICLE_NO}
                    </a>
                </div>
                <div class=""d-flex align-items-center demo-h-spacing py-2"">
                    <div class=""d-inline-flex align-items-center text-dark"">
                        绑定类型:
                    </div>
                    <a href=""javascript:showdoc('${item.ETPS_PREENT_NO}');"" class=""text-dark fw-500"">
                        ${bind}
                    </a>
                </div>
                <div class=""d-flex align-items-center demo-h-spacing py-2"">
                    <");
                WriteLiteral(@"div class=""d-inline-flex align-items-center text-dark"">
                       绑定单证数:
                    </div>
                    <a href=""javascript:showdoc('${item.ETPS_PREENT_NO}');"" class=""text-dark fw-500"">
                        ${item.acmp.length}
                    </a>
                </div>
            </div>
        </div>`;
                    $('#queryresult').append(html);
                });
            }
            function showlog(id) {
                console.log(id)
                var head = queryresult.filter(item => item.ETPS_PREENT_NO == id);
                console.log(head)
                $('.timeline ul').empty();
                head[0].wwf.forEach(item => {
                    const html = `<li>
                            <div class=""bullet green""></div>
                            <div class=""time"">${moment(item.OPER_DATE).format('MM-DD HH:mm')}</div>
                            <div class=""desc"">
                                <h3>${statusarray[item");
                WriteLiteral(@".OPER_TYPE] || ''}</h3>
                                <h4>${item.OPER_PERSON || ''}</h4>
                            </div>
                        </li>`;
                    $('.timeline ul').append(html)
                });
                $('#modal1').modal('toggle');
            }
            function showdoc(id) {
                var head = queryresult.filter(item => item.ETPS_PREENT_NO == id);
                $('#PASSPORT_NO').html(`核放单号:${head[0].PASSPORT_NO || '空'}`);
                $('#list').empty();
                head[0].acmp.forEach(item => {
                    const html = `<li class=""list-group-item"">核注清单号: ${item.RLT_NO}</li>`;
                    $('#list').append(html)
                });
                $('#modal2').modal('toggle');
            }
        function showinfo(msg) {
            toastr[""info""](msg)

            toastr.options = {
                ""closeButton"": false,
                ""debug"": false,
                ""newestOnTop"": true,
             ");
                WriteLiteral(@"   ""progressBar"": false,
                ""positionClass"": ""toast-top-center"",
                ""preventDuplicates"": false,
                ""onclick"": null,
                ""showDuration"": 300,
                ""hideDuration"": 100,
                ""timeOut"": 5000,
                ""extendedTimeOut"": 1000,
                ""showEasing"": ""swing"",
                ""hideEasing"": ""linear"",
                ""showMethod"": ""fadeIn"",
                ""hideMethod"": ""fadeOut""
            }
        }
        $('#scanbtn1').on('click', function () {
            console.log('调用微信js sdk')
        });
        $('#scanbtn2').on('click', function () {
            console.log('调用微信js sdk')
        });
        $('#restbtn').on('click', function () {
            var form = document.getElementById(""queryform"");
            form.reset();
            //form.classList.remove('was-validated');
            $('#resultdiv').hide();
        });
        $(() => {
            $('#resultdiv').hide();
        })

       ");
                WriteLiteral(" </script>\r\n\r\n        <script>\r\n        wx.config({\r\n            debug: false, // 开启调试模式,调用的所有api的返回值会在客户端alert出来，若要查看传入的参数，可以在pc端打开，参数信息会通过log打出，仅在pc端时才会打印。\r\n            appId: \'");
#nullable restore
#line 309 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Home\QueryDoc.cshtml"
               Write(ViewBag.AppId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\', // 必填，公众号的唯一标识\r\n            timestamp: \'");
#nullable restore
#line 310 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Home\QueryDoc.cshtml"
                   Write(ViewBag.Timestamp);

#line default
#line hidden
#nullable disable
                WriteLiteral("\', // 必填，生成签名的时间戳\r\n            nonceStr: \'");
#nullable restore
#line 311 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Home\QueryDoc.cshtml"
                  Write(ViewBag.NonceStr);

#line default
#line hidden
#nullable disable
                WriteLiteral("\', // 必填，生成签名的随机串\r\n            signature: \'");
#nullable restore
#line 312 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Home\QueryDoc.cshtml"
                   Write(ViewBag.Signature);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',// 必填，签名
            jsApiList: [
                    'checkJsApi',
                    'onMenuShareTimeline',
                    'onMenuShareAppMessage',
                    'onMenuShareQQ',
                    'onMenuShareWeibo',
                    'hideMenuItems',
                    'showMenuItems',
                    'hideAllNonBaseMenuItem',
                    'showAllNonBaseMenuItem',
                    'translateVoice',
                    'startRecord',
                    'stopRecord',
                    'onRecordEnd',
                    'playVoice',
                    'pauseVoice',
                    'stopVoice',
                    'uploadVoice',
                    'downloadVoice',
                    'chooseImage',
                    'previewImage',
                    'uploadImage',
                    'downloadImage',
                    'getNetworkType',
                    'openLocation',
                    'getLocation',
                    'hideOptio");
                WriteLiteral(@"nMenu',
                    'showOptionMenu',
                    'closeWindow',
                    'scanQRCode',
                    'chooseWXPay',
                    'openProductSpecificView',
                    'addCard',
                    'chooseCard',
                    'openCard'
            ] // 必填，需要使用的JS接口列表，所有JS接口列表见附录2。详见：http://mp.weixin.qq.com/wiki/7/aaa137b55fb2e0456bf8dd9148dd613f.html
        });

        wx.error(function (res) {
            console.log(res);
            alert('验证失败');
        });
        wx.ready(function () {
                var url = '");
#nullable restore
#line 356 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Home\QueryDoc.cshtml"
                       Write(Context.Request.Scheme);

#line default
#line hidden
#nullable disable
                WriteLiteral("://sdk.weixin.senparc.com\';\r\n                var link = url + \'");
#nullable restore
#line 357 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Home\QueryDoc.cshtml"
                              Write(Context.Request.PathAndQuery());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
             var imgUrl = url + '/images/v2/ewm_01.png';
             console.log(url,link,imgUrl)
                //转发到朋友圈
                wx.onMenuShareTimeline({
                    title: 'JSSDK朋友圈转发测试',
                    link: link,
                    imgUrl: imgUrl,
                    success: function () {
                        alert('转发成功！');
                    },
                    cancel: function () {
                        alert('转发失败！');
                    }
                });
                //转发给朋友
                wx.onMenuShareAppMessage({
                    title: 'JSSDK朋友圈转发测试',
                    desc: '转发给朋友',
                    link: link,
                    imgUrl: imgUrl,
                    type: 'link',
                    dataUrl: '',
                    success: function () {
                        alert('转发成功！');
                    },
                    cancel: function () {
                        alert('转发失败！');
                   ");
                WriteLiteral(" }\r\n                });\r\n            });\r\n        </script>\r\n    ");
            }
            );
            WriteLiteral(@"

    <div class=""row"">
        <div class=""col-xl-12"">
            <div id=""c_1"" class=""card border shadow-0 mb-g shadow-sm-hover"" data-filter-tags=""oliver kopyov"">
                <div class=""card-header pr-3 d-flex align-items-center flex-wrap"">
                    <!-- we wrap header title inside a div tag with utility padding -->
                    <div class=""card-title"">单证信息查询</div>
                    <button onclick=""window.history.back()"" class=""btn   btn-light ml-auto waves-effect waves-themed"">
                        返回
                    </button>

                </div>
                <div class=""card-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7955f75e9189dc5aa025d163c1067b7af829e0228273", async() => {
                WriteLiteral(@"
                        <div class=""form-group"">
                            <div class=""input-group"">
                                <input type=""text"" class="" form-control  rounded-0 border-top-0 border-left-0 border-right-0 px-0 bg-transparent"" placeholder=""核放单号"" name=""gno"" id=""gno"">
                                <div class=""input-group-append"">
                                    <button id=""scanbtn1"" class=""btn btn-default btn-icon waves-effect waves-themed"" type=""button"">
                                        <i class=""fal fa-qrcode""></i>
                                    </button>
                                </div>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""input-group"">
                                <input type=""text"" class="" form-control  rounded-0 border-top-0 border-left-0 border-right-0 px-0 bg-transparent"" placeholder=""核注清单号或出入库单号"" name=""bno"" id=""bno"">
      ");
                WriteLiteral(@"                          <div class=""input-group-append"">
                                    <button id=""scanbtn2"" class=""btn btn-default btn-icon waves-effect waves-themed"" type=""button"">
                                        <i class=""fal fa-qrcode""></i>
                                    </button>
                                </div>
                            </div>
                        </div>

                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""card-body border-faded border-left-0 border-right-0 border-bottom-0 d-flex flex-row align-items-center"">
                    <button id=""querybtn"" class=""btn btn-primary ml-auto waves-effect waves-themed"" type=""submit"">查询</button>
                    <button id=""restbtn"" class=""btn btn-light  ml-1 waves-effect waves-themed"" type=""reset"">重置</button>
                </div>


            </div>
        </div>
    </div>
    <div class=""row"" id=""resultdiv"">
        <div class=""col-xl-12"" id=""queryresult"">
             
        </div>
    </div>
    <div id=""modal1"" class=""modal fade default-example-modal-right-sm"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-right modal-sm"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title h4"">物流状态</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-");
            WriteLiteral(@"label=""Close"">
                        <span aria-hidden=""true""><i class=""fal fa-times""></i></span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""timeline"">
                        <ul>

                            <li>
                                <div class=""bullet green""></div>
                                <div class=""time"">9 - 11am</div>
                                <div class=""desc"">
                                    <h3>Finish Home Screen</h3>
                                    <h4>Web App</h4>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">关闭</button>

                </div>
            </div>
        </div>
    </div>

    <div id=""modal2"" class=""moda");
            WriteLiteral(@"l fade default-example-modal-right-sm"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-right modal-sm"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title h4"">单证信息</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true""><i class=""fal fa-times""></i></span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""card border m-auto m-lg-0"">
                        <div class=""card-body"">
                            <h5 class=""card-title"" id=""PASSPORT_NO"">核放单号:</h5>
                        </div>
                        <ul class=""list-group list-group-flush"" id=""list"">
                            <li class=""list-group-item"">核注清单号:</li>
                            <li class=""list-group-item"">核注清单号:</li>
            ");
            WriteLiteral(@"                <li class=""list-group-item"">核注清单号:</li>
                        </ul>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">关闭</button>

                </div>
            </div>
        </div>
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Senparc.Weixin.Sample.NetCore3.Models.VD.Home_IndexVD> Html { get; private set; }
    }
}
#pragma warning restore 1591