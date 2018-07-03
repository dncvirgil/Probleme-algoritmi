using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_Fastrackit_2
{
    class Timp
    {
        private int ora;
        private int minut;


        public static Timp CitesteOra()
        {
            Timp timpCitit = new Timp();



            Console.Write("Introduceti ora: ");
            int ora;
            bool esteOra = Int32.TryParse(Console.ReadLine(), out ora);
            if (esteOra)
            {
                timpCitit.ora = ora;
            }
            else
            {
                Console.WriteLine("Eroare! Trebuie sa introduceti o valoare numerica!");
            }



            Console.Write("Introduceti minutul: ");
            int minut;
            bool esteMinut = Int32.TryParse(Console.ReadLine(), out minut);
            if (esteMinut)
            {
                timpCitit.minut = minut;
            }
            else
            {
                Console.WriteLine("Eroare! Trebuie sa introduceti o valoare numerica!");
            }



            return timpCitit;
        }

        public static bool ValideazaTimp(Timp timpCitit)
        {
            if (timpCitit.ora > 0 && timpCitit.ora <= 12 &&
                timpCitit.minut >= 0 && timpCitit.minut < 60)
            {
                return true;
            }
            return false;
        }

        private static string TraduceOra(int ora)
        {
            switch (ora)
            {
                case 1: return "unu";
                case 2: return "doua";
                case 3: return "trei";
                case 4: return "patru";
                case 5: return "cinci";
                case 6: return "sase";
                case 7: return "sapte";
                case 8: return "opt";
                case 9: return "noua";
                case 10: return "zece";
                case 11: return "unsprezece";
                case 12: return "doisprezece";
                case 14: return "paisprezece";
                case 16: return "saisprezece";
                default: return "Ora trebuie sa fie intre 1 si 12";
            }
        }

        private static string TraduceMinut(int minut)
        {
            while (minut <= 11 || minut == 12 || minut == 14 || minut == 16)
            {
                return TraduceOra(minut);
            }
            while (minut < 20 && minut > 12 && minut != 14 && minut != 16) // 
            {
                int zecime = minut % 10;

                return TraduceMinut(zecime) + "sprezece";
            }

            while (minut <= 60 && minut >= 20)
            {
                if (minut % 10 == 0)
                {
                    return TraduceMinut(minut / 10) + " zeci";
                }
                else
                {
                    return TraduceMinut((minut / 10) * 10) + " " + "si" + " " + TraduceMinut(minut % 10);
                }
            }
            return "eroare";
        }

        public static string TiparesteOra(Timp timpCitit)
        {
            if (timpCitit.minut > 0 && timpCitit.minut < 30 && timpCitit.minut != 15)
            {
                return $"{TraduceMinut(timpCitit.minut)} minute dupa ora {TraduceOra(timpCitit.ora)}";
            }
            else if (timpCitit.minut == 0)
            {
                return $"{TraduceOra(timpCitit.ora)} fix";
            }
            else if (timpCitit.minut == 30)
            {
                return $"{TraduceOra(timpCitit.ora)} si jumatate";
            }
            else if (timpCitit.minut == 15)
            {
                return $"{TraduceOra(timpCitit.ora)} si un sfert";
            }
            else if (timpCitit.minut == 45 && timpCitit.ora < 12)
            {
                return $"{TraduceOra(timpCitit.ora + 1)} fara un sfert";
            }
            else if (timpCitit.minut == 45 && timpCitit.ora == 12)
            {
                timpCitit.ora = 1;
                return $"{TraduceOra(timpCitit.ora)} fara un sfert";
            }
            else if (timpCitit.ora == 12)
            {
                timpCitit.ora = 1;
                return $"{TraduceOra(timpCitit.ora)} fara {TraduceMinut(60 - timpCitit.minut)} minute";
            }
            else
            {
                return $"{TraduceOra(timpCitit.ora + 1)} fara {TraduceMinut(60 - timpCitit.minut)} minute";
            }
        }
    }
}
