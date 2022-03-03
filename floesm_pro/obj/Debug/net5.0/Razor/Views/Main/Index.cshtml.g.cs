#pragma checksum "D:\Application\Web\ASP.NET\MVC\BYAQIB\floesm\floesm_pro\Views\Main\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9690e6908d9bf125cd779732a4ca1871adba54d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Index), @"mvc.1.0.view", @"/Views/Main/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9690e6908d9bf125cd779732a4ca1871adba54d", @"/Views/Main/Index.cshtml")]
    public class Views_Main_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Application\Web\ASP.NET\MVC\BYAQIB\floesm\floesm_pro\Views\Main\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_secondLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



    <div class=""app-main"">
        <div class=""main-header-line"">
            <h1>Floeism Dashboard</h1>
            <div class=""action-buttons"">
                <button class=""open-right-area"">
                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-activity""><polyline points=""22 12 18 12 15 21 9 3 6 12 2 12"" /></svg>
                </button>
                <button class=""menu-button"">
                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-menu""><line x1=""3"" y1=""12"" x2=""21"" y2=""12"" /><line x1=""3"" y1=""6"" x2=""21"" y2=""6"" /><line x1=""3"" y1=""18"" x2=""21"" y2=""18"" /></svg>
                </button>
            </div>
        </div>
        <div class=""chart-row th");
            WriteLiteral(@"ree"">
            <div class=""chart-container-wrapper"">
                <div class=""chart-container"">
                    <div class=""chart-info-wrapper"">
                        <h2>Total Page Visits</h2>
                        <span>20.5 K</span>
                    </div>
                    <div class=""chart-svg"">
                        <svg viewBox=""0 0 36 36"" class=""circular-chart pink"">
                            <path class=""circle-bg"" d=""M18 2.0845
          a 15.9155 15.9155 0 0 1 0 31.831
          a 15.9155 15.9155 0 0 1 0 -31.831""></path>
                            <path class=""circle"" stroke-dasharray=""30, 100"" d=""M18 2.0845
          a 15.9155 15.9155 0 0 1 0 31.831
          a 15.9155 15.9155 0 0 1 0 -31.831""></path>
                            <text x=""18"" y=""20.35"" class=""percentage"">30%</text>
                        </svg>
                    </div>
                </div>
            </div>
            <div class=""chart-container-wrapper"">
                <div clas");
            WriteLiteral(@"s=""chart-container"">
                    <div class=""chart-info-wrapper"">
                        <h2>Total Searches</h2>
                        <span>5.5 K</span>
                    </div>
                    <div class=""chart-svg"">
                        <svg viewBox=""0 0 36 36"" class=""circular-chart blue"">
                            <path class=""circle-bg"" d=""M18 2.0845
          a 15.9155 15.9155 0 0 1 0 31.831
          a 15.9155 15.9155 0 0 1 0 -31.831""></path>
                            <path class=""circle"" stroke-dasharray=""60, 100"" d=""M18 2.0845
          a 15.9155 15.9155 0 0 1 0 31.831
          a 15.9155 15.9155 0 0 1 0 -31.831""></path>
                            <text x=""18"" y=""20.35"" class=""percentage"">60%</text>
                        </svg>
                    </div>
                </div>
            </div>
            <div class=""chart-container-wrapper"">
                <div class=""chart-container"">
                    <div class=""chart-info-wrapper"">
           ");
            WriteLiteral(@"             <h2>New Users</h2>
                        <span>10.5 K</span>
                    </div>
                    <div class=""chart-svg"">
                        <svg viewBox=""0 0 36 36"" class=""circular-chart orange"">
                            <path class=""circle-bg"" d=""M18 2.0845
          a 15.9155 15.9155 0 0 1 0 31.831
          a 15.9155 15.9155 0 0 1 0 -31.831""></path>
                            <path class=""circle"" stroke-dasharray=""90, 100"" d=""M18 2.0845
          a 15.9155 15.9155 0 0 1 0 31.831
          a 15.9155 15.9155 0 0 1 0 -31.831""></path>
                            <text x=""18"" y=""20.35"" class=""percentage"">90%</text>
                        </svg>
                    </div>
                </div>
            </div>
        </div>
        <div class=""chart-row two"">
            <div class=""chart-container-wrapper big"">
                <div class=""chart-container"">
                    <div class=""chart-container-header"">
                        <h2>Yearly Sale");
            WriteLiteral(@"s</h2>
                        <span>Last 30 days</span>
                    </div>
                    <div class=""line-chart"">
                        <canvas id=""chart""></canvas>
                    </div>
                    <div class=""chart-data-details"">
                        <div class=""chart-details-header""></div>
                    </div>
                </div>
            </div>
            <div class=""chart-container-wrapper small"">
                <div class=""chart-container"">
                    <div class=""chart-container-header"">
                        <h2>Acquisitions</h2>
                        <span href=""#"">This month</span>
                    </div>
                    <div class=""acquisitions-bar"">
                        <span class=""bar-progress rejected"" style=""width:8%;""></span>
                        <span class=""bar-progress on-hold"" style=""width:10%;""></span>
                        <span class=""bar-progress shortlisted"" style=""width:18%;""></span>
     ");
            WriteLiteral(@"                   <span class=""bar-progress applications"" style=""width:64%;""></span>
                    </div>
                    <div class=""progress-bar-info"">
                        <span class=""progress-color applications""></span>
                        <span class=""progress-type"">Applications</span>
                        <span class=""progress-amount"">64%</span>
                    </div>
                    <div class=""progress-bar-info"">
                        <span class=""progress-color shortlisted""></span>
                        <span class=""progress-type"">Shortlisted</span>
                        <span class=""progress-amount"">18%</span>
                    </div>
                    <div class=""progress-bar-info"">
                        <span class=""progress-color on-hold""></span>
                        <span class=""progress-type"">On-hold</span>
                        <span class=""progress-amount"">10%</span>
                    </div>
                    <div class=""prog");
            WriteLiteral(@"ress-bar-info"">
                        <span class=""progress-color rejected""></span>
                        <span class=""progress-type"">Rejected</span>
                        <span class=""progress-amount"">8%</span>
                    </div>
                </div>
                <div class=""chart-container applicants"">
                    <div class=""chart-container-header"">
                        <h2>New Applicants</h2>
                        <span>Today</span>
                    </div>
                    <div class=""applicant-line"">
                        <img src=""https://images.unsplash.com/photo-1587628604439-3b9a0aa7a163?ixid=MXwxMjA3fDB8MHxzZWFyY2h8MjB8fHdvbWFufGVufDB8fDB8&ixlib=rb-1.2.1&auto=format&fit=crop&w=900&q=60"" alt=""profile"">
                        <div class=""applicant-info"">
                            <span>Emma Ray</span>
                            <p>Applied for <strong>Product Designer</strong></p>
                        </div>
                    </div>
   ");
            WriteLiteral(@"                 <div class=""applicant-line"">
                        <img src=""https://images.unsplash.com/photo-1583195764036-6dc248ac07d9?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=2555&q=80"" alt=""profile"">
                        <div class=""applicant-info"">
                            <span>Ricky James</span>
                            <p>Applied for <strong>IOS Developer</strong></p>
                        </div>
                    </div>
                    <div class=""applicant-line"">
                        <img src=""https://images.unsplash.com/photo-1450297350677-623de575f31c?ixid=MXwxMjA3fDB8MHxzZWFyY2h8MzV8fHdvbWFufGVufDB8fDB8&ixlib=rb-1.2.1&auto=format&fit=crop&w=900&q=60"" alt=""profile"">
                        <div class=""applicant-info"">
                            <span>Julia Wilson</span>
                            <p>Applied for <strong>UI Developer</strong></p>
                        </div>
                    </div>
        ");
            WriteLiteral(@"            <div class=""applicant-line"">
                        <img src=""https://images.unsplash.com/photo-1596815064285-45ed8a9c0463?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1215&q=80"" alt=""profile"">
                        <div class=""applicant-info"">
                            <span>Jess Watson</span>
                            <p>Applied for <strong>Design Lead</strong></p>
                        </div>
                    </div>
                    <div class=""applicant-line"">
                        <img src=""https://images.unsplash.com/photo-1543965170-4c01a586684e?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=2232&q=80"" alt=""profile"">
                        <div class=""applicant-info"">
                            <span>John Pellegrini</span>
                            <p>Applied for <strong>Back-End Developer</strong></p>
                        </div>
                    </div>
          ");
            WriteLiteral("      </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
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
