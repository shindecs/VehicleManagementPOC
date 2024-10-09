using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.Options;
using System.Xml.Linq;
using Telerik.SvgIcons;
using VehicleManagementPOC.Models;
using WebApplication2.Models;

namespace WebApplication2.Pages.Vehicles
{
    public class SearchVehicleEstimateModel : PageModel
    {
        public List<Option> Options { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public void OnGet()
        {
            Options = new List<Option>
            {
                new Option { ID = 1, Name = "Option 1" },
                new Option { ID = 2, Name = "Option 2" },
                new Option { ID = 3, Name = "Option 3" }
            };
            //Create list of dummy vehicle records
            Vehicles = new List<Vehicle>
            {
                new Vehicle { Id = 1, Make = "Toyota", Model = "Camry", Year = "2018", VIN = "1234567890", LicensePlate = "ABC123", Color = "Red", Owner = "John Doe", OwnerPhone = "123-456-7890", OwnerEmail = "" },
                new Vehicle { Id = 2, Make = "Ford", Model = "F150", Year = "2019", VIN = "0987654321", LicensePlate = "XYZ987", Color = "Blue", Owner = "Jane Doe", OwnerPhone = "098-765-4321", OwnerEmail = "" },
                new Vehicle { Id = 3, Make = "Chevrolet", Model = "Silverado", Year = "2020", VIN = "1357924680", LicensePlate = "LMN456", Color = "Black", Owner = "John Smith", OwnerPhone = "135-792-4680", OwnerEmail = "" },
                new Vehicle { Id = 4, Make = "Honda", Model = "Civic", Year = "2017", VIN = "2468013579", LicensePlate = "PQR789", Color = "Green", Owner = "Jane Smith", OwnerPhone = "246-801-3579", OwnerEmail = "" },
                new Vehicle { Id = 5, Make = "Nissan", Model = "Altima", Year = "2016", VIN = "9876543210", LicensePlate = "STU654", Color = "Yellow", Owner = "John Doe", OwnerPhone = "987-654-3210", OwnerEmail = "" },
                new Vehicle { Id = 6, Make = "Toyota", Model = "Corolla", Year = "2015", VIN = "5678901234", LicensePlate = "VWX321", Color = "Orange", Owner = "Jane Doe", OwnerPhone = "567-890-1234", OwnerEmail = "" },
                new Vehicle { Id = 7, Make = "Ford", Model = "Explorer", Year = "2014", VIN = "4321098765", LicensePlate = "YZA987", Color = "Purple", Owner = "John Smith", OwnerPhone = "432-109-8765", OwnerEmail = "" },
                new Vehicle { Id = 8, Make = "Chevrolet", Model = "Tahoe", Year = "2013", VIN = "6789012345", LicensePlate = "BCD654", Color = "Brown", Owner = "Jane Smith", OwnerPhone = "678-901-2345", OwnerEmail = "" },
                new Vehicle { Id = 9, Make = "Honda", Model = "Accord", Year = "2012", VIN = "5432109876", LicensePlate = "EFG321", Color = "White", Owner = "John Doe", OwnerPhone = "543-210-9876", OwnerEmail = "" },
                new Vehicle { Id = 10, Make = "Nissan", Model = "Maxima", Year = "2011", VIN = "7890123456", LicensePlate = "HIJ987", Color = "Silver", Owner = "Jane Doe", OwnerPhone = "789-012-3456", OwnerEmail = "" }

            };
        }
    }
        
       
}
