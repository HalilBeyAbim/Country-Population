using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkTotalPopulation05._12._22
{
     class Country
    {
     
        string Azerbaijan = "Azerbaijan";
        int TotalPopulationAz = 10000000;
        string Ukraine = "Ukraine";
        int TotalPopulationUa = 12000000;
        public virtual void Getinfo()
        {
            Console.WriteLine($"Name: {Ukraine} ");
            Console.WriteLine($"Total Population: {TotalPopulationUa}");
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Name: {Azerbaijan} ");
            Console.WriteLine($"Total Population: {TotalPopulationAz}");
        }
    }
}
