#pragma checksum "C:\Users\CINAR\Desktop\Projects\NetCoreIOC\NetCoreIOC.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f79281c2f77f8ca7439f7f55e2494a1e503b8025"
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
#nullable restore
#line 1 "C:\Users\CINAR\Desktop\Projects\NetCoreIOC\NetCoreIOC.Web\Views\_ViewImports.cshtml"
using NetCoreIOC.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CINAR\Desktop\Projects\NetCoreIOC\NetCoreIOC.Web\Views\_ViewImports.cshtml"
using NetCoreIOC.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f79281c2f77f8ca7439f7f55e2494a1e503b8025", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab4a87deb684f7f8c5a3af297da76b0d5b82d93c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DateTimeViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\CINAR\Desktop\Projects\NetCoreIOC\NetCoreIOC.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Constructor Injection Singleton DateTime: ");
#nullable restore
#line 8 "C:\Users\CINAR\Desktop\Projects\NetCoreIOC\NetCoreIOC.Web\Views\Home\Index.cshtml"
                                            Write(Model[0].DateTimeNow.TimeOfDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Constructor Injection Scoped DateTime: ");
#nullable restore
#line 9 "C:\Users\CINAR\Desktop\Projects\NetCoreIOC\NetCoreIOC.Web\Views\Home\Index.cshtml"
                                         Write(Model[1].DateTimeNow.TimeOfDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Constructor Injection Transient DateTime: ");
#nullable restore
#line 10 "C:\Users\CINAR\Desktop\Projects\NetCoreIOC\NetCoreIOC.Web\Views\Home\Index.cshtml"
                                            Write(Model[2].DateTimeNow.TimeOfDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>MethodInjection Transient DateTime: ");
#nullable restore
#line 11 "C:\Users\CINAR\Desktop\Projects\NetCoreIOC\NetCoreIOC.Web\Views\Home\Index.cshtml"
                                      Write(Model[3].DateTimeNow.TimeOfDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DateTimeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
