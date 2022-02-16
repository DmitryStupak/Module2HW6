namespace Module2HW6
{
    public class ElectricSedanNissan : ElectricSedan, INissan
    {
        public ElectricSedanNissan(Color color, double cost, double fuelCons)
                : base(Manufacturer.Nissan, color, cost, fuelCons)
        {
        }

        public void WhatIAm()
        {
            Console.WriteLine("I am a Nissan, electric sedan");
        }
    }
}
