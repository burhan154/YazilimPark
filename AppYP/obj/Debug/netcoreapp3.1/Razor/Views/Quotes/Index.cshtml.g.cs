#pragma checksum "C:\Users\yazilim.park5\source\repos\AppYP\AppYP\Views\Quotes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "916d77a540f842fb0c23ec0978466bb9d8e3bc37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quotes_Index), @"mvc.1.0.view", @"/Views/Quotes/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"916d77a540f842fb0c23ec0978466bb9d8e3bc37", @"/Views/Quotes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b6b9cc67d89162ae5d1ff53d3b41274f794e2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Quotes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entity.Concrete.QuoteModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""py-5"">
    <div class=""container"">

        <div class=""row"">
            <div class=""col-lg-6 mx-auto"">
                <header class=""text-center pb-5"">
                    <h1 class=""h2"">Random Quote App</h1>
                </header>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-lg-6 mx-auto"">
                <blockquote class=""blockquote blockquote-custom bg-white p-5 shadow rounded"">
                    <div class=""blockquote-custom-icon bg-info shadow-sm""><i class=""fa fa-quote-left text-white""></i></div>
                    <p id=""quote"" class=""mb-0 mt-2 font-italic"">""");
#nullable restore
#line 18 "C:\Users\yazilim.park5\source\repos\AppYP\AppYP\Views\Quotes\Index.cshtml"
                                                            Write(Model.quote);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</p>\r\n                    <footer class=\"blockquote-footer pt-4 mt-4 border-top\">\r\n                        <cite id=\"author\" title=\"Source Title\">");
#nullable restore
#line 20 "C:\Users\yazilim.park5\source\repos\AppYP\AppYP\Views\Quotes\Index.cshtml"
                                                          Write(Model.author);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</cite>
                        <div class=""float-right""><button id=""newQuote"" value=""Random"" class=""btn btn-primary"">New Quote</button></div>
                    </footer>
                </blockquote>
            </div>
        </div>
    </div>
</section>


<script type=""text/javascript"">
        $(""#newQuote"").click(function () {
            $.ajax({
                type: ""POST"",
                url: ""/Quotes/GetNewQuote"",
                cache: false,
                success: function (data) {
                    $(""#quote"").html(data.quote);
                    $(""#author"").html(data.author);
                }
            });
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entity.Concrete.QuoteModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
