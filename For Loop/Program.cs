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

            //PULUHAN AJA
            for (int puluhan =  0; puluhan <= 100; puluhan+= 10)
            {
                Console.WriteLine($"Angka {puluhan}"); 
            }

            /*
            //LOOP DI DALAM LOOP 💀
            //⚠CAUTION : SEBAIKNYA JANGAN GEGABAH! JANGAN YA DEK YA!!⚠
            
            for (int a = 1; a <= 3; a++)
            {
                for (int b = 1; b <= 3; b++)
                {
                    for (int c = 1; c <= 3; c++)
                    {
                        for (int d = 1; d <= 3; d++)
                        {
                            for (int e = 1; e <= 3; e++)
                            {
                                for (int f = 1; f <= 3; f++)
                                {
                                    for(int g = 1;  g <= 3; g++)
                                    {
                                        for (int h = 1; h <= 3; h++)
                                        {
                                            for (int i = 1; i <= 3; i++)
                                            {
                                                for (int  j = 1; j <= 3; j++)
                                                {
                                                    for (int k = 1; k <= 3; k++)
                                                    {
                                                        for (int l = 1; l <= 3; l++)
                                                        {
                                                            for (int m = 1; m <= 3; m++)
                                                            {
                                                                for (int n = 1; n <= 3; n++)
                                                                {
                                                                    for (int o = 1; o <= 3; o++)
                                                                    {
                                                                        for (int p = 1; p <= 3; p++)
                                                                        {
                                                                            for (int q = 1; q <= 3; q++)
                                                                            {
                                                                                for (int r = 1; r <= 3; r++)
                                                                                {
                                                                                    for (int s = 1; s <= 3; s++)
                                                                                    {
                                                                                        for (int t = 1; t <= 3; t++)
                                                                                        {
                                                                                            for (int u = 1; u <= 3; u++)
                                                                                            {
                                                                                                for (int v = 1; v <= 3; v++)
                                                                                                {
                                                                                                    for (int w = 1; w <= 3; w++)
                                                                                                    {
                                                                                                        for (int x = 1; x <= 3; x++)
                                                                                                        {
                                                                                                            for (int y = 1; y <= 3; y++)
                                                                                                            {
                                                                                                                for (int z = 1; z <= 3; z++)
                                                                                                                {
                                                                                                                    Console.WriteLine($"{a} | {b} | {c} | {d} | {e} | {f} | {g} | {h} | {i} | {j} | {k} | {l} | {m} | {n} | {o} | {p} | {q} | {r} | {s} | {t} | {u} | {v} | {w} | {x} | {y} | {z}");

                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            } */ //< ini buat ngunci, bahaya kalo dibuka deh

            //IF INSIDE LOOP 
            int jumlahGenap = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    jumlahGenap += i;
                }
            }
            Console.WriteLine($"Jumlah bilangan genap dari 1 hingga 10 adalah: {jumlahGenap}"); 

            //MAINAN PASSWORD
            int salah = 3;
            string password;
            Console.WriteLine("Masukkan password anda untuk membuka HP");
            for (int i = 0;i <= 3; i++)
            {
                password = Console.ReadLine();
                if (password == "123")
                {
                    Console.WriteLine("\nPassword anda benar");
                }
                else
                {
                    Console.WriteLine("Password anda salah");
                    Console.WriteLine($"Percobaan {salah} kali lagi");
                    salah--;
                }
            }
            Console.WriteLine("\nSekarang HP anda sedang terkunci, mohon coba masukkan password 100 menit lagi");


            //TUGAS AKHIR
            Console.WriteLine("Pillih senjata >>>       [Arrow]         |       [Punch]      |      [Sword]     |       [Guns]");
            string a = Console.ReadLine().ToLower();
            int b = 0;
            int c = 0;
            int d = 0;

            if (a == "arrow")
            {
                Console.WriteLine("Hit");
            }
            else if (a == "punch")
            {
                while (b < 2)
                {
                    b++;
                    Console.WriteLine("Hit");
                }
            }
            else if (a == "sword")
            {
                while (c < 3)
                {
                    b++;
                    Console.WriteLine("Hit");
                }
            }
            else if (a == "guns")
            {
                while (d < 4)
                {
                    d++;
                    Console.WriteLine("Hit");
                }
            }
            else { Console.WriteLine("Tidak ada yang seperti input di dalan daftar pilihan senjata"); }
            Console.WriteLine("\n[COMPETED SUCCESFULY]");
        }
    }
}
