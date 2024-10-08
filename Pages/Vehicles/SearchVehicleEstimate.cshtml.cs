using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.Options;
using System.Xml.Linq;
using Telerik.SvgIcons;
using WebApplication2.Models;

namespace WebApplication2.Pages.Vehicles
{
    public class SearchVehicleEstimateModel : PageModel
    {
        public List<Option> Options { get; set; }
        public void OnGet()
        {
            Options = new List<Option>
    {
        new Option { ID = 1, Name = "Option 1" },
        new Option { ID = 2, Name = "Option 2" },
        new Option { ID = 3, Name = "Option 3" }
    };

            

        }
    }
        
       
}
