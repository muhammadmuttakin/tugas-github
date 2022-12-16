using System;
using System.Collections.Generic;

namespace tebakkata
{
    class Program
    {
        static string kataRahasia = "how to train your dragon";
        static int kesempatan = 5;
        static List<string> tebakanpemain = new List<string>{};
        static void Main(string[] args)
        {
            intro();
            Mulaimain();
            Endgame();
        }
        static void intro()
        {
            Console.WriteLine("Selamat datang,hari ini kita akan bermain tebak kata...");
            Console.WriteLine($"kamu mempunyai {kesempatan} kesempatan untuk menebak kata misteri hari ini");
            Console.WriteLine("Petunjuknya adalah kata ini merupakan nama film animasi");
            Console.WriteLine($"kata ini terdiri dari {kataRahasia.Length}");
            Console.WriteLine("Film apakah yang dimaksud");
            Console.ReadKey();
            Console.WriteLine();
        }

        static void Mulaimain()
        {
            while (kesempatan > 0)
            {
                Console.Write("Apa karakter tebakanmu?(a-z)");
                string input = Console.ReadLine();
                tebakanpemain.Add(input);

                if(cekJawaban(kataRahasia,tebakanpemain))
                {
                    Console.WriteLine("Selamat Anda Berhasil");
                    Console.WriteLine($"Kata Rahasia hari ini adalah {kataRahasia}");
                    break;
                }else if(kataRahasia.Contains(input))
                {
                    Console.WriteLine("Huruf itu ada di dalam kata ini");
                    Console.WriteLine("Silahkan tebak huruf lainnya");
                    Console.WriteLine(CekHuruf(kataRahasia,tebakanpemain));
                }else
                {
                    Console.WriteLine("Huruf itu tidak ada dalam kata ini");
                        kesempatan--;
                    Console.WriteLine($"kesempatan anda tinggal {kesempatan}");
                }
            }
        }
        static bool cekJawaban(string kataRahasia, List<string>list)
        {
            bool status = false; 
            for (int i = 0;i < kataRahasia.Length; i++)
            {
                string c = Convert.ToString(kataRahasia[i]);
                if(list.Contains(c))
                {
                    status = true;
                }
                else
                {
                    return status = false;
                }
            }
            return status;
        }
        static string CekHuruf(string kataRahasia, List<string>list)
        {
            string x = "";
            for (int i = 0; i < kataRahasia.Length; i++)
            {
                string c = Convert.ToString(kataRahasia[i]);
                if (list.Contains(c))
                {
                  x = x + c;
                } else {
                  x = x + ".";
                }
            }
            return x;
        }
        static void Endgame()
        {
            Console.WriteLine("Finish");
            Console.WriteLine($"Jawabannya {kataRahasia}");
        }
    }
}
    





