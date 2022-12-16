using System;

namespace gamedadu
{
    class program
    {
        /*
        Nama :Muhammad Muttakin
        NIM  :2207125094
        Kelas:Teknik Informatika-A
        Matkul:Dasar Pemprograman
        */
        static void Main(string[]args) 
        {
            intro();
            isi();
        }
        static void intro()
        {
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("GAME ADU DADU ANDA VS KOMPUTER\n");
            Console.WriteLine("Selamat datang dalam permainan Adu Dadu");
            Console.WriteLine("Pada permainan Adu Dadu ini anda akan berlawanan dengan komputer");
            Console.WriteLine("Permainan ini terdiri dari 10 ronde");
            Console.WriteLine("Setiap putaran dadu yang dilempar oleh anda dan komputer akan menghasilkan nilai tertentu");
            Console.WriteLine("Nilai dadu tertinggi akan menjadi pemenang ronde tersebut");
            Console.WriteLine("\nMulai main...");
            

        }
        static void isi()
        {
            int angkaDadukomputer;
            int angkaDaduanda;
            int Ronde = 0;
            int komputerPoint = 0;
            int andaPoint = 0;
            Random satu = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tekan tombol apa saja untuk memulai permainan...");
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.ReadKey();

                Ronde++;
                angkaDadukomputer = satu.Next(1,7);
                angkaDaduanda = satu.Next(1,7);
                Console.WriteLine("Ronde " + Ronde);
                Console.WriteLine("Komputer melempar dadu dan mendapatkan angka " +angkaDadukomputer + ".");
                Console.ReadKey();
                Console.WriteLine("anda melempar dadu dan mendapatkan angka " +angkaDaduanda + ".");


                if(angkaDadukomputer > angkaDaduanda)
                {
                    komputerPoint++;
                    Console.WriteLine("\nkomputer memenangkan ronde " + Ronde + "!\n");
                }
                else if(angkaDadukomputer < angkaDaduanda)
                {
                    andaPoint++;
                    Console.WriteLine("\nanda memenangkan ronde " + Ronde + "!\n");
                }
                else
                {
                    Console.WriteLine("\nRonde " + Ronde + " berakhir seri!\n");
                }
                Console.WriteLine("Point anda: " + andaPoint + " dan Point Komputer: "+ komputerPoint);
                Console.ReadKey();
            }
            if (komputerPoint > andaPoint)
            {
                Console.WriteLine("\n----------------------------------------------");
                Console.WriteLine("Selamat, komputer memenangkan permainan Adu Dadu");
                Console.WriteLine("----------------------------------------------\n");
            }
            else if (komputerPoint < andaPoint )
            {
                Console.WriteLine("\n-------------------------------------------");
                Console.WriteLine("Selamat,  anda memenangkan permainan Adu Dadu");
                Console.WriteLine("-------------------------------------------\n");
            }
            else
            {
                Console.WriteLine("\n-------------------------------------------");
                Console.WriteLine("Permainan Adu Dadu berakhir seri");
                Console.WriteLine("---------------------------------------------");
            }
            Console.ReadKey();
            
        }

    }
}
