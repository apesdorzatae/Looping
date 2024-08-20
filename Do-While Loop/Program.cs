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
        }
    }
}
