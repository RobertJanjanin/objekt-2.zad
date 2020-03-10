using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statickeMetodeRobertJanjanin
{
    class Program
    {
        static void Main(string[] args)
        {
            PrvaKlasa prvi = new PrvaKlasa("Pero", 2003);
            Console.WriteLine(prvi.ToString());
            PrvaKlasa drugi = new PrvaKlasa("Ivica", 2004);
            Console.WriteLine(drugi.ToString());
            PrvaKlasa treci = new PrvaKlasa("Ibro", 2001);
            Console.WriteLine(treci.ToString());
            treci.Ime = "Milorad";
            Console.WriteLine(treci.Ime);
            Console.ReadKey();
        }
    }
}
