#pragma checksum "C:\Users\edc54\OneDrive\桌面\專題整合\TreeFriend\TreeFriend\TreeFriend\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ea0c8f0f964e1ea56750646679b5ddc30f75366"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\edc54\OneDrive\桌面\專題整合\TreeFriend\TreeFriend\TreeFriend\Views\_ViewImports.cshtml"
using TreeFriend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\edc54\OneDrive\桌面\專題整合\TreeFriend\TreeFriend\TreeFriend\Views\_ViewImports.cshtml"
using TreeFriend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ea0c8f0f964e1ea56750646679b5ddc30f75366", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ed1de32b8e400d8301d144bd9ff5547adcd0543", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Layout/Nav.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Reset.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/icon/Logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ea0c8f0f964e1ea56750646679b5ddc30f753665553", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>");
#nullable restore
#line 7 "C:\Users\edc54\OneDrive\桌面\專題整合\TreeFriend\TreeFriend\TreeFriend\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" - TreeFriend</title>
    <script src=""https://cdn.jsdelivr.net/npm/vue@2""></script>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/axios/0.26.1/axios.min.js"" integrity=""sha512-bPh3uwgU5qEMipS/VOmRqynnMXGGSRv+72H/N260MQeXZIK4PG48401Bsby9Nq5P5fz7hy5UGNmC/W1Z51h2GQ=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1ea0c8f0f964e1ea56750646679b5ddc30f753667043", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1ea0c8f0f964e1ea56750646679b5ddc30f753668221", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ea0c8f0f964e1ea56750646679b5ddc30f7536610103", async() => {
                WriteLiteral("\r\n    <nav id=\"header-nav\" class=\"navbar navbar-expand-lg navbar-light bg-brown\">\r\n        <div class=\"container-fluid\">\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 1388, "\"", 1425, 1);
#nullable restore
#line 20 "C:\Users\edc54\OneDrive\桌面\專題整合\TreeFriend\TreeFriend\TreeFriend\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1395, Url.Action("HomePage","Home"), 1395, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1ea0c8f0f964e1ea56750646679b5ddc30f7536610933", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </a>
            <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarNavDropdown""
                    aria-controls=""navbarNavDropdown"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarNavDropdown"">
                <ul class=""navbar-nav d-flex align-items-center"">
");
#nullable restore
#line 29 "C:\Users\edc54\OneDrive\桌面\專題整合\TreeFriend\TreeFriend\TreeFriend\Views\Shared\_Layout.cshtml"
                     if (User.IsInRole("Admin")) {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"nav-item\">\r\n                            <a class=\"nav-link\"");
                BeginWriteAttribute("href", " href=\"", 2111, "\"", 2152, 1);
#nullable restore
#line 31 "C:\Users\edc54\OneDrive\桌面\專題整合\TreeFriend\TreeFriend\TreeFriend\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2118, Url.Action("AddCategory","Admin"), 2118, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">管理員</a>\r\n                        </li>\r\n");
#nullable restore
#line 33 "C:\Users\edc54\OneDrive\桌面\專題整合\TreeFriend\TreeFriend\TreeFriend\Views\Shared\_Layout.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                BeginWriteAttribute("href", " href=\"", 2303, "\"", 2343, 1);
#nullable restore
#line 35 "C:\Users\edc54\OneDrive\桌面\專題整合\TreeFriend\TreeFriend\TreeFriend\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2310, Url.Action("ProductPage","Home"), 2310, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">講座</a>\r\n                    </li>\r\n");
#nullable restore
#line 37 "C:\Users\edc54\OneDrive\桌面\專題整合\TreeFriend\TreeFriend\TreeFriend\Views\Shared\_Layout.cshtml"
                      
                        if (Context.User.Identity.IsAuthenticated) {
                            var imgPath = Context.User.Claims.FirstOrDefault(c => c.Type == "Headshot").Value;


#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <li class=""nav-item dropdown d-flex align-items-center"">
                                <a class=""nav-link dropdown-toggle head-area"" href=""#"" id=""navbarDropdownMenuLink"" role=""button""
                               data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                    <img class=""headshot""");
                BeginWriteAttribute("src", " src=\"", 2942, "\"", 2956, 1);
#nullable restore
#line 44 "C:\Users\edc54\OneDrive\桌面\專題整合\TreeFriend\TreeFriend\TreeFriend\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2948, imgPath, 2948, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2957, "\"", 2963, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                </a>\r\n                                <ul class=\"dropdown-menu dropdown-menu-end\" aria-labelledby=\"navbarDropdownMenuLink\">\r\n                                    <li><a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 3188, "\"", 3227, 1);
#nullable restore
#line 47 "C:\Users\edc54\OneDrive\桌面\專題整合\TreeFriend\TreeFriend\TreeFriend\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3195, Url.Action("MemberInfo","Home"), 3195, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">基本資料</a></li>\r\n                                    <li><a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 3308, "\"", 3350, 1);
#nullable restore
#line 48 "C:\Users\edc54\OneDrive\桌面\專題整合\TreeFriend\TreeFriend\TreeFriend\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3315, Url.Action("SkillPostPage","Home"), 3315, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">技能發文</a></li>\r\n                                    <li><a class=\"dropdown-item\" v-on:click=\"logout\">登出</a></li>\r\n                                </ul>\r\n                            </li>\r\n");
#nullable restore
#line 52 "C:\Users\edc54\OneDrive\桌面\專題整合\TreeFriend\TreeFriend\TreeFriend\Views\Shared\_Layout.cshtml"
                        } else {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li class=\"nav-item\">\r\n                                <a class=\"nav-link\"");
                BeginWriteAttribute("href", " href=\"", 3675, "\"", 3714, 1);
#nullable restore
#line 54 "C:\Users\edc54\OneDrive\桌面\專題整合\TreeFriend\TreeFriend\TreeFriend\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3682, Url.Action("Create","Register"), 3682, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">登入</a>\r\n                            </li>\r\n");
#nullable restore
#line 56 "C:\Users\edc54\OneDrive\桌面\專題整合\TreeFriend\TreeFriend\TreeFriend\Views\Shared\_Layout.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n    </nav>\r\n\r\n    ");
#nullable restore
#line 63 "C:\Users\edc54\OneDrive\桌面\專題整合\TreeFriend\TreeFriend\TreeFriend\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 65 "C:\Users\edc54\OneDrive\桌面\專題整合\TreeFriend\TreeFriend\TreeFriend\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    new Vue({
        el:""#header-nav"",
        methods:{
            logout: function(){
                axios.get(""../Register/Logout"")
                .then(res => {
                    window.location.href=res.data;
                });
            }
        }
    });
</script>
</html>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
