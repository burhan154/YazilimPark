#pragma checksum "C:\Users\yazilim.park5\source\repos\AppYP\AppYP\Views\BMI\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d137f7dbebd4931034f29284e46d5488b8676d42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BMI_Index), @"mvc.1.0.view", @"/Views/BMI/Index.cshtml")]
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
#line 1 "C:\Users\yazilim.park5\source\repos\AppYP\AppYP\Views\_ViewImports.cshtml"
using AppYP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yazilim.park5\source\repos\AppYP\AppYP\Views\_ViewImports.cshtml"
using Entity.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d137f7dbebd4931034f29284e46d5488b8676d42", @"/Views/BMI/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b6b9cc67d89162ae5d1ff53d3b41274f794e2c", @"/Views/_ViewImports.cshtml")]
    public class Views_BMI_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entity.Concrete.BMIModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""py-5"">
    <div class=""container"">

        <div class=""row"">
            <div class=""col-lg-6 mx-auto"">
                <header class=""text-center pb-5"">
                    <h1 class=""h2"">BMI Calculator</h1>
                </header>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-lg-6 mx-auto"">
                <blockquote class=""blockquote blockquote-custom bg-white p-5 shadow rounded"">
                    <div class=""form-group"">
                        ");
#nullable restore
#line 17 "C:\Users\yazilim.park5\source\repos\AppYP\AppYP\Views\BMI\Index.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Height));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                        ");
#nullable restore
#line 18 "C:\Users\yazilim.park5\source\repos\AppYP\AppYP\Views\BMI\Index.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"row justify-content-around\">\r\n                            <div class=\"col-3\">\r\n                                ");
#nullable restore
#line 21 "C:\Users\yazilim.park5\source\repos\AppYP\AppYP\Views\BMI\Index.cshtml"
                           Write(Html.DisplayNameFor(a => a.Height));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-9\">\r\n                                ");
#nullable restore
#line 24 "C:\Users\yazilim.park5\source\repos\AppYP\AppYP\Views\BMI\Index.cshtml"
                           Write(Html.TextBoxFor(a => a.Height, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>

                    </div>
                    <div class=""form-group"">
                        <div class=""row justify-content-around"">
                            <div class=""col-3"">
                                ");
#nullable restore
#line 32 "C:\Users\yazilim.park5\source\repos\AppYP\AppYP\Views\BMI\Index.cshtml"
                           Write(Html.DisplayNameFor(a => a.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-9\">\r\n                                ");
#nullable restore
#line 35 "C:\Users\yazilim.park5\source\repos\AppYP\AppYP\Views\BMI\Index.cshtml"
                           Write(Html.TextBoxFor(a => a.Weight, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>

                    <footer class=""pt-4 mt-4 border-top"">
                        <cite id=""author"" title=""Source Title"">Your BMI :<strong id=""result""></strong></cite><br>
                        <cite id=""author"" title=""Source Title"">BMI Result :<strong id=""message""></strong></cite>
                        <div class=""float-right"">
                            <button type=""submit"" id=""submit"" value=""Submit"" class=""btn btn-primary"">Calculate</button>
                            <button type=""reset"" id=""reset"" class=""btn btn-danger"">Reset</button>
                        </div>
                    </footer>
                    <footer class=""pt-4 mt-4 border-top"">
                        <div class=""row justify-content-around"">
                            <div class=""card text-white bg-dark col-2"" id=""under"">
                                <h6>< 18 under weight</h6> 
                            </di");
            WriteLiteral(@"v>
                            <div class=""card text-white bg-dark col-2"" id=""normal"">
                                <h6>18.5 - 25 Normal</h6>
                            </div>
                            <div class=""card text-white bg-dark col-2"" id=""over"">
                                <h6>25 - 30 Over Weight</h6>
                            </div>
                            <div class=""card text-white bg-dark col-2"" id=""obese"">
                                <h6>> 30 Obese</h6>
                            </div>
                        </div>
                    </footer>
                </blockquote>
            </div>
        </div>
    </div>
</section>

    <script type=""text/javascript"">
        $(""#submit"").click(function () {
            $(""#obese, #over"").removeClass(""bg-danger"").addClass('bg-dark');
            $(""#normal,#under"").removeClass(""bg-success"").addClass('bg-dark');
            $.ajax({
                type: ""POST"",
                url: ""/BMI/GetBMI"",
   ");
            WriteLiteral(@"             data: {
                    'Weight': $(""#Weight"").val(),
                    'Height': $(""#Height"").val()
                },
                cache: false,
                success: function (data) {
                    $(""#result"").html(data.result);
                    $(""#message"").html(data.message);

                    if (data.result > 30)
                        $('#obese').removeClass('bg-dark').addClass('bg-danger');
                    else if (data.result > 25)
                        $(""#over"").removeClass('bg-dark').addClass(""bg-danger"");
                    else if (data.result > 18.5)
                        $(""#normal"").removeClass('bg-dark').addClass(""bg-success"");
                    else if(data.result > 0)
                        $(""#under"").removeClass('bg-dark').addClass(""bg-success"");

                }
            });
        });
        $(""#reset"").click(function () {
            $(""#Weight"").val('');
            $(""#Height"").val('');
        });
");
            WriteLiteral("    </script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entity.Concrete.BMIModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
