#pragma checksum "C:\Users\yazilim.park5\source\repos\AppYP\AppYP\Views\Todo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75800e41b848de9d12822ae4718231ba6d51f4bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_Index), @"mvc.1.0.view", @"/Views/Todo/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75800e41b848de9d12822ae4718231ba6d51f4bc", @"/Views/Todo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b6b9cc67d89162ae5d1ff53d3b41274f794e2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Todo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Entity.Concrete.TodoModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/todoStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "75800e41b848de9d12822ae4718231ba6d51f4bc3799", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<link href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css"" rel=""stylesheet"" />
<link href=""https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&display=swap"" rel=""stylesheet"" />

<section class=""py-5"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 mx-auto"">
                <header class=""text-center pb-5"">
                    <h1 class=""h2"">Todo List</h1>
                </header>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-6 mx-auto"">
                <blockquote class=""blockquote blockquote-custom bg-white p-5 shadow rounded"">
                    <div class=""blockquote-custom-icon bg-info shadow-sm""><i class=""fa fa-check text-white""></i></div>
                    <div class=""add-items d-flex""> <input type=""text"" class=""form-control todo-list-input"" placeholder=""What do you need to do today?""> <button class=""add btn btn-primary font-weight-bold todo-list-add-btn"">Add<");
            WriteLiteral("/button> </div>\r\n                    <footer class=\"pt-4 mt-4 border-top\">\r\n                        <div class=\"list-wrapper\">\r\n                            <ul class=\"d-flex flex-column-reverse todo-list\">\r\n");
#nullable restore
#line 24 "C:\Users\yazilim.park5\source\repos\AppYP\AppYP\Views\Todo\Index.cshtml"
                                 foreach (var item in Model)
                                {
                                    if (item.isDone)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"completed\"");
            BeginWriteAttribute("id", " id=", 1583, "", 1595, 1);
#nullable restore
#line 28 "C:\Users\yazilim.park5\source\repos\AppYP\AppYP\Views\Todo\Index.cshtml"
WriteAttributeValue("", 1587, item.id, 1587, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"form-check\"> <label class=\"form-check-label\"> <input class=\"checkbox\" type=\"checkbox\"");
            BeginWriteAttribute("checked", " checked=\"", 1739, "\"", 1749, 0);
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 29 "C:\Users\yazilim.park5\source\repos\AppYP\AppYP\Views\Todo\Index.cshtml"
                                                                                                                                                     Write(item.todo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"input-helper\"></i></label> </div> <i class=\"remove mdi mdi-close-circle-outline\"></i>\r\n                                        </li>\r\n");
#nullable restore
#line 31 "C:\Users\yazilim.park5\source\repos\AppYP\AppYP\Views\Todo\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li");
            BeginWriteAttribute("id", " id=", 2070, "", 2082, 1);
#nullable restore
#line 34 "C:\Users\yazilim.park5\source\repos\AppYP\AppYP\Views\Todo\Index.cshtml"
WriteAttributeValue("", 2074, item.id, 2074, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"form-check\"> <label class=\"form-check-label\"> <input class=\"checkbox\" type=\"checkbox\"> ");
#nullable restore
#line 35 "C:\Users\yazilim.park5\source\repos\AppYP\AppYP\Views\Todo\Index.cshtml"
                                                                                                                                          Write(item.todo);

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"input-helper\"></i></label> </div> <i class=\"remove mdi mdi-close-circle-outline\"></i>\r\n                                        </li>\r\n");
#nullable restore
#line 37 "C:\Users\yazilim.park5\source\repos\AppYP\AppYP\Views\Todo\Index.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </ul>
                        </div>
                    </footer>
                </blockquote>
            </div>
        </div>
    </div>
</section>
<script>
    (function ($) {
        'use strict';
        $(function () {
            var todoListItem = $('.todo-list');
            var todoListInput = $('.todo-list-input');
            $('.todo-list-add-btn').on(""click"", function (event) {
                event.preventDefault();

                var item = $(this).prevAll('.todo-list-input').val();

                if (item) {


                    $.ajax({
                        type: ""POST"",
                        data: {
                            'todo': item,
                        },
                        url: ""/Todo/Add"",
                        cache: false,
                        success: function (data) {
                            todoListItem.append(`<li id=${data.id}><div class='form-check'><label class='form-check-label'><inp");
            WriteLiteral(@"ut class='checkbox' type='checkbox'/>${item}<i class='input-helper'></i></label></div><i class='remove mdi mdi-close-circle-outline'></i></li>`);
                            todoListInput.val("""");
                        }
                    });

                }

            });

            todoListItem.on('change', '.checkbox', function () {

                var item = $(this).parent().parent().parent();
                var thisItem = $(this);
                //alert(item.attr('id'))

                $.ajax({
                    type: ""POST"",
                    data: {
                        'id': item.attr('id'),
                    },
                    url: ""/Todo/Change"",
                    cache: false,
                    success: function (data) {
                        if (thisItem.attr('checked')) {
                            thisItem.removeAttr('checked');
                        } else {
                            thisItem.attr('checked', 'checked');
         ");
            WriteLiteral(@"               }
                        thisItem.closest(""li"").toggleClass('completed');
                    }
                });   

            });

            todoListItem.on('click', '.remove', function () {
                var item = $(this).parent();
                $.ajax({
                    type: ""POST"",
                    data: {
                        'id': item.attr('id'),
                    },
                    url: ""/Todo/Delete"",
                    cache: false,
                    success: function (data) {
                        //alert(item.attr('id'));
                        item.remove();
                    }
                });

                //alert($(this).parent().attr('id'));
            });

        });
    })(jQuery);


</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Entity.Concrete.TodoModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
