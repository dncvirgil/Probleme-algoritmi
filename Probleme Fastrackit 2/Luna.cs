using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_Fastrackit_2
{
    class Luna
    {
        public static void AfiseazaLuna(int numar)
        {
            string[] luni = new string[12] {"ianuarie", "februarie", "martie", "aprilie", "mai", "iunie", "iulie", "august", "septembrie", "octombrie", "noiembrie", "decembrie"};
            Console.WriteLine("Luna {0} este: {1}", numar, luni[numar -1]);
        }
    }
}
