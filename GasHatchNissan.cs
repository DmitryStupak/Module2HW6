namespace Module2HW6
{
    public class GasHatchNissan : GasHatch, INissan
    {
        public GasHatchNissan(Color color, double cost, double fuelCons)
                : base(Manufacturer.Nissan, color, cost, fuelCons)
        {
        }

        public void WhatIAm()
        {
            Console.WriteLine("I am a Nissan, gas hatchback");
        }
    }
}