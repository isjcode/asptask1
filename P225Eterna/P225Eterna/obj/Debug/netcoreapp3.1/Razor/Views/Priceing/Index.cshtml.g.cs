#pragma checksum "C:\Users\lasau\P225_ASP_01-06-2022_FrontToBack_ManyToMany\P225Eterna\P225Eterna\Views\Priceing\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c231d8b559e907fdbeaac03c71111bafc745fda0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Priceing_Index), @"mvc.1.0.view", @"/Views/Priceing/Index.cshtml")]
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
#line 2 "C:\Users\lasau\P225_ASP_01-06-2022_FrontToBack_ManyToMany\P225Eterna\P225Eterna\Views\_ViewImports.cshtml"
using P225Eterna.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c231d8b559e907fdbeaac03c71111bafc745fda0", @"/Views/Priceing/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ed9ecaa3ee8509b557e93a5cd90b8160f99f126", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Priceing_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Plan>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lasau\P225_ASP_01-06-2022_FrontToBack_ManyToMany\P225Eterna\P225Eterna\Views\Priceing\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<!-- ======= Breadcrumbs ======= -->
<section id=""breadcrumbs"" class=""breadcrumbs"">
    <div class=""container"">

        <ol>
            <li><a href=""index.html"">Home</a></li>
            <li>Pricing</li>
        </ol>
        <h2>Pricing</h2>

    </div>
</section><!-- End Breadcrumbs -->

<!-- ======= Pricing Section ======= -->
<section id=""pricing"" class=""pricing"">
    <div class=""container"">

        <div class=""row no-gutters"">

");
#nullable restore
#line 27 "C:\Users\lasau\P225_ASP_01-06-2022_FrontToBack_ManyToMany\P225Eterna\P225Eterna\Views\Priceing\Index.cshtml"
             foreach (Plan plan in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 603, "\"", 657, 3);
            WriteAttributeValue("", 611, "col-lg-4", 611, 8, true);
            WriteAttributeValue(" ", 619, "box", 620, 4, true);
#nullable restore
#line 29 "C:\Users\lasau\P225_ASP_01-06-2022_FrontToBack_ManyToMany\P225Eterna\P225Eterna\Views\Priceing\Index.cshtml"
WriteAttributeValue(" ", 623, plan.IsFeature ? "featured":"", 624, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h3>");
#nullable restore
#line 30 "C:\Users\lasau\P225_ASP_01-06-2022_FrontToBack_ManyToMany\P225Eterna\P225Eterna\Views\Priceing\Index.cshtml"
                   Write(plan.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <h4>$");
#nullable restore
#line 31 "C:\Users\lasau\P225_ASP_01-06-2022_FrontToBack_ManyToMany\P225Eterna\P225Eterna\Views\Priceing\Index.cshtml"
                    Write(plan.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>per month</span></h4>\r\n                    <ul>\r\n");
#nullable restore
#line 33 "C:\Users\lasau\P225_ASP_01-06-2022_FrontToBack_ManyToMany\P225Eterna\P225Eterna\Views\Priceing\Index.cshtml"
                         for (int i = 0; i < plan.FeatureCount; i++)
                        {
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><i class=\"bx bx-check\"></i> ");
#nullable restore
#line 36 "C:\Users\lasau\P225_ASP_01-06-2022_FrontToBack_ManyToMany\P225Eterna\P225Eterna\Views\Priceing\Index.cshtml"
                                                       Write(plan.PlanFeatures[i].FeatureItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>  \r\n");
#nullable restore
#line 37 "C:\Users\lasau\P225_ASP_01-06-2022_FrontToBack_ManyToMany\P225Eterna\P225Eterna\Views\Priceing\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 39 "C:\Users\lasau\P225_ASP_01-06-2022_FrontToBack_ManyToMany\P225Eterna\P225Eterna\Views\Priceing\Index.cshtml"
                         for (int i = (plan.PlanFeatures.Count - (plan.PlanFeatures.Count - plan.FeatureCount)); i < plan.PlanFeatures.Count; i++ )
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"na\"><i class=\"bx bx-x\"></i> <span> ");
#nullable restore
#line 41 "C:\Users\lasau\P225_ASP_01-06-2022_FrontToBack_ManyToMany\P225Eterna\P225Eterna\Views\Priceing\Index.cshtml"
                                                                     Write(plan.PlanFeatures[i].FeatureItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></li>\r\n");
#nullable restore
#line 42 "C:\Users\lasau\P225_ASP_01-06-2022_FrontToBack_ManyToMany\P225Eterna\P225Eterna\Views\Priceing\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                    <a href=\"#\" class=\"buy-btn\">Buy Now</a>\r\n                </div>\r\n");
#nullable restore
#line 46 "C:\Users\lasau\P225_ASP_01-06-2022_FrontToBack_ManyToMany\P225Eterna\P225Eterna\Views\Priceing\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</section><!-- End Pricing Section -->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Plan>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
