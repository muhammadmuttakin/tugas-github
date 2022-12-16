using System;

namespace menghitungdenda
{
    class program
    {
        static void Main(string[]args)
        {
            int inputhari = 0;
            int totaldenda = 0;

            Console.WriteLine("Masukkan jumlah hari peminjaman buku: ");
            inputhari = Convert.ToInt32(Console.ReadLine());
            if (inputhari > 30)
            {
                totaldenda = (inputhari - 30) * 300000 + 500000 + 400000;
                Console.WriteLine("Denda:Rp." + totaldenda);
                Console.WriteLine("Keanggotaan dibatalkan");
            }
            else if (inputhari > 10)
            {
                totaldenda = (inputhari - 10) * 200000 + 500000;
                Console.WriteLine("Denda:Rp." + totaldenda);
            }
            else if (inputhari > 5)
            {
                totaldenda = inputhari*100000;
                Console.WriteLine("Denda:Rp." + totaldenda);
            }
            else
            {
                Console.WriteLine("Tidak ada denda");
            }
            Console.ReadKey();
        }
    }
}

