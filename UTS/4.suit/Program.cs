using System;

namespace suit
{
    class program
    {
        static void Main(string[]args)
        {
            int nilaiMenang = 0;
            int nilaiKalah = 0;
            int nilaiSeri = 0;
            char userInput = ' ';
            Random rng = new Random();

            while (userInput != 'e')
            {
                Console.Write("Pilih (b/g/k/e) :");
                userInput = Convert.ToChar(Console.ReadLine());

                if (userInput == 'e')
                {
                    Console.WriteLine("Selamat Tinggal...");
                    break;
                }
                int kom = rng.Next(1, 4);
                if (userInput == 'b')
                {
                    if (kom == 1)
                    {
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Hasil seri!");
                        nilaiSeri++;
                    }
                    else if (kom == 2 )
                    {
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Anda menang!");
                        nilaiMenang++;
                    }
                    else if (kom == 3)
                    {
                        Console.WriteLine("Komputer memilih kertas");
                        Console.WriteLine("Anda menang!");
                        nilaiKalah++;
                    }
                }
                else if (userInput == 'g')
                {
                    if (kom == 1)
                    {
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Anda kalah!");
                        nilaiKalah++;
                    }
                    else if (kom == 2 )
                    {
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Hasil seri!");
                        nilaiSeri++;
                    }
                    else if (kom == 3)
                    {
                        Console.WriteLine("Komputer memilih kertas");
                        Console.WriteLine("Anda kalah!");
                        nilaiMenang++;
                    }
                }
                else if (userInput == 'k')
                {
                    if (kom == 1)
                    {
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Anda menang!");
                        nilaiMenang++;
                    }
                    else if (kom == 2 )
                    {
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Anda kalah!");
                        nilaiKalah++;
                    }
                    else if (kom == 3)
                    {
                        Console.WriteLine("Komputer memilih kertas");
                        Console.WriteLine("Hasil seri!");
                        nilaiSeri++;
                    }
                }
                Console.WriteLine("Skor kamu : {0} - {1} - {2}", nilaiMenang, nilaiSeri, nilaiKalah);
                Console.WriteLine("Tekan apa saja untuk melanjutkan...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

