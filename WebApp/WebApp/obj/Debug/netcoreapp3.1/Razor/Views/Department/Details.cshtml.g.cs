#pragma checksum "C:\Users\450G6\source\repos\EmployeeManagmentNETCORE\WebApp\WebApp\Views\Department\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03540663fb301893b39df3dc5387420b34fcb456"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NetCoreLayout.Pages.Department.Views_Department_Details), @"mvc.1.0.view", @"/Views/Department/Details.cshtml")]
namespace NetCoreLayout.Pages.Department
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03540663fb301893b39df3dc5387420b34fcb456", @"/Views/Department/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1aa539568a269c83f65c83b3fa7d494aade033a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp.Models.Department>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\450G6\source\repos\EmployeeManagmentNETCORE\WebApp\WebApp\Views\Department\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\450G6\source\repos\EmployeeManagmentNETCORE\WebApp\WebApp\Views\Department\Details.cshtml"
  
    var department = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""d-card"">
        <button class=""btn"" style=""position:absolute; margin-top:5vh; left:25%;""
                onclick=""window.location.href='/department'"">
            <bold>&larr;</bold>
        </button>
        <img src=""https://cdn.pixabay.com/photo/2015/05/15/14/22/conference-room-768441_1280.jpg"" alt=""Avatar"" style=""width:100%; height:50vh;"">
        <div class=""d-container"">
            <p style=""text-align:center; color:white; background-color: #26a69a;margin-top:-4.5%; margin-left: 25%;margin-right:25%; padding:5px 5px;""><strong>DepartmentID:  ");
#nullable restore
#line 15 "C:\Users\450G6\source\repos\EmployeeManagmentNETCORE\WebApp\WebApp\Views\Department\Details.cshtml"
                                                                                                                                                                         Write(department.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n            \r\n            <p style=\"margin:10px 0;\"><strong>Department name:</strong> ");
#nullable restore
#line 17 "C:\Users\450G6\source\repos\EmployeeManagmentNETCORE\WebApp\WebApp\Views\Department\Details.cshtml"
                                                                   Write(department.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            \r\n            <p style=\"margin:10px 0;\"><strong>Department group name:</strong> ");
#nullable restore
#line 19 "C:\Users\450G6\source\repos\EmployeeManagmentNETCORE\WebApp\WebApp\Views\Department\Details.cshtml"
                                                                         Write(department.GroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            
            <p style=""margin:10px 0;""><strong>Description:</strong>
            Donec finibus sollicitudin risus, vitae placerat dui pulvinar nec. Vestibulum finibus ipsum vel felis placerat aliquet. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nullam ipsum nisi, dignissim id ligula at, fermentum vestibulum quam. Praesent dolor dolor, rhoncus non semper in, rutrum sit amet urna. Sed sollicitudin nisl vel leo vehicula, sed malesuada est mattis. Proin rutrum risus a nibh cursus, quis mollis tortor lacinia. Aliquam lorem purus, consequat pulvinar metus ut, sollicitudin vulputate nisi. Nunc cursus, mi id venenatis feugiat, eros ante ultricies quam, a interdum mi ligula a augue. Curabitur non magna vel neque feugiat tincidunt non ut lacus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Donec sit amet porta sapien, vel tempor ante. Praesent rutrum condimentum purus, sagittis tempor tortor posuere sit amet. A");
            WriteLiteral("liquam facilisis mi eros, in tristique eros faucibus in.</p>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Models.Department> Html { get; private set; }
    }
}
#pragma warning restore 1591
