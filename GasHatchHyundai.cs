namespace Module2HW6
{
    public class GasHatchHyundai : GasHatch, IHyundai
    {
        public GasHatchHyundai(Color color, double cost, double fuelCons)
                : base(Manufacturer.Hyundai, color, cost, fuelCons)
        {
        }

        public void WhatIAm()
        {
            Console.WriteLine("I am a Hyundai, gas hatchback");
        }
    }
}
