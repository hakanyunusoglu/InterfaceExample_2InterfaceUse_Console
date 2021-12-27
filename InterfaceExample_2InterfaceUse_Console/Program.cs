using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample_2InterfaceUse_Console
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            List<Araba> aList = new List<Araba>();

            Araba arb = new Araba();
            arb.marka = "Mercedes";
            arb.model = "C180";
            arb.yil = 2019;
            arb.sanziman = "Düz";
            arb.yildiz = 4;
            aList.Add(arb);

            Araba arb1 = new Araba();
            arb1.marka = "BMW";
            arb1.model = "M3";
            arb1.yil = 2021;
            arb1.sanziman = "Otomatik";
            arb1.yildiz = 5;
            aList.Add(arb1);

            foreach(var item in aList)
            {
                Console.WriteLine(item.OzellikOku());
            }
            Console.ReadLine();
            
        }
    }
}
