﻿namespace Module2HW6
{
    public class GasSedan : GasCar, IGasCar
    {
        public GasSedan(Manufacturer man, Color color, double cost, double fuelCons)
            : base(man, Type.Sedan, color, cost, fuelCons)
        {
        }

        public GasSedan()
        {
        }

        public IFord GetFord()
        {
            return new GasSedanFord(Color.Blue, 28000, 7);
        }

        public IHyundai GetHyundai()
        {
            return new GasSedanHyundai(Color.Green, 26000, 9);
        }

        public INissan GetNissan()
        {
            return new GasSedanNissan(Color.Red, 27000, 5);
        }
    }
}
