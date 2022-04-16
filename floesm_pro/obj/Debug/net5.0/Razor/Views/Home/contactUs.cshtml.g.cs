#pragma checksum "E:\Web Development\floesm\floesm_pro\Views\Home\contactUs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd8e3ff3c3cac5b80b585b87794403e25572469e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_contactUs), @"mvc.1.0.view", @"/Views/Home/contactUs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd8e3ff3c3cac5b80b585b87794403e25572469e", @"/Views/Home/contactUs.cshtml")]
    public class Views_Home_contactUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Web Development\floesm\floesm_pro\Views\Home\contactUs.cshtml"
  
    ViewData["Title"] = "Contact";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>

    .contact-page {
        min-height: 100vh;
        background: url(https://fadzrinmadu.github.io/hosted-assets/amazing-contact-page-using-html-css/bg.png) no-repeat center;
        background-size: cover;
        display: flex;
        align-items: center;
        justify-content: center;
    }

    .contact-page {
        width: 100%;
        padding: 50px;
        display: flex;
        align-items: flex-start;
        justify-content: center;
        flex-wrap: wrap;
    }

    h2 {
        width: 100%;
        margin-bottom: 80px;
        text-transform: uppercase;
        color: #322;
        font-size: 60px;
    }

    .contact-info, .contact-form {
        flex: 1;
    }

    .item {
        margin-bottom: 24px;
        font-size: 16px;
        color: #322;
    }

    .icon {
        width: 60px;
        height: 60px;
        line-height: 60px;
        background-color: #3494db;
        text-align: center;
        color: #fff;
        border-r");
            WriteLiteral(@"adius: 50%;
        margin-right: 16px;
    }

    .contact-form {
        display: flex;
        flex-wrap: wrap;
        justify-content: space-between;
    }

    .textb {
        width: calc(50% - 10px);
        height: 50px;
        padding: 12px;
        background-color: #222;
        border: none;
        color: #fff;
        margin-bottom: 20px;
    }

    textarea {
        width: 100%;
        min-height: 200px;
        max-height: 400px;
        resize: vertical;
        padding: 12px;
        background-color: #222;
        border: none;
        color: #fff;
        margin-bottom: 20px;
    }

    .btn {
        width: 120px;
        height: 40px;
        margin-left: auto;
        background-color: #3494db;
        border: none;
        color: #fff;
        text-transform: uppercase;
        cursor: pointer;
        border: 2px solid #3494db;
        transition: .3s linear;
    }

        .btn:hover {
            background-color: transparent;
     ");
            WriteLiteral("       color: #3494db;\r\n        }\r\n\r\n    ");
            WriteLiteral(@"@media screen and (max-width: 980px) {
        .contact-page {
            max-width: 800px;
        }

        h2 {
            font-size: 40px;
            margin-bottom: 40px;
        }

        .contact-info, .contact-form {
            flex: 100%;
            margin-bottom: 30px;
        }

        .textb {
            width: 100%;
        }
    }
</style>
<div class=""contact-page"">
    <h2>Get in touch</h2>
    <div class=""contact-info"">
        <div class=""item"">
            <i class=""icon fas fa-home""></i>
            New York, United States
        </div>
        <div class=""item"">
            <i class=""icon fas fa-phone""></i>
            +0 000 0000000
        </div>
        <div class=""item"">
            <i class=""icon fas fa-envelope""></i>
            email@address.com
        </div>
        <div class=""item"">
            <i class=""icon fas fa-clock""></i>
            Mon - Fri 8:00 AM to 6:00 PM
        </div>
    </div>
    <form");
            BeginWriteAttribute("action", " action=\"", 3178, "\"", 3187, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""contact-form"">
        <input type=""text"" class=""textb"" placeholder=""Your Name"">
        <input type=""email"" class=""textb"" placeholder=""Your Email"">
        <textarea placeholder=""Your Message""></textarea>
        <input type=""submit"" class=""btn"" value='Send'>
    </form>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
