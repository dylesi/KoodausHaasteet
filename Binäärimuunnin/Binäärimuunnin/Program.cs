using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binäärimuunnin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("__Binäärimuunnin__");
            Console.WriteLine("------------------");
            Console.WriteLine("Vaihtoehdot:");
            Console.WriteLine("binääriksi | desimaaliksi");
            string valinta = Console.ReadLine();

            if (valinta == "binääriksi")
            {
                Console.WriteLine("Syötä numero(t)");
                double numero = Convert.ToDouble(Console.ReadLine());
                binääriksi(numero);
            }
            else if (valinta == "desimaaliksi")
            {
                Console.WriteLine("Syötä binääriluku");
                string binääri = Console.ReadLine();
                desimaaliksi(binääri);
            }
            Console.ReadLine();
        }

        static void binääriksi(double uusi_numero )
        {
            // seitsemän == 111
            Console.WriteLine("test");
            double luku = uusi_numero;
            int nolla = 0;
            int yksi = 1;

        }

        static void desimaaliksi(string numero)
        {
            Console.WriteLine("test2");
        }

    }
}
