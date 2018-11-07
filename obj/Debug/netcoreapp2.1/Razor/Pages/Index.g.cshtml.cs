#pragma checksum "E:\GitHub\SceneIt\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bdc1abe0bcb858dcce685d60f6364bd5af659fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TVTracker.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(TVTracker.Pages.Pages_Index), null)]
namespace TVTracker.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\GitHub\SceneIt\Pages\_ViewImports.cshtml"
using TVTracker;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bdc1abe0bcb858dcce685d60f6364bd5af659fd", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64d5765c00d3e624e63e1a31b09b02d83d70a9e1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("createProgramForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "E:\GitHub\SceneIt\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(73, 188, true);
            WriteLiteral("\r\n<h1>My Watchlist</h1>\r\n<div class = \"container\">\r\n    <div class = \"col-md-6\">\r\n        <table class = \"table\" id=\"watchlist\"></table>\r\n    </div>\r\n    <div class = \"col-md-3\">\r\n        ");
            EndContext();
            BeginContext(261, 737, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86e6826a9b134b76adc76acafcbbb44e", async() => {
                BeginContext(303, 688, true);
                WriteLiteral(@"
            <h4>Add a new show</h4>
            <div class=""form-group"">
                <label for=""title"">Title</label>
                <input type=""text"" class=""form-control"" id=""title"" />
            </div>                
            <div class=""form-group"">
                <label for=""season"">Season</label>
                <input type=""number"" class=""form-control"" id=""season"" />
            </div>
            <div class=""form-group"">
                <label for=""episode"">Episode</label>
                <input type=""number"" class=""form-control"" id=""episode"" />
            </div>
            <button type=""submit"" class=""btn btn-primary"">Submit</button>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(998, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1038, 6064, true);
                WriteLiteral(@"
    <script>

    $(function() {
        loadData();
        $(""#createProgramForm"").submit(function(){
            createProgram();
            return false;
        })
    });

    function loadData() {
        $.ajax({
            url:""/api/TVPrograms"",
            dataType: 'json',
            contentType: 'application/json',
            method: 'GET'
        }).done(function(responseJSON, status, xhr) {
            buildWatchList(responseJSON);
        }).fail(function(xhr,status,error){
            alert(""Oh no! We couldn't find your shows. D:"");
        });
    }

    function buildWatchList(TVPrograms) {
        //console.log(""running buildwatchlist"");
        $(""#watchlist"").empty();
        $(""#watchlist"").append('<tr> <th>Show</th> <th>down</th> <th>Season</th><th>up</th>  <th>down</th><th>Episode</th> <th>up</th> <th>delete</th> </tr>')
        $.each(TVPrograms, function (index, item) {
            $(""#watchlist"").append(
                '<tr program-id = ""' + item.");
                WriteLiteral(@"id + '""> <td class = ""title-cell"">' + item.title 
                    + '</td> <td class = ""season-cell"">' + item.season 
                    + '</td> <td class = ""episode-cell"">' + item.episode 
                    + '</td> <td> <button class = ""btn btn-danger program-delete""> <span class=""glyphicon glyphicon-trash""></span> </button>'
                    + '</td> <td> <button class = ""btn btn-warning program-edit""> <span class=""glyphicon glyphicon-pencil""></span> </td> </tr>'
            )
        });
    }

    $(""#watchlist"").on('click', 'button.program-delete', function(){
        var id = $(this).parents(""tr"").attr('program-id');
        console.log(id);
        deleteProgram(id);
        return false;
    })
    $(""#watchlist"").on('click', 'button.program-edit', function(){
        var id = $(this).parents(""tr"").attr('program-id');
        var title = $(this).parents(""tr"").children("".title-cell"").text();
        var season = $(this).parents(""tr"").children("".season-cell"").text();
     ");
                WriteLiteral(@"   var episode = $(this).parents(""tr"").children("".episode-cell"").text();
// issues here in chrome but not edge   
        $(this).parents(""tr"").after(
        //$(this).parents(""tr"").replaceWith(
            '<form class=""form edit-form-id =""'+id+'"">' 
                + '<div class=""form-group"">'
                    + '<label for=""title"">Title</label>'
                    + '<input type=""text"" class=""form-control title-edit"" placeholder=""'+title+'""/>'
                +'</div>'                
                +'<div class=""form-group"">'
                    + '<label for=""season"">Season</label>'
                   + '<input type=""number"" class=""form-control season-edit"" placeholder=""'+season+'""/>'
                +'</div>'
                + '<div class=""form-group"">'
                   + '<label for=""episode"">Episode</label>'
                    +'<input type=""number"" class=""form-control episode-edit"" placeholder=""'+episode+'""/>'
                +'</div>'
                +'<button type=""submit""");
                WriteLiteral(@" class=""btn btn-primary edit-save"">Submit</button>'
                +'<button type=""cancel"" class=""btn edit-cancel"">Cancel</button>'
            +'</form>'
        );
        $(this).parents(""tr"").hide();
        return false;
    });

// Having trouble getting the information. Always ending up 'Undefined'

    $(""#watchlist"").on('click', 'button.edit-save', function() {
        var id = $(this).parents("".form"").attr('edit-form-id');
        console.log($(this).parents(""form"").attr('edit-form-id'));
        var title = $(this).parents(""form"").find('.title-edit').text();
        var season = $(this).parents(""form"").find('.season-edit').text();
        var episode = $(this).parents(""form"").find('.episode-edit').text();
        editProgram(id, title, season, episode, function() {
            $(this).parents(""#edit-Program-Form""+id).hide();
        });
        return false;
    });
    $(""#watchlist"").on('click', 'button.edit-cancel', function() {
            $(this).parents(""form"").hide();");
                WriteLiteral(@"
            $(this).parents(""form"").prev(""tr"").show();
        return false;
    });

    function createProgram() {
        var requestData = {
            title: $(""#title"").val(),
            season: $(""#season"").val(),
            episode: $(""#episode"").val()
        };
        $.ajax({
            url:""/api/TVPrograms/"",
            dataType: 'json',
            contentType: 'application/json',
            method: 'POST',
            data: JSON.stringify(requestData)
        }).done(function(responseJSON, status, xhr) {
            loadData();
            $(""#title"").val("""");
            $(""#season"").val("""");
            $(""#episode"").val("""");
        }).fail(function(xhr,status,error){
            alert(""Whoops! We couldn't add your show to the list."");
        });
    };

    function deleteProgram(id) {
        $.ajax({
            url:""/api/TVPrograms/"" + id,
            dataType: 'json',
            contentType: 'application/json',
            method: 'DELETE'
      ");
                WriteLiteral(@"  }).done(function(responseJSON, status, xhr){
            loadData();
        }).fail(function(xhr,status,error){
            alert(""Show not deleted. Try again."")
        })
    }

    
    function editProgram(id, title, season, episode, callback) {
        var requestData = {
            id: id,
            title: title,
            season: season,
            episode: episode
        };
        $.ajax({
            url: '/api/TVPrograms/' + id,
            dataType: 'json',
            contentType: 'application/json',
            method: 'PUT',
            data: JSON.stringify(requestData)
        }).done(function(responseData, status, xhr) {
            loadData(); // RELOAD THE BOOK DATA
            if (callback) {
                callback();
            }
        }).fail(function(xhr, status, error) {
            alert(""There was an error saving your book"");
        });
    }

    </script>
");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
