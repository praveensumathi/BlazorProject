#pragma checksum "C:\ProjectBlazor\BlazorApp1\BlazorApp1\Pages\Employee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10af672b2f689d662efa8ed035a322955ba236b4"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ProjectBlazor\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProjectBlazor\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProjectBlazor\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProjectBlazor\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ProjectBlazor\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ProjectBlazor\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ProjectBlazor\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ProjectBlazor\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ProjectBlazor\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProjectBlazor\BlazorApp1\BlazorApp1\Pages\Employee.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employee")]
    public partial class Employee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(0);
            __builder.AddAttribute(1, "class", "nav-link");
            __builder.AddAttribute(2, "href", "AddEmployee");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.AddMarkupContent(5, "<span class=\"oi oi-plus btn btn-secondary\" aria-hidden=\"true\"> Add user</span>\r\n    <hr>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
#nullable restore
#line 10 "C:\ProjectBlazor\BlazorApp1\BlazorApp1\Pages\Employee.razor"
 if(newEmp == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.AddMarkupContent(8, "<p>No Data</p>\r\n");
#nullable restore
#line 13 "C:\ProjectBlazor\BlazorApp1\BlazorApp1\Pages\Employee.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.OpenElement(10, "table");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.AddMarkupContent(12, "<thead>\r\n            <tr>\r\n                <td><b>UserName</b></td>\r\n                <td><b>FirstName</b></td>\r\n                <td><b>Email</b></td>\r\n                <td><b>Status</b></td>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(13, "tbody");
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 26 "C:\ProjectBlazor\BlazorApp1\BlazorApp1\Pages\Employee.razor"
             foreach(var emp in newEmp)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "                ");
            __builder.OpenElement(16, "tr");
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 29 "C:\ProjectBlazor\BlazorApp1\BlazorApp1\Pages\Employee.razor"
                         emp.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 30 "C:\ProjectBlazor\BlazorApp1\BlazorApp1\Pages\Employee.razor"
                         emp.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 31 "C:\ProjectBlazor\BlazorApp1\BlazorApp1\Pages\Employee.razor"
                         emp.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 32 "C:\ProjectBlazor\BlazorApp1\BlazorApp1\Pages\Employee.razor"
                         newEmployee.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 34 "C:\ProjectBlazor\BlazorApp1\BlazorApp1\Pages\Employee.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 37 "C:\ProjectBlazor\BlazorApp1\BlazorApp1\Pages\Employee.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\ProjectBlazor\BlazorApp1\BlazorApp1\Pages\Employee.razor"
       
    List<EmployeeDetails> newEmp;
    protected override async Task OnInitializedAsync()
    {
        newEmp = await Task.Run(() => newEmployee.GetEmployee());
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService newEmployee { get; set; }
    }
}
#pragma warning restore 1591
