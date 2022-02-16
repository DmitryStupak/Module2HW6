namespace Module2HW6
{
    public class GasSuvFord : GasSuv, IFord
    {
        public GasSuvFord(Color color, double cost, double fuelCons)
                : base(Manufacturer.Ford, color, cost, fuelCons)
        {
        }

        public void WhatIAm()
        {
            Console.WriteLine("I am a Ford, gas Suv");
        }
    }
}
