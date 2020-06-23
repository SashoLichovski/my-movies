#pragma checksum "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04e3be6ed67e1b5e8a4d88ee8ff36a12785aed71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MovieDetails), @"mvc.1.0.view", @"/Views/Home/MovieDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04e3be6ed67e1b5e8a4d88ee8ff36a12785aed71", @"/Views/Home/MovieDetails.cshtml")]
    public class Views_Home_MovieDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<my_movies.ViewModels.MovieDetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/movieLikes.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "SidebarPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddForApproval", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/movieLikes.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/axios/axios.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
  
    Layout = "_Layout";
    foreach (var item in Model.Comments)
    {
        if (item.Username == "developer")
        {
            item.Username = "Admin";
        }
    }

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral(" \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "04e3be6ed67e1b5e8a4d88ee8ff36a12785aed716574", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral("<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "04e3be6ed67e1b5e8a4d88ee8ff36a12785aed717854", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 19 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SidebarData);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
            WriteLiteral("\r\n<div class=\"container\" id=\"movieDetailContainer\" style=\"display: flex !important;\">\r\n    <div id=\"movieDetailsImageContainer\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 615, "\"", 636, 1);
#nullable restore
#line 25 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
WriteAttributeValue("", 621, Model.ImageUrl, 621, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div id=\"movieDetailsInfoContainer\">\r\n        <h2>");
#nullable restore
#line 28 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h5>Description</h5>\r\n        <p>");
#nullable restore
#line 30 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <h5>Cast</h5>\r\n        <p>");
#nullable restore
#line 32 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
      Write(Model.Cast);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <br />\r\n        <p>Duration ");
#nullable restore
#line 34 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
               Write(Model.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" min</p>\r\n        <p>Views: ");
#nullable restore
#line 35 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
             Write(Model.Views);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Date created: ");
#nullable restore
#line 36 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
                    Write(Model.DateCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"container\" style=\"padding: 30px\">\r\n\r\n    <div id=\"likeCountContainer\">\r\n        <p>Likes: <span id=\"likesCount\">");
#nullable restore
#line 43 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
                                   Write(Model.Likes.Where(x => x.IsLiked == true).Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n        <p>Dislikes: <span id=\"dislikesCount\">");
#nullable restore
#line 44 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
                                         Write(Model.Likes.Where(x => x.IsLiked == false).Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n    </div>\r\n");
#nullable restore
#line 46 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
     if (User.Identity.IsAuthenticated)
    {
        if (Model.LikeStatus == my_movies.ViewModels.LikeModels.LikeStatus.None)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div id=\"likeBtnContainer\">\r\n                <button id=\"addLikeBtn\" class=\"btn btn-outline-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1573, "\"", 1601, 3);
            WriteAttributeValue("", 1583, "AddLike(", 1583, 8, true);
#nullable restore
#line 51 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
WriteAttributeValue("", 1591, Model.Id, 1591, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1600, ")", 1600, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Like</button>\r\n                <button id=\"likedBtn\" class=\"btn btn-success hideBtn\" disabled>Liked</button>\r\n                <button id=\"addDislikeBtn\" class=\"btn btn-outline-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1786, "\"", 1817, 3);
            WriteAttributeValue("", 1796, "AddDislike(", 1796, 11, true);
#nullable restore
#line 53 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
WriteAttributeValue("", 1807, Model.Id, 1807, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1816, ")", 1816, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Dislike</button>\r\n                <button id=\"dislikedBtn\" class=\"btn btn-danger hideBtn\" disabled>Disliked</button>\r\n            </div>\r\n                <span id=\"removeVoteLink\" style=\"display: none\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2020, "\"", 2051, 3);
            WriteAttributeValue("", 2030, "RemoveVote(", 2030, 11, true);
#nullable restore
#line 56 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
WriteAttributeValue("", 2041, Model.Id, 2041, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2050, ")", 2050, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Remove vote</span>\r\n");
#nullable restore
#line 57 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
        }
        else if (Model.LikeStatus == my_movies.ViewModels.LikeModels.LikeStatus.Liked)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div id=\"likeBtnContainer\">\r\n                <button id=\"addLikeBtn\" class=\"btn btn-outline-success hideBtn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2303, "\"", 2331, 3);
            WriteAttributeValue("", 2313, "AddLike(", 2313, 8, true);
#nullable restore
#line 61 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
WriteAttributeValue("", 2321, Model.Id, 2321, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2330, ")", 2330, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Like</button>\r\n                <button id=\"likedBtn\" class=\"btn btn-success\" disabled>Liked</button>\r\n                <button id=\"addDislikeBtn\" class=\"btn btn-outline-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2508, "\"", 2539, 3);
            WriteAttributeValue("", 2518, "AddDislike(", 2518, 11, true);
