#pragma checksum "C:\Users\prith\source\repos\BlazorApplication\BlazorServer\Pages\Calender.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69d01aec240613b0d120a9cec450f09714c8823e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\prith\source\repos\BlazorApplication\BlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\prith\source\repos\BlazorApplication\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\prith\source\repos\BlazorApplication\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\prith\source\repos\BlazorApplication\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\prith\source\repos\BlazorApplication\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\prith\source\repos\BlazorApplication\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\prith\source\repos\BlazorApplication\BlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\prith\source\repos\BlazorApplication\BlazorServer\_Imports.razor"
using BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\prith\source\repos\BlazorApplication\BlazorServer\_Imports.razor"
using BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\prith\source\repos\BlazorApplication\BlazorServer\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/calender")]
    public partial class Calender : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<DevExpress.Blazor.DxCalendar>(0);
            __builder.AddAttribute(1, "EnableMultiSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 2 "C:\Users\prith\source\repos\BlazorApplication\BlazorServer\Pages\Calender.razor"
                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "SelectedDatesChanged", new System.Action<System.Collections.Generic.IEnumerable<System.DateTime>>(
#nullable restore
#line 3 "C:\Users\prith\source\repos\BlazorApplication\BlazorServer\Pages\Calender.razor"
                                  OnSelectedDatesChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "SelectedDates", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.DateTime>>(
#nullable restore
#line 4 "C:\Users\prith\source\repos\BlazorApplication\BlazorServer\Pages\Calender.razor"
                            SelectedDates

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n");
#nullable restore
#line 7 "C:\Users\prith\source\repos\BlazorApplication\BlazorServer\Pages\Calender.razor"
 foreach (DateTime date in SelectedDates)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "p");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddContent(8, 
#nullable restore
#line 10 "C:\Users\prith\source\repos\BlazorApplication\BlazorServer\Pages\Calender.razor"
         date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 12 "C:\Users\prith\source\repos\BlazorApplication\BlazorServer\Pages\Calender.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\prith\source\repos\BlazorApplication\BlazorServer\Pages\Calender.razor"
      
    List<DateTime> SelectedDates = new List<DateTime>();

    void OnSelectedDatesChanged(IEnumerable<DateTime> selectedDates)
    {
        SelectedDates = selectedDates.ToList();
        InvokeAsync(StateHasChanged);
   
    
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
