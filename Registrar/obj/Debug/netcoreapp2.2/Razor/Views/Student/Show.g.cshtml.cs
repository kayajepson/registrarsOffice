#pragma checksum "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Student/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "088aa43e65097b4796de8e86f6dba3b694e49c4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Show), @"mvc.1.0.view", @"/Views/Student/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Show.cshtml", typeof(AspNetCore.Views_Student_Show))]
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
#line 1 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/_ViewImports.cshtml"
using Registrar;

#line default
#line hidden
#line 2 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/_ViewImports.cshtml"
using Registrar.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"088aa43e65097b4796de8e86f6dba3b694e49c4e", @"/Views/Student/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a44cc688012de0ba294c93fee0e08f3652b9b43", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("courseId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 38, true);
            WriteLiteral("<h2>Student Details:</h2>\n<p>Student: ");
            EndContext();
            BeginContext(39, 21, false);
#line 2 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Student/Show.cshtml"
       Write(Model["student"].Name);

#line default
#line hidden
            EndContext();
            BeginContext(60, 25, true);
            WriteLiteral("</p>\n<p>Enrollment Date: ");
            EndContext();
            BeginContext(86, 31, false);
#line 3 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Student/Show.cshtml"
               Write(Model["student"].EnrollmentDate);

#line default
#line hidden
            EndContext();
            BeginContext(117, 6, true);
            WriteLiteral("</p>\n\n");
            EndContext();
#line 5 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Student/Show.cshtml"
 if(Model["studentCourses"].Count != 0)
{

#line default
#line hidden
            BeginContext(165, 7, true);
            WriteLiteral("  <ul>\n");
            EndContext();
#line 8 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Student/Show.cshtml"
     foreach(var course in Model["studentCourses"])
    {

#line default
#line hidden
            BeginContext(230, 10, true);
            WriteLiteral("      <li>");
            EndContext();
            BeginContext(241, 11, false);
#line 10 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Student/Show.cshtml"
     Write(course.Name);

#line default
#line hidden
            EndContext();
            BeginContext(252, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(255, 19, false);
#line 10 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Student/Show.cshtml"
                   Write(course.CourseNumber);

#line default
#line hidden
            EndContext();
            BeginContext(274, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Student/Show.cshtml"
    }

#line default
#line hidden
            BeginContext(286, 8, true);
            WriteLiteral("  </ul>\n");
            EndContext();
#line 13 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Student/Show.cshtml"
}

#line default
#line hidden
            BeginContext(296, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(297, 356, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "088aa43e65097b4796de8e86f6dba3b694e49c4e6367", async() => {
                BeginContext(366, 73, true);
                WriteLiteral("\n  <label for=\"courseId\">Add Course: </label>\n  <select name=\"courseId\">\n");
                EndContext();
#line 18 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Student/Show.cshtml"
     foreach(var course in Model["courses"])
    {

#line default
#line hidden
                BeginContext(490, 6, true);
                WriteLiteral("      ");
                EndContext();
                BeginContext(496, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "088aa43e65097b4796de8e86f6dba3b694e49c4e7100", async() => {
                    BeginContext(541, 19, false);
#line 20 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Student/Show.cshtml"
                                             Write(course.CourseNumber);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 20 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Student/Show.cshtml"
          WriteLiteral(course.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(569, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 21 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Student/Show.cshtml"
    }

#line default
#line hidden
                BeginContext(576, 70, true);
                WriteLiteral("  </select>\n  <button type=\"submit\" name=\"button\">Add Course</button>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 311, "/student/", 311, 9, true);
#line 15 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Student/Show.cshtml"
AddHtmlAttributeValue("", 320, Model["student"].Id, 320, 20, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 340, "/addCourse", 340, 10, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(653, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
