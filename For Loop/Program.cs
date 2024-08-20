using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Bilangan ke {i}");
            } 

            //BILANGAN GENAP
            for (int genap = 0; genap <= 10;  genap+= 2)
            {
                Console.WriteLine($"Angka {genap}");
            }
        }
    }
}
