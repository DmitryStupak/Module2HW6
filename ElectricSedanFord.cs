namespace Module2HW6
{
    public class ElectricSedanFord : ElectricSedan, IFord
    {
        public ElectricSedanFord(Color color, double cost, double fuelCons)
                : base(Manufacturer.Ford, color, cost, fuelCons)
        {
        }

        public void WhatIAm()
        {
            Console.WriteLine("I am a Ford, electric sedan");
        }
    }
}