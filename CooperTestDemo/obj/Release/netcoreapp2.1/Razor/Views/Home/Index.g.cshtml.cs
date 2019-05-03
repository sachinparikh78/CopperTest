#pragma checksum "D:\PROJECTS\ASP CORE DEMO\CooperTestDemoSolution\CooperTestDemo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac0957d9571dc186367af47007683ec8b51f9828"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\PROJECTS\ASP CORE DEMO\CooperTestDemoSolution\CooperTestDemo\Views\_ViewImports.cshtml"
using CooperTestDemo;

#line default
#line hidden
#line 2 "D:\PROJECTS\ASP CORE DEMO\CooperTestDemoSolution\CooperTestDemo\Views\_ViewImports.cshtml"
using CooperTestDemo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac0957d9571dc186367af47007683ec8b51f9828", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea599440e5c590d831b32b62a5840d28bfb7c7fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CooperTestDemo.Entities.testEntity>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\PROJECTS\ASP CORE DEMO\CooperTestDemoSolution\CooperTestDemo\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(133, 686, true);
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12"">
            <br />
            <input id=""Button1"" type=""button"" value=""Create New Test"" class=""btn btn-primary "" data-toggle=""modal"" data-target=""#myModal"" />
            <br />
            <br />
        </div>
        
        <div class=""col-md-12"">

            <table class=""table table-bordered table-hover table-responsive"">
                <thead class=""thead-dark"">
                    <tr>
                        <th>Date </th>
                        <th>Number Of Participant </th>
                        <th>Testtype</th>
                    </tr>
                </thead>
");
            EndContext();
#line 26 "D:\PROJECTS\ASP CORE DEMO\CooperTestDemoSolution\CooperTestDemo\Views\Home\Index.cshtml"
                 foreach (var item in Model.lstTests)
                {

#line default
#line hidden
            BeginContext(893, 93, true);
            WriteLiteral("                    <tbody>\r\n                        <tr>\r\n\r\n                            <td>");
            EndContext();
            BeginContext(987, 13, false);
#line 31 "D:\PROJECTS\ASP CORE DEMO\CooperTestDemoSolution\CooperTestDemo\Views\Home\Index.cshtml"
                           Write(item.TestDate);

#line default
#line hidden
            EndContext();
            BeginContext(1000, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1040, 23, false);
#line 32 "D:\PROJECTS\ASP CORE DEMO\CooperTestDemoSolution\CooperTestDemo\Views\Home\Index.cshtml"
                           Write(item.AthleteTests.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1063, 41, true);
            WriteLiteral("</td>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1104, "\"", 1161, 1);
#line 33 "D:\PROJECTS\ASP CORE DEMO\CooperTestDemoSolution\CooperTestDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 1111, Url.Action("athletes","Home", new { id=item.Id }), 1111, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1162, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1164, 9, false);
#line 33 "D:\PROJECTS\ASP CORE DEMO\CooperTestDemoSolution\CooperTestDemo\Views\Home\Index.cshtml"
                                                                                        Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1173, 72, true);
            WriteLiteral("</a></td>\r\n                        </tr>\r\n                    </tbody>\r\n");
            EndContext();
#line 36 "D:\PROJECTS\ASP CORE DEMO\CooperTestDemoSolution\CooperTestDemo\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1264, 227, true);
            WriteLiteral("            </table>\r\n\r\n            <div id=\"myModal\" class=\"modal fade\" role=\"dialog\">\r\n                <div class=\"modal-dialog\">\r\n\r\n                    <!-- Modal content-->\r\n                    <div class=\"modal-content\">\r\n");
            EndContext();
#line 44 "D:\PROJECTS\ASP CORE DEMO\CooperTestDemoSolution\CooperTestDemo\Views\Home\Index.cshtml"
                         using (Html.BeginForm())
                        {

#line default
#line hidden
            BeginContext(1569, 494, true);
            WriteLiteral(@"                            <div class=""modal-header"">
                                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                                <h4 class=""modal-title"">CREATE NEW TEST</h4>
                            </div>
                            <div class=""modal-body"">
                                <div class=""form-group"">
                                    <label for=""Type"">Type:</label>
                                    ");
            EndContext();
            BeginContext(2064, 165, false);
#line 53 "D:\PROJECTS\ASP CORE DEMO\CooperTestDemoSolution\CooperTestDemo\Views\Home\Index.cshtml"
                               Write(Html.DropDownListFor(m=> m.testType, new SelectList(ViewBag.tests, "Value", "Text"), "--- select Test ----", new { @class = "form-control", @required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(2229, 205, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"form-group\">\r\n                                    <label for=\"Date\">Date:</label>\r\n                                    ");
            EndContext();
            BeginContext(2435, 101, false);
#line 57 "D:\PROJECTS\ASP CORE DEMO\CooperTestDemoSolution\CooperTestDemo\Views\Home\Index.cshtml"
                               Write(Html.TextBoxFor(s=>s.testDate, new { @type="date", @class = "form-control", @required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(2536, 178, true);
            WriteLiteral("\r\n                                </div>\r\n                                <button type=\"submit\" class=\"btn btn-default\">CREATE TEST</button>\r\n                            </div>\r\n");
            EndContext();
#line 61 "D:\PROJECTS\ASP CORE DEMO\CooperTestDemoSolution\CooperTestDemo\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2741, 110, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CooperTestDemo.Entities.testEntity> Html { get; private set; }
    }
}
#pragma warning restore 1591