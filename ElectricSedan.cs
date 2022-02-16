namespace Module2HW6
{
    public class ElectricSedan : ElectricCar, IElectricCar
    {
        public ElectricSedan(Manufacturer man, Color color, double cost, double fuelCons)
                : base(man, Type.Sedan, color, cost, fuelCons)
        {
        }

        public ElectricSedan()
        {
        }

        public IFord GetFord()
        {
            return new ElectricSedanFord(Color.Blue, 27000, 0);
        }

        public IHyundai GetHyundai()
        {
            return new ElectricSedanHyundai(Color.Red, 24000, 0);
        }

        public INissan GetNissan()
        {
            return new ElectricSedanNissan(Color.Green, 23000, 0);
        }

        public ITesla GetTesla()
        {
            return new ElectricSedanTesla(Color.Blue, 47000, 0);
        }
    }
}
