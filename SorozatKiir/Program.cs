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
            int szam;
            do
            {
                Console.Write("Kérem, adjon meg egy egynél nagyobb számot: ");
                szam = Convert.ToInt32(Console.ReadLine());
                if (szam <=0)
                {
                    Console.WriteLine("Hibás adat!");
                }
            } while (szam <= 0);

            for (int i = 0; i < szam; i++)
            {
                Console.WriteLine(i+1);
            }

            Console.ReadKey();
        }
    }
}
