using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opakovani_motol
{
    class Program
    {
        static void Main(string[] args)
        {
            //kalkulacka
            bool skoncit = false;

            while (skoncit == false)
            {
            
                double vysledek = 0;
                
                Console.WriteLine("zadejte první cislo");
                double cislo1 = double.Parse(Console.ReadLine());
                
                Console.WriteLine("zadejte druhé číslo");
                double cislo2 = double.Parse(Console.ReadLine());

                Console.WriteLine("zadejte operaci");
                string operace = Console.ReadLine();

                if (operace == "+")
                {
                    vysledek = cislo1 + cislo2;
                }
                else if (operace == "-")
                {
                    vysledek = cislo1 - cislo2;
                }
                else if (operace == "*")
                {
                    vysledek = cislo1 * cislo2;
                }
                else if (operace == "/")
                {
                    vysledek = cislo1 / cislo2;
                }
                else if (operace == "%")
                {
                    vysledek = cislo1 % cislo2;
                }
                else
                {
                    Console.WriteLine("Spatna operace");
                    Console.WriteLine("Input error");
                }
                Console.WriteLine("Vysledek = " + vysledek);
                Console.WriteLine("chcete pokračovat? ano/ne");
                string skonceni = Console.ReadLine();
                if (skonceni == "ne")
                {
                    skoncit = true;
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();
                }
                else if (skonceni == "ne")
                {
                    skoncit = false;
                }
            }
        }
    }
}
