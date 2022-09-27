using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apka_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int cislo1 = int.Parse(Console.ReadLine());
            int cislo2 = int.Parse(Console.ReadLine());
            string operace = Console.ReadLine();
            double vysledek = 0;
            bool spatnaoperace = false;

            if (operace == "+")
            {
                vysledek = cislo1 + cislo2;
                spatnaoperace = true;
            }


            if (operace == "-")
            {
                vysledek = cislo1 - cislo2;
                spatnaoperace = true;
            }

            if (operace == "/")
            {
                vysledek = cislo1 / cislo2;
                spatnaoperace = true;
            }

            if (operace == "*")
            {
                vysledek = cislo1 * cislo2;
                spatnaoperace = true;
            }

            if (operace == "%")

            {
                vysledek = cislo1 % cislo2;
                spatnaoperace = true;
            }
            

            else
            {
                Console.WriteLine("Spatna operace");
            }

            if (spatnaoperace)
            {
                Console.WriteLine("vysledek:" + vysledek);
                
            }

            Console.ReadKey();  

        }
       
    }
}
