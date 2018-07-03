using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_Fastrackit_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problema 1
            Console.Write("Ce luna doriti sa afisati?: ");
            int luna = Convert.ToInt32(Console.ReadLine());
            Luna.AfiseazaLuna(luna);


            //Problema Algoritmi
            Console.WriteLine("Problema ALGORITMI");

            int ctrl = 0;
            Timp timp = new Timp();

            for (int i = 0; i < 3; i++)
            {
                timp = Timp.CitesteOra();
                if (Timp.ValideazaTimp(timp) == false)
                {
                    ctrl++;
                    if (ctrl == 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Mai incearca o data!");
                    }
                }
                else
                {
                    break;
                }
            }
            if (ctrl == 3)
            {
                Console.WriteLine("Ati incercat de 3 ori!!!!!!");
            }
            else
            {
                Console.WriteLine($"Ora introdusa este: {Timp.TiparesteOra(timp).ToUpper()} ");
            }
        }
    }
}
