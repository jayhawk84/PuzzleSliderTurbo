#pragma checksum "C:\Users\mobyf_000\source\repos\Puzzle15\Puzzle15\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a204d26cc3f800b708329e83f3ca47449aee689a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\mobyf_000\source\repos\Puzzle15\Puzzle15\Views\_ViewImports.cshtml"
using Puzzle15;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mobyf_000\source\repos\Puzzle15\Puzzle15\Views\_ViewImports.cshtml"
using Puzzle15.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a204d26cc3f800b708329e83f3ca47449aee689a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"748bc00e3d984ae1b7ef83e2849e7359b00f9560", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mobyf_000\source\repos\Puzzle15\Puzzle15\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
    <div class=""col-sm-12 col-md-3"">
        <div class=""card text-center"">
            <img src=""/images/1.jpg"" class=""card-img-top"" alt=""..."">
            <div class=""card-body"">
                <a href=""#"" class=""btn btn-primary"">Show/Hide image</a>
            </div>
        </div>
    </div>
    <div class=""col-sm-12 col-md-6 puzzle-col"">
        <div class=""card text-center"">
            <div class=""card-body"">
                <h2 class=""card-title"">Super Puzzle Slider Turbo</h2>
                <p class=""card-text"">A classic sliding piece puzzle game.</p>
                <a href=""#"" class=""btn btn-primary"">Start Sliding!</a>
            </div>
        </div>
    </div>
    <div class=""col-sm-12 col-md-3"">
        <div class=""card text-center"">
            <img src=""/images/2.jpg"" class=""card-img-top"" alt=""..."">
            <div class=""card-body"">
                <div class=""row align-items-center"">
                    <i class=""fa ");
            WriteLiteral(@"fa-caret-left fa-3x"" aria-hidden=""true""></i>
                    <a href=""#"" class=""btn btn-primary"">Use this image</a>
                    <i class=""fa fa-caret-right fa-3x"" aria-hidden=""true""></i>
                </div>
            </div>
        </div>
    </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-12 col-md-3 side-col"">
            <a href=""#"" class=""btn btn-primary btn-block"">EASY</a>
            <a href=""#"" class=""btn btn-primary btn-block"">MEDIUM</a>
            <a href=""#"" class=""btn btn-primary btn-block"">HARD</a>
        </div>
        <div class=""col-sm-12 col-md-6"">
            <img src=""/images/2.jpg"" class=""img-fluid"" />
        </div>
        <div class=""col-sm-12 col-md-3 side-col"">
            <a href=""#"" class=""btn btn-primary btn-block"">COLOR</a>
            <a href=""#"" class=""btn btn-primary btn-block"">B&W</a>
            <a href=""#"" class=""btn btn-primary btn-block"">LINE</a>
        </div>
    </div>
    </div>
    <!--
    <h1 class=""displ");
            WriteLiteral(@"ay-4 text-center"">Super Puzzle Slider Turbo</h1>
    <button class=""btn btn-primary btn-lg"">Start!</button>
    <div class=""container"">
        <div class=""row"">
            <div class=""col"">
                <a asp-action=""Index"" asp-controller=""Pictures"" class=""btn btn-primary"">Pictures</a>
            </div>
        </div>
    </div>-->
    <!--
    <p><button class=""btn btn-primary btn-lg"" onclick=""restart()"">Start!</button></p>
    <div id=""overall"">
        <div id=""puzzlearea"">
            <!-- the following are the fifteen puzzle pieces --
            <div>1</div>  <div>2</div>  <div>3</div>  <div>4</div>
            <div>5</div>  <div>6</div>  <div>7</div>  <div>8</div>
            <div>9</div>  <div>10</div> <div>11</div> <div>12</div>
            <div>13</div> <div>14</div> <div>15</div>
        </div>

        <div id=""controls"">
            <button id=""shufflebutton"">Shuffle</button>
        </div>
    </div>-->");
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
