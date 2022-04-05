#pragma checksum "C:\Users\HBJ\Documents\GitHub\TreeFriend\TreeFriend\TreeFriend\Views\Admin\AddCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d160e6726557a5af192de849a659c394af081bb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AddCategory), @"mvc.1.0.view", @"/Views/Admin/AddCategory.cshtml")]
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
#line 1 "C:\Users\HBJ\Documents\GitHub\TreeFriend\TreeFriend\TreeFriend\Views\_ViewImports.cshtml"
using TreeFriend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HBJ\Documents\GitHub\TreeFriend\TreeFriend\TreeFriend\Views\_ViewImports.cshtml"
using TreeFriend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d160e6726557a5af192de849a659c394af081bb5", @"/Views/Admin/AddCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ed1de32b8e400d8301d144bd9ff5547adcd0543", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AddCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Admin/addCategory.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\HBJ\Documents\GitHub\TreeFriend\TreeFriend\TreeFriend\Views\Admin\AddCategory.cshtml"
  
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d160e6726557a5af192de849a659c394af081bb54036", async() => {
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


<div class=""item"" id=""category"">
    <div class=""item-head"">
        <label for=""category-name"">分類 :</label>
        <input type=""text"" id=""input-category"" v-model=""category.categoryName"" v-on:blur=""checkName"">
        <button id=""btn-category"" v-on:click=""addCategory"">新增</button>
        <label id=""error-msg"" v-if=""isExists"">類別已存在</label>
    </div>
    <table>
        <thead>
            <tr>
                <th class=""tb-id"">ID</th>
                <th class=""tb-name"">分類名稱</th>
                <th class=""tb-user"">管理員</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            <tr v-for=""item in resultList"">
                <td class=""tb-id"">{{item.categoryId}}</td>
                <td class=""tb-name"">{{item.categoryName}}</td>
                <td class=""tb-user"">{{item.userId}}</td>
                <td class=""tb-btn"">
                    <button>edit</button>
                    <button v-on:click=""deleteCategory"" v-bind:value=""item.categoryId""");
            WriteLiteral(@">x</button>
                </td>
            </tr>
        </tbody>
    </table>
</div>
<div class=""item"" id=""hashtag"">
    <div class=""item-head"">
        <label for=""input-hashtag"">標籤 :</label>
        <input type=""text"" id=""input-hashtag"" v-model=""hashtag.hashtagName"" v-on:blur=""checkName"">
        <button id=""btn-hashtag"" v-on:click=""addHashtag"">新增</button>
        <label id=""error-msg"" v-if=""isExists"">標籤已存在</label>
    </div>
    <table>
        <thead>
            <tr>
                <th class=""tb-id"">ID</th>
                <th class=""tb-name"">標籤名稱</th>
                <th class=""tb-user"">管理員</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            <tr v-for=""item in resultList"">
                <td class=""tb-id"">{{item.hashtagId}}</td>
                <td class=""tb-name"">{{item.hashtagName}}</td>
                <td class=""tb-user"">{{item.userId}}</td>
                <td class=""tb-btn"">
                    <button>edit</button>
     ");
            WriteLiteral(@"               <button v-on:click=""deleteHashtag"" v-bind:value=""item.hashtagId"">x</button>
                </td>
            </tr>
        </tbody>
    </table>
</div>

<script>
    let getAll= function (e,name) {
                const self = e;
                axios.get(`../Api/Category/GetAll${name}`)
                    .then(res => {
                        self.resultList = res.data;
                        console.log(self.resultList);
                    })
            }


    //分類區塊
    let appCategory = new Vue({
        el: ""#category"",
        data: {
            resultList:[],
            category:{
                categoryName: """",
                //userId: ""4"",
            },
            isExists: false
        },
        mounted:function(){
            getAll(this,""category"");
        },
        methods:{
            //驗證類別是否存在
            checkName: function(){
                const btn = document.querySelector(""#btn-category"")
                const self = t");
            WriteLiteral(@"his;
                axios.get(`../Api/Category/CheckCategory/?categoryName=${self.category.categoryName}`)
                .then(res =>{
                    console.log(res);
                    if(res.data === true){
                        //如果存在的話把按鈕禁用
                        self.isExists = true;
                        btn.disabled = true;
                    }else {
                        self.isExists = false;
                        btn.disabled = false;
                    }
                })
                .catch(err => console.log(err));
            },
            addCategory: function(){
                const self = this;
                axios.post(""../Api/Category/AddCategory"",self.category)
                .then(res =>{
                    if(res.data === true){
                        alert(`類別 : ${self.category.categoryName}，新增成功`)
                        getAll(self,""category"");
                        self.category.categoryName =""""
                    }else {
    ");
            WriteLiteral(@"                    alert(""新增失敗"");
                    }
                })
                .catch(err => console.log(err));
            },
            deleteCategory: function (event) {
                const self = this;
                const categoryId = event.target.value;
                console.log(categoryId);
                axios.delete(`../Api/Category/DeleteCategory/?categoryId=${categoryId}`)
                    .then(res => {
                        if (res.data === true) {
                            alert(""類別刪除成功!"");
                            getAll(self,""category"");
                        }else {
                            alert(""類別刪除失敗!"");
                        }
                    }
                    ).catch(err => console.log(err));
            }
        }
    });


    //標籤區塊
    let appHashtag = new Vue({
        el: ""#hashtag"",
        data: {
            resultList:[],
            hashtag:{
                hashtagName: """",
                //userId:");
            WriteLiteral(@" ""4"",
            },
            isExists: false
        },
        mounted: function(){
            getAll(this,""hashTag"");
        },
        methods:{
            //驗證類別是否存在
            checkName: function(){
                const btn = document.querySelector(""#btn-hashtag"")
                const self = this;
                axios.get(`../Api/Category/CheckHashTag/?hashtagName=${self.hashtag.hashtagName}`)
                .then(res =>{
                    console.log(res);
                    if(res.data === true){
                        //如果存在的話把按鈕禁用
                        self.isExists = true;
                        btn.disabled = true;
                    }else {
                        self.isExists = false;
                        btn.disabled = false;
                    }
                })
                .catch(err => console.log(err));
            },
            addHashtag: function(){
                const self = this;
                axios.post(""../Api/Category/Ad");
            WriteLiteral(@"dHashtag"",self.hashtag)
                .then(res =>{
                    if(res.data === true){
                        alert(`類別 : ${self.hashtag.hashtagName}，新增成功`)
                        getAll(self,""hashtag"");
                        self.hashtag.hashtagName ="""";
                    }else {
                        alert(""新增失敗"");
                    }
                })
                .catch(err => console.log(err));
            },
            deleteHashtag: function (event) {
                const self = this;
                const hashtagId = event.target.value;
                console.log(hashtagId);
                axios.delete(`../Api/Category/DeleteHashtag/?hashtagId=${hashtagId}`)
                    .then(res => {
                        if (res.data === true) {
                            alert(""類別刪除成功!"");
                            getAll(self,""hashTag"");
                        }else {
                            alert(""類別刪除失敗!"");
                        }
           ");
            WriteLiteral("         }\r\n                    ).catch(err => console.log(err));\r\n            }\r\n        }\r\n    });\r\n</script>");
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
