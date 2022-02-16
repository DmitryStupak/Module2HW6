namespace Module2HW6
{
    public class ElectricHatchTesla : ElectricHatch, ITesla
    {
        public ElectricHatchTesla(Color color, double cost, double fuelCons)
                : base(Manufacturer.Tesla, color, cost, fuelCons)
        {
        }

        public void WhatIAm()
        {
            Console.WriteLine("I am a Tesla, electric hatchback");
        }
    }
}
