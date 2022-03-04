namespace ExnCars.DataAccess.Entities
{
    internal class DriverLicense
    {
        public int ID { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string? Categories { get; set; }
        public int UserID { get; set; }

        public User User { get; set; }
    }
}
