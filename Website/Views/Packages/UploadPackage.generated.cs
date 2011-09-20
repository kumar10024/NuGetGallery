﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGetGallery.Views.Packages
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Packages\UploadPackage.cshtml"
    using NuGetGallery;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.2.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Packages/UploadPackage.cshtml")]
    public class UploadPackage : System.Web.Mvc.WebViewPage<SubmitPackageRequest>
    {
        public UploadPackage()
        {
        }
        public override void Execute()
        {



            
            #line 3 "..\..\Views\Packages\UploadPackage.cshtml"
  
    ViewBag.Tab = "Upload";
    Layout = "~/Views/Shared/TwoColumnLayout.cshtml";


            
            #line default
            #line hidden
WriteLiteral("\n");


DefineSection("LeftNav", () => {

WriteLiteral("\n    <img src=\"");


            
            #line 9 "..\..\Views\Packages\UploadPackage.cshtml"
         Write(Links.Content.Images.contribGraphic_png);

            
            #line default
            #line hidden
WriteLiteral("\" alt=\"Contribute\" />\n    <p>Submit your package for others to enjoy.</p>\n");


});

WriteLiteral("    \n\n");


DefineSection("ContentHeader", () => {

WriteLiteral("            \n    <h2>Upload Package</h2>\n    <ul class=\"right\" id=\"sequence\">\n   " +
"     ");


            
            #line 16 "..\..\Views\Packages\UploadPackage.cshtml"
   Write(Html.UploadSequence(1));

            
            #line default
            #line hidden
WriteLiteral("\n    </ul>\n");


});

WriteLiteral("\n\n<div id=\"form\">\n    <div id=\"uploadFileForm\" class=\"selected\">\n        <form id" +
"=\"uploadFileSubmissionForm\" method=\"post\" action=\"");


            
            #line 22 "..\..\Views\Packages\UploadPackage.cshtml"
                                                             Write(Url.Current());

            
            #line default
            #line hidden
WriteLiteral("\" enctype=\"multipart/form-data\">\n            ");


            
            #line 23 "..\..\Views\Packages\UploadPackage.cshtml"
       Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
WriteLiteral("\n            ");


            
            #line 24 "..\..\Views\Packages\UploadPackage.cshtml"
       Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
WriteLiteral(@"
            <aside>
                <p>Your package file will be uploaded and hosted on the gallery server.</p>
            </aside>
            <input type=""file"" id=""PackageFile"" name=""PackageFile"" />
            <div class=""buttons"">
                <input id=""uploadFileButton"" type=""submit"" value=""Upload &raquo;"" singleClickButton=""true"" />
            </div>
        </form>
    </div>
</div>
");


        }
    }
}
#pragma warning restore 1591