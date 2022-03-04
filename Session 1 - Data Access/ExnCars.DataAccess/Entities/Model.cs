namespace ExnCars.DataAccess.Entities
{
    internal class Model
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ModelYear { get; set; } = string.Empty;
        public string FuelType { get; set; } = string.Empty;
        public int EngineDisplacement { get; set; }
        public int BrandID { get; set; }

        public Brand Brand { get; set; }
        public IList<Vehicle> Vehicles { get; set; }
    }
}
