using System;

namespace tebaka
{
    class program
    {
        static void Main(string[]args)
        {
            int cekjawaban = 0;
            Random rng = new Random();
            int cek = rng.Next(1,100);
            while (cekjawaban != cek)
            {
                Console.WriteLine("Tebak angka antara 1-100");
                cekjawaban = Convert.ToInt32(Console.ReadLine());
                if (cekjawaban < cek){
                    Console.WriteLine("SALAH, nilai terlalu rendah");
                }else if (cekjawaban > cek){
                    Console.WriteLine("SALAH, nilai terlalu tinggi");
                }else{
                    Console.WriteLine("Anda benar \nBye...");
                    Console.ReadLine();
                }
            }
        }
    }
}
