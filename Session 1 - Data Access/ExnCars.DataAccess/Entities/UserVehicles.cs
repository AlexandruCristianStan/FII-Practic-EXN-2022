namespace ExnCars.DataAccess.Entities
{
    internal class UserVehicles
    {
        public int UserID { get; set; }
        public User User { get; set; }
        public int VehicleID { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}