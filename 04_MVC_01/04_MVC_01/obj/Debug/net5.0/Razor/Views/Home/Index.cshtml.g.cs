#pragma checksum "C:\Users\Web ve Mobil Öğle\Desktop\Wissen.ASP\.NetBaslangic\04_MVC_01\04_MVC_01\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a2e2a495b60490817d4da1854f9dcdae11f81e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a2e2a495b60490817d4da1854f9dcdae11f81e2", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Web ve Mobil Öğle\Desktop\Wissen.ASP\.NetBaslangic\04_MVC_01\04_MVC_01\Views\Home\Index.cshtml"
  
    int yas = 15;
    string adSoyad = "Burak Korkmaz";
    string[] linkler = { "Anasayfa", "Hakkımda", "İletişim" };
    string mesaj = "Yaşınız Tutmuyor";

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 14 "C:\Users\Web ve Mobil Öğle\Desktop\Wissen.ASP\.NetBaslangic\04_MVC_01\04_MVC_01\Views\Home\Index.cshtml"
Write(adSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 15 "C:\Users\Web ve Mobil Öğle\Desktop\Wissen.ASP\.NetBaslangic\04_MVC_01\04_MVC_01\Views\Home\Index.cshtml"
  
    if (yas > 20)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>");
#nullable restore
#line 18 "C:\Users\Web ve Mobil Öğle\Desktop\Wissen.ASP\.NetBaslangic\04_MVC_01\04_MVC_01\Views\Home\Index.cshtml"
       Write(adSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 19 "C:\Users\Web ve Mobil Öğle\Desktop\Wissen.ASP\.NetBaslangic\04_MVC_01\04_MVC_01\Views\Home\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>");
#nullable restore
#line 22 "C:\Users\Web ve Mobil Öğle\Desktop\Wissen.ASP\.NetBaslangic\04_MVC_01\04_MVC_01\Views\Home\Index.cshtml"
       Write(mesaj);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 23 "C:\Users\Web ve Mobil Öğle\Desktop\Wissen.ASP\.NetBaslangic\04_MVC_01\04_MVC_01\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Menu Secenekleri</h1>\r\n<ul style=\"list-style-type:none; display:flex\">\r\n");
#nullable restore
#line 27 "C:\Users\Web ve Mobil Öğle\Desktop\Wissen.ASP\.NetBaslangic\04_MVC_01\04_MVC_01\Views\Home\Index.cshtml"
      
        foreach (var link in linkler)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 30 "C:\Users\Web ve Mobil Öğle\Desktop\Wissen.ASP\.NetBaslangic\04_MVC_01\04_MVC_01\Views\Home\Index.cshtml"
           Write(link);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 31 "C:\Users\Web ve Mobil Öğle\Desktop\Wissen.ASP\.NetBaslangic\04_MVC_01\04_MVC_01\Views\Home\Index.cshtml"

        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n");
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