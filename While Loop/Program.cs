using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //[Percobaan Pertama]===========================================================================================
            int HP = 12;
            while (HP<20)
            {
                Console.WriteLine("[Heal] +1 hp");
                HP++;
                //HP+= angka
            }
            Console.WriteLine("[Succes] Now your hp has reached 20 hp.\n\n");


            //[Versi Input Keyboard]=========================================================================================
            Console.WriteLine("Masukkan hp anda");
            int p = int.Parse(Console.ReadLine());
            if (p > 50)
            {
                Console.Clear();
                Console.WriteLine("Masukkan hp anda");
                Console.WriteLine("hp anda sudah lebih dari 50");
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Masukkan hp anda");
                while (p < 50)
                {
                    p++;
                    Console.WriteLine("+ menambah hp sebanyak 1, sekarang hp anda " + p);
                }
                Console.WriteLine("Sekarang hp anda sudah mencapai 50");
            }

                //[Domba Percobaan #1]=================================================================================================
                Console.WriteLine("Masukkan jumlah domba");
                int D = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Masukkan jumlah domba\n");
                while (D <= 30)
                {
                    Console.WriteLine("Domba ke " + D);
                    D++;
                } 

            //[Domba Percobaan #2]=================================================================================================
            //GANJIL
            int D2 = 0;
            D2++;
            Console.WriteLine($"Domba ke {D2}");
            while (D2 < 10)
            {
                D2+=2;
                Console.WriteLine($"Domba ke {D2}");
            } 

            //GENAP
            int D3 = 0;
            while (D3 < 10)
            {
                D3+=2;
                Console.WriteLine($"Domba ke {D3}");
            }
        }

    }
}
