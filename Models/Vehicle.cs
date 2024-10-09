namespace VehicleManagementPOC.Models
{
	public class Vehicle
	{
		public int Id { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public string Year { get; set; }
		public string VIN { get; set; }
		public string LicensePlate { get; set; }
		public string Color { get; set; }
		public string Owner { get; set; }
		public string OwnerPhone { get; set; }
		public string OwnerEmail { get; set; }
		public string Notes { get; set; }
		public string Image { get; set; }
		public string CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public string ModifiedBy { get; set; }
		public DateTime ModifiedDate { get; set; }
	}
}
