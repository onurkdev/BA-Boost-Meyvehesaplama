using System;
using System.Collections.Generic;
using System.Linq;

namespace BABoostMeyvehesaplama
{
    class Meyve
    {
        public string tip;
        public double fiyat;
    }
    class MainClass
    {
        public static void Main(string[] args)

        {
            var Meyveler = new List<Meyve>()
            {
                new Meyve(){tip = "Elma", fiyat=5},
                new Meyve(){tip = "Armut", fiyat=10},
                new Meyve(){tip = "Çilek", fiyat=15},
                new Meyve(){tip = "Üzüm", fiyat=7.5},
                new Meyve(){tip = "Muz", fiyat=20},

            };

            Console.WriteLine("Lütfen hangi meyveyi istediğinizi numarası ile belirtiniz");
            foreach (Meyve meyve in Meyveler) {
                Console.WriteLine($"{Meyveler.IndexOf(meyve)} - {meyve.tip} => {meyve.fiyat} TL/KG");
            }
            int selectedIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen kaç kg istediğinizi belirtiniz");
            int weight = Convert.ToInt32(Console.ReadLine());

            double sum = (Meyveler[selectedIndex].fiyat) * weight;

            Console.WriteLine($"{weight} kg {Meyveler[selectedIndex].tip} {sum} - TL");
            Console.ReadKey();


        }
    }
    
}
