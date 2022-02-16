using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorozatKiir
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. feladat

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i+1);


            //}

            // 3. feladat
            // 4. feladat
            int elsoSzam;
            int masodikSzam;
            int min;
            int max;

            do
            {
                Console.Write("Kérem, adjon meg egy nullánál nagyobb számot: ");
                elsoSzam = Convert.ToInt32(Console.ReadLine());
                if (elsoSzam <=0)
                {
                    Console.WriteLine("Hibás adat!");
                }
            } while (elsoSzam <= 0);


            do
            {
                Console.Write("Kérem, adjon meg egy másik, nullánál nagyobb számot: ");
                masodikSzam = Convert.ToInt32(Console.ReadLine());
                if (masodikSzam <=0)
                {
                    Console.WriteLine("Hibás adat!");
                }
            } while (masodikSzam <= 0 || elsoSzam == masodikSzam);

            if (elsoSzam > masodikSzam)
            {
                min = masodikSzam;
                max = elsoSzam;
            }
            else
            {
                min = elsoSzam;
                max = masodikSzam;
            }

            for (int i = min-1; i < max; i++)
            {
                Console.WriteLine(i+1);
            }

            Console.ReadKey();
        }
    }
}
