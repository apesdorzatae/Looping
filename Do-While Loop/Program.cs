using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Percobaan Pertama 
            int a = 10;

            do
            {
                Console.WriteLine("Countdown : " + a);
                a--;
            } while (a > -1);

            //Domba Percobaan
            //GANJIL 
            int d1 = 1;
            do
            {
                Console.WriteLine($"Domba ke {d1}");
                d1 += 2;

            }while (d1 <10);

            //GENAP
            int d2 = 0;
            do
            {
                Console.WriteLine($"Domba ke {d2}");
                d2 += 2;

            } while (d2 < 10);
            //aman bosku
        }
    }
}
