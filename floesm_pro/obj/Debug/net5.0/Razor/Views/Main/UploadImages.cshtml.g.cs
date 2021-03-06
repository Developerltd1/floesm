#pragma checksum "E:\Web Development\floesm\floesm_pro\Views\Main\UploadImages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2abcff261366982d7d1fef607a095ed5bc808df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_UploadImages), @"mvc.1.0.view", @"/Views/Main/UploadImages.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2abcff261366982d7d1fef607a095ed5bc808df", @"/Views/Main/UploadImages.cshtml")]
    public class Views_Main_UploadImages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<floesm_pro.Model.UploadedImages>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Web Development\floesm\floesm_pro\Views\Main\UploadImages.cshtml"
  
    ViewData["Title"] = "Upload Images";
    Layout = "~/Pages/Shared/_secondLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <button class=""btn btn-info m-2 openPopup"">Add Image</button>

    <div style=""background-color:#fff"">
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">uploaded Image</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 19 "E:\Web Development\floesm\floesm_pro\Views\Main\UploadImages.cshtml"
                 if (Model != null && Model.Count()>0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\Web Development\floesm\floesm_pro\Views\Main\UploadImages.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 24 "E:\Web Development\floesm\floesm_pro\Views\Main\UploadImages.cshtml"
                                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 25 "E:\Web Development\floesm\floesm_pro\Views\Main\UploadImages.cshtml"
                           Write(item.ImageUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 27 "E:\Web Development\floesm\floesm_pro\Views\Main\UploadImages.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "E:\Web Development\floesm\floesm_pro\Views\Main\UploadImages.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr><td>No record found</td></tr>\r\n");
#nullable restore
#line 32 "E:\Web Development\floesm\floesm_pro\Views\Main\UploadImages.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>


<!-- Modal -->
<div class=""modal fade"" id=""UploadImageModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Upload Images</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""content-modal"">

            </div>

        </div>
    </div>
</div>

<script>
    $("".openPopup"").click(function (e) {

        $.ajax({
            url: ""/main/GetUploadImagePopup"",
            type: 'GET',
            success: function (res) {
                $('.content-modal').html(res);
                $('#UploadImageModal').modal('show');
            }");
            WriteLiteral(@"
        });
    });

    function show(input) {
        if (input.files && input.files[0]) {
            var filerdr = new FileReader();
            filerdr.onload = function (e) {
                $('#user_img').attr('src', e.target.result);
            }
            filerdr.readAsDataURL(input.files[0]);
        }
    }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<floesm_pro.Model.UploadedImages>> Html { get; private set; }
    }
}
#pragma warning restore 1591
