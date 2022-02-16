namespace Module2HW6
{
    public class ElectricSuvHyundai : ElectricSuv, IHyundai
    {
        public ElectricSuvHyundai(Color color, double cost, double fuelCons)
                : base(Manufacturer.Hyundai, color, cost, fuelCons)
        {
        }

        public void WhatIAm()
        {
            Console.WriteLine("I am a Hyundai, electric Suv");
        }
    }
}