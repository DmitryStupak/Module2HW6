namespace Module2HW6
{
    public class ElectricHatchFord : ElectricHatch, IFord
    {
        public ElectricHatchFord(Color color, double cost, double fuelCons)
                : base(Manufacturer.Ford, color, cost, fuelCons)
        {
        }

        public void WhatIAm()
        {
            Console.WriteLine("I am a Ford, electric hatchback");
        }
    }
}