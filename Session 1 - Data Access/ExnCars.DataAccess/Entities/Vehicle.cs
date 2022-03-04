namespace ExnCars.DataAccess.Entities
{
    internal class Vehicle
    {
        public int ID { get; set; }
        public string VIN { get; set; } = string.Empty;
        public string RegistrationNumber { get; set; } = string.Empty;
        public DateTime RegistrationDate { get; set; }
        public DateTime InspectionValidUntil { get; set; }
        public string? ExteriorColor { get; set; }
        public string? InteriorColor { get; set; }
        public int ModelID { get; set; }

        public Model Model { get; set; }
        public IList<User> Users { get; set; } = new List<User>();
    }
}
