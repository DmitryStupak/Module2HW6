﻿namespace Module2HW6
{
    public class GasSuvHyundai : GasSuv, IHyundai
    {
        public GasSuvHyundai(Color color, double cost, double fuelCons)
                : base(Manufacturer.Hyundai, color, cost, fuelCons)
        {
        }

        public void WhatIAm()
        {
            Console.WriteLine("I am a Hyundai, gas Suv");
        }
    }
}