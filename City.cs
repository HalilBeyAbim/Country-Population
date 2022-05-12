using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkTotalPopulation05._12._22
{
    class City : Country
    {
        string NameCity = "Yevlakh";
        int Population = 80000;
        string nameCity = "Kyiv";
        int population = 1000000;
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Name City: {NameCity} ");
            Console.WriteLine($"Population: {Population} ");
        }
        public override void Getinfo()
        {
            base.Getinfo();
            Console.WriteLine($"Name City: {nameCity} ");
            Console.WriteLine($"Population: {population} ");
        }
    }

}
