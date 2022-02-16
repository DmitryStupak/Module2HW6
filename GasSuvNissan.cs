namespace Module2HW6
{
    public class GasSuvNissan : GasSuv, INissan
    {
        public GasSuvNissan(Color color, double cost, double fuelCons)
                : base(Manufacturer.Nissan, color, cost, fuelCons)
        {
        }

        public void WhatIAm()
        {
            Console.WriteLine("I am a Nissan, gas Suv");
        }
    }
}