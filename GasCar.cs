namespace Module2HW6
{
    public abstract class GasCar : Car
    {
        public GasCar(Manufacturer man, Type type, Color color, double cost, double fuelCons)
            : base(man, FuelType.Gas, type, color, cost, fuelCons)
        {
        }

        public GasCar()
        {
        }
    }
}
