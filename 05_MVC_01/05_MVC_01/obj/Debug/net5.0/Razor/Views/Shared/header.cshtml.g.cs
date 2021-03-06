#pragma checksum "C:\Users\Web ve Mobil Öğle\Desktop\Wissen.ASP\.NetBaslangic\05_MVC_01\05_MVC_01\Views\Shared\header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f48986edaefaec97633b34c5d67639d33e740cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_header), @"mvc.1.0.view", @"/Views/Shared/header.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f48986edaefaec97633b34c5d67639d33e740cc", @"/Views/Shared/header.cshtml")]
    public class Views_Shared_header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f48986edaefaec97633b34c5d67639d33e740cc2581", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>05-MVC-01</title>
    <style>
        body {
            display: flex;
            flex-direction: column;
            align-items: center;
        }

        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
            font-family: sans-serif;
        }

        header {
            width: 100%;
            display: flex;
            justify-content: center;
        }

        nav {
            width: 80%;
            height: 100px;
            display: flex;
            justify-content: space-between;
            align-items: center;
            background-color: rgb(5, 2, 22);
        }

        .logo {
            padding: 20px;
            font-size: 30px;
            font-weight: bold;
            color: white;
        }

        .menuBox ul {
           ");
                WriteLiteral(@" display: flex;
            list-style: none;
            justify-content: space-between;
        }

            .menuBox ul li {
                display: block;
                width: 150px;
                text-align: center;
                height: 40px;
                line-height: 40px;
                margin: 0px 15px;
                font-weight: bold;
                border-radius: 3px;
                border: 1px solid white;
            }

                .menuBox ul li a {
                    text-decoration: none;
                    color: white;
                    padding:15px;
                }

                .menuBox ul li:hover {
                    cursor: pointer;
                    background-color: orangered;
                }

        section {
            width: 80%;
            padding: 10px;
            border: 1px solid black;
            height: 450px;
        }

        footer {
            display: flex;
            width: 80%;
           ");
                WriteLiteral(" background-color: rgb(5, 2, 22);\r\n            color: white;\r\n            height: 75px;\r\n            justify-content: center;\r\n            align-items: center;\r\n        }\r\n    </style>\r\n");
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
            WriteLiteral(@"

    <header>
        <nav>
            <div class=""logo"">
                <h1>05-MVC-01</h1>
            </div>
            <div class=""menuBox"">
                <ul>
                    <li><a href=""home"">Anasayfa</a></li>
                    <li><a href=""hakkimda"">Hakkımda</a></li>
                    <li><a href=""iletisim"">İletişim</a></li>
                </ul>
            </div>
        </nav>
    </header>
");
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
