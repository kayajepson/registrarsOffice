#pragma checksum "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Major/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37cfa7d7e11972f771ffaca738289f20127430a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Major_Index), @"mvc.1.0.view", @"/Views/Major/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Major/Index.cshtml", typeof(AspNetCore.Views_Major_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37cfa7d7e11972f771ffaca738289f20127430a4", @"/Views/Major/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a44cc688012de0ba294c93fee0e08f3652b9b43", @"/Views/_ViewImports.cshtml")]
    public class Views_Major_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "major", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "new", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 3 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Major/Index.cshtml"
 if (Model.Count != 0)
{

#line default
#line hidden
            BeginContext(51, 8, true);
            WriteLiteral("  <ul>\n\n");
            EndContext();
#line 7 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Major/Index.cshtml"
   foreach(var major in Model)
  {

#line default
#line hidden
            BeginContext(94, 10, true);
            WriteLiteral("    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 104, "\"", 127, 2);
            WriteAttributeValue("", 111, "/major/", 111, 7, true);
#line 9 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Major/Index.cshtml"
WriteAttributeValue("", 118, major.Id, 118, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(128, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(130, 10, false);
#line 9 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Major/Index.cshtml"
                              Write(major.Name);

#line default
#line hidden
            EndContext();
            BeginContext(140, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 10 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Major/Index.cshtml"
  }

#line default
#line hidden
            BeginContext(154, 8, true);
            WriteLiteral("  </ul>\n");
            EndContext();
#line 12 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Major/Index.cshtml"
}

#line default
#line hidden
            BeginContext(164, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(165, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37cfa7d7e11972f771ffaca738289f20127430a45414", async() => {
                BeginContext(208, 15, true);
                WriteLiteral("Add a new major");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(227, 1, true);
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