#nullable restore
#line 63 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
WriteAttributeValue("", 2529, Model.Id, 2529, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2538, ")", 2538, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Dislike</button>\r\n                <button id=\"dislikedBtn\" class=\"btn btn-danger hideBtn\" disabled>Disliked</button>\r\n            </div>\r\n            <span id=\"removeVoteLink\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2716, "\"", 2747, 3);
            WriteAttributeValue("", 2726, "RemoveVote(", 2726, 11, true);
#nullable restore
#line 66 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
WriteAttributeValue("", 2737, Model.Id, 2737, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2746, ")", 2746, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Remove vote</span>\r\n");
#nullable restore
#line 67 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
        }
        else if (Model.LikeStatus == my_movies.ViewModels.LikeModels.LikeStatus.Disliked)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div id=\"likeBtnContainer\">\r\n                <button id=\"addLikeBtn\" class=\"btn btn-outline-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2994, "\"", 3022, 3);
            WriteAttributeValue("", 3004, "AddLike(", 3004, 8, true);
#nullable restore
#line 71 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
WriteAttributeValue("", 3012, Model.Id, 3012, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3021, ")", 3021, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Like</button>\r\n                <button id=\"likedBtn\" class=\"btn btn-success hideBtn\" disabled>Liked</button>\r\n                <button id=\"addDislikeBtn\" class=\"btn btn-outline-danger hideBtn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3215, "\"", 3246, 3);
            WriteAttributeValue("", 3225, "AddDislike(", 3225, 11, true);
#nullable restore
#line 73 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
WriteAttributeValue("", 3236, Model.Id, 3236, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3245, ")", 3245, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Dislike</button>\r\n                <button id=\"dislikedBtn\" class=\"btn btn-danger\" disabled>Disliked</button>\r\n            </div>\r\n            <span id=\"removeVoteLink\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3415, "\"", 3446, 3);
            WriteAttributeValue("", 3425, "RemoveVote(", 3425, 11, true);
#nullable restore
#line 76 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
WriteAttributeValue("", 3436, Model.Id, 3436, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3445, ")", 3445, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Remove vote</span>\r\n");
#nullable restore
#line 77 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <hr />\r\n    <h3>Comment section:</h3>\r\n");
#nullable restore
#line 82 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
     if (User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04e3be6ed67e1b5e8a4d88ee8ff36a12785aed7120094", async() => {
                WriteLiteral("\r\n            <input id=\"movieId\" name=\"movieId\"");
                BeginWriteAttribute("value", " value=\"", 3732, "\"", 3749, 1);
#nullable restore
#line 86 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
WriteAttributeValue("", 3740, Model.Id, 3740, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\r\n            <input class=\"form-inline\" placeholder=\"Enter a comment\" id=\"comment\" name=\"comment\" />\r\n            <input type=\"submit\" class=\"btn btn-outline-dark\" style=\"margin-left: 5px;\" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <br />\r\n");
#nullable restore
#line 91 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n");
#nullable restore
#line 93 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
         if (Model.Comments.Count == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>No comments yet</p>\r\n");
#nullable restore
#line 96 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
         foreach (var comment in Model.Comments)
        {
            if (comment.IsApproved)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"border-bottom: 1px solid rgb(255, 255, 255); padding: 20px;\">\r\n                    <p>By: <b> ");
#nullable restore
#line 102 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
                          Write(comment.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                    <span>Comment:</span>\r\n                    <p style=\"margin-left: 8px\">");
#nullable restore
#line 104 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
                                           Write(comment.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <span>Posted on: ");
#nullable restore
#line 105 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
                                Write(comment.DateCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 106 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
                     if (User.Identity.IsAuthenticated && User.FindFirst("Role").Value == "admin")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <br />\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04e3be6ed67e1b5e8a4d88ee8ff36a12785aed7124863", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 109 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
                                                                                 WriteLiteral(comment.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 110 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
                     if (User.Identity.IsAuthenticated && User.FindFirst("Role").Value != "admin")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <br />\r\n                        <a href=\"#\">Report</a>\r\n");
#nullable restore
#line 115 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 117 "C:\Users\Sasho\Desktop\MVC\my-movies\my-movies\Views\Home\MovieDetails.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(" \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04e3be6ed67e1b5e8a4d88ee8ff36a12785aed7128426", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04e3be6ed67e1b5e8a4d88ee8ff36a12785aed7129526", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<my_movies.ViewModels.MovieDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
