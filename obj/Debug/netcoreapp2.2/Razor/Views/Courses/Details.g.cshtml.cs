#pragma checksum "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37cf0f005ce026f9eb4a694c733fa14cbbfc411e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Details), @"mvc.1.0.view", @"/Views/Courses/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/Details.cshtml", typeof(AspNetCore.Views_Courses_Details))]
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
#line 11 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
using Registrar.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37cf0f005ce026f9eb4a694c733fa14cbbfc411e", @"/Views/Courses/Details.cshtml")]
    public class Views_Courses_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Registrar.Models.Course>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 5 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
  
    ViewBag.Title = "Course Details";
    var photoPath = "~/images/" + (Model.Image ?? "noimage.jpg");

#line default
#line hidden
            BeginContext(137, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(199, 36, true);
            WriteLiteral("\n<h2>Course Details</h2>\n<hr />\n<h3>");
            EndContext();
            BeginContext(236, 40, false);
#line 15 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(276, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(279, 36, false);
#line 15 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(315, 7, true);
            WriteLiteral("</h3>\n\n");
            EndContext();
#line 17 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
 if(@Model.Students.Count == 0)
{

#line default
#line hidden
            BeginContext(356, 51, true);
            WriteLiteral("  <p>This course does not contain any students</p>\n");
            EndContext();
#line 20 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(416, 48, true);
            WriteLiteral("  <h4>Students the course contains:</h4>\n  <ul>\n");
            EndContext();
#line 25 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
   foreach(var join in Model.Students)
  {

#line default
#line hidden
            BeginContext(507, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(516, 17, false);
#line 27 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
   Write(join.Student.Name);

#line default
#line hidden
            EndContext();
            BeginContext(533, 167, true);
            WriteLiteral("</li>\n    <div class=\"row justify-content-center m-3\">\n    <div class=\"col-sm-8\">\n        <div class=\"card\">\n            <div class=\"card-header\">\n                <h1>");
            EndContext();
            BeginContext(701, 10, false);
#line 32 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
               Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(711, 115, true);
            WriteLiteral("</h1>\n            </div>\n\n            <div class=\"card-body text-center\">\n                <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 826, "\"", 842, 1);
#line 36 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
WriteAttributeValue("", 832, photoPath, 832, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(843, 63, true);
            WriteLiteral(" asp-append-version=\"true\" />\n\n                <h4>Course ID : ");
            EndContext();
            BeginContext(907, 14, false);
#line 38 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
                           Write(Model.CourseId);

#line default
#line hidden
            EndContext();
            BeginContext(921, 73, true);
            WriteLiteral("</h4>\n            </div>\n             </div>\n       </div>\n       </div>\n");
            EndContext();
#line 43 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
  }

#line default
#line hidden
            BeginContext(998, 8, true);
            WriteLiteral("  </ul>\n");
            EndContext();
#line 45 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
}

#line default
#line hidden
            BeginContext(1008, 69, true);
            WriteLiteral("\n            <div class=\"card-footer text-center\">\n               <p>");
            EndContext();
            BeginContext(1078, 43, false);
#line 48 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
             Write(Html.ActionLink("Back to courses", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1121, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(1130, 67, false);
#line 49 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
Write(Html.ActionLink("Edit Course", "Edit", new { id = Model.CourseId }));

#line default
#line hidden
            EndContext();
            BeginContext(1197, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(1206, 71, false);
#line 50 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Details.cshtml"
Write(Html.ActionLink("Delete Course", "Delete", new { id = Model.CourseId }));

#line default
#line hidden
            EndContext();
            BeginContext(1277, 37, true);
            WriteLiteral("</p> \n            </div>\n        \n   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Registrar.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
