using System;

namespace Module2HW6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TaxiDepot taxiDepot = new TaxiDepot();
            Console.WriteLine("Автопарк до сортировки");
            taxiDepot.GetCars().PrintList();
            Console.WriteLine("Поиск машин от 10000 до 30000 $");
            taxiDepot.GetCars().FindByWeight(10000, 30000).PrintList();
            Console.WriteLine("Сортировка машин по расходу топлива");
            taxiDepot.GetCars().Sort();
            taxiDepot.GetCars().PrintList();
            ((IFord)taxiDepot.GetCars()[0]).WhatIAm();
        }
    }
}