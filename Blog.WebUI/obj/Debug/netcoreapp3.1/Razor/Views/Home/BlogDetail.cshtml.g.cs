#pragma checksum "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\BlogDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9477b3dc933d3e19c11c8d4004e1dac48aba03e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Blog.WebUI.Models.Home.Views_Home_BlogDetail), @"mvc.1.0.view", @"/Views/Home/BlogDetail.cshtml")]
namespace Blog.WebUI.Models.Home
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
#line 2 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\_ViewImports.cshtml"
using Blog.WebUI.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9477b3dc933d3e19c11c8d4004e1dac48aba03e", @"/Views/Home/BlogDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a9f018607cccf7008b0e187b697fb5182aea26c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BlogDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/AddToComment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\BlogDetail.cshtml"
  
    var comments = (List<CommentListViewModel>)ViewBag.Comments;

    void GetComments(List<CommentListViewModel> comments)
    {
        if (comments.Count > 0)
        {
            foreach (var comment in comments)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"media my-4\">\r\n                    <img class=\"d-flex mr-3 rounded-circle\" src=\"http://placehold.it/50x50\"");
            BeginWriteAttribute("alt", " alt=\"", 405, "\"", 411, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"media-body\">\r\n                        <h5 class=\"mt-0\">");
#nullable restore
#line 15 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\BlogDetail.cshtml"
                                    Write(comment.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        ");
#nullable restore
#line 16 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\BlogDetail.cshtml"
                   Write(comment.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <button type=\"button\" class=\"btn btn-sm btn-primary float-right\"");
            BeginWriteAttribute("onclick", " onclick=\"", 662, "\"", 710, 5);
            WriteAttributeValue("", 672, "showCommentForm(", 672, 16, true);
#nullable restore
#line 17 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\BlogDetail.cshtml"
WriteAttributeValue("", 688, comment.Id, 688, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 699, ",", 699, 1, true);
#nullable restore
#line 17 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\BlogDetail.cshtml"
WriteAttributeValue("", 700, Model.Id, 700, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 709, ")", 709, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Cevapla</button>\r\n                        <div");
            BeginWriteAttribute("id", " id=\"", 758, "\"", 786, 2);
            WriteAttributeValue("", 763, "commentBox", 763, 10, true);
#nullable restore
#line 18 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\BlogDetail.cshtml"
WriteAttributeValue("", 773, comment.Id, 773, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                        </div>\r\n\r\n");
#nullable restore
#line 22 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\BlogDetail.cshtml"
                          
                            GetComments(comment.SubComments);
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 28 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\BlogDetail.cshtml"
            }
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Title -->\r\n<h1 class=\"mt-4\">");
#nullable restore
#line 35 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\BlogDetail.cshtml"
            Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<!-- Author -->\r\n");
            WriteLiteral("\r\n<hr>\r\n\r\n<!-- Date/Time -->\r\n<p>Posted on ");
#nullable restore
#line 46 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\BlogDetail.cshtml"
        Write(Model.PostedTime.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<hr>\r\n\r\n<!-- Preview Image -->\r\n<getblogimage");
            BeginWriteAttribute("id", " id=\"", 1326, "\"", 1340, 1);
#nullable restore
#line 51 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\BlogDetail.cshtml"
WriteAttributeValue("", 1331, Model.Id, 1331, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("blog-image-type", " blog-image-type=\"", 1341, "\"", 1384, 1);
#nullable restore
#line 51 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\BlogDetail.cshtml"
WriteAttributeValue("", 1359, BlogImageType.BlogDetail, 1359, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></getblogimage>\r\n");
            WriteLiteral("\r\n<hr>\r\n\r\n<!-- Post Content -->\r\n");
#nullable restore
#line 57 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\BlogDetail.cshtml"
Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<hr>\r\n\r\n<!-- Comments Form -->\r\n<div class=\"card my-4\">\r\n    <h5 class=\"card-header\">Yorum Yaz:</h5>\r\n    <div class=\"card-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9477b3dc933d3e19c11c8d4004e1dac48aba03e9047", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"BlogId\"");
                BeginWriteAttribute("value", " value=\"", 1781, "\"", 1798, 1);
#nullable restore
#line 66 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\BlogDetail.cshtml"
WriteAttributeValue("", 1789, Model.Id, 1789, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
           
            <div class=""form-group"">
                <label>Gözükmesini İstediğinz Ad :</label>
                <input type=""text"" class=""form-control"" name=""AuthorName"" required />
            </div>
            <div class=""form-group"">
                <label>Email Adresiniz :</label>
                <input type=""email"" class=""form-control"" name=""AuthorEmail"" required />
            </div>
            <div class=""form-group"">
                <label>Yorumunuz :</label>
                <textarea class=""form-control"" rows=""3"" name=""Description"" required></textarea>
            </div>
            <button type=""submit"" class=""btn btn-primary"">Submit</button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<!-- Comment with nested comments -->\r\n");
#nullable restore
#line 86 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\BlogDetail.cshtml"
   
    GetComments(comments);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("JavaScript", async() => {
                WriteLiteral(@"
    <script>
        function showCommentForm(id,blogId) {
            let html = `<div class=""card my-4""> <h5 class=""card-header"">Yorum Yaz:</h5> <div class=""card-body""> <form method=""post"" action=""/Home/AddToComment""> <input type=""hidden"" name=""BlogId"" value=""${blogId}""> <input type=""hidden"" name=""ParentCommentId"" value=""${id}""> <div class=""form-group""> <label>Gözükmesini İstediğinz Ad :</label> <input type=""text"" class=""form-control"" name=""AuthorName"" required> </div><div class=""form-group""> <label>Email Adresiniz :</label> <input type=""email"" class=""form-control"" name=""AuthorEmail"" required> </div><div class=""form-group""> <label>Yorumunuz :</label> <textarea class=""form-control"" rows=""3"" name=""Description"" required></textarea> </div><button type=""button"" class=""btn btn-warning"" onclick=""hideCommentForm(${id})"">Vazgeç</button> <button type=""submit"" class=""btn btn-primary"">Gönder</button> </form> </div></div>`;
            $(""#commentBox"" + id).html(html);
        }

        function hideCommentForm");
                WriteLiteral("(id) {\r\n            $(\"#commentBox\" + id).html(\"\");\r\n        }\r\n    </script>\r\n ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
