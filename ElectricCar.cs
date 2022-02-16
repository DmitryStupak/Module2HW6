namespace Module2HW6
{
    public class ElectricCar : Car
    {
        public ElectricCar(Manufacturer man, Type type, Color color, double cost, double fuelCons)
            : base(man, FuelType.Electric, type, color, cost, fuelCons)
        {
        }

        public ElectricCar()
        {
        }
    }
}
