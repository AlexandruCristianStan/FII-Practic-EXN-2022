namespace ExnCars.DataAccess.Entities
{
    internal class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Email { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Avatar { get; set; }

        public DriverLicense DriverLicense { get; set; }
        public IList<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    }
}
