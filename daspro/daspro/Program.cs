// Hello World! program
using System;

namespace Program
{
    class Program
    {         
        //Main Method
        static void Main(string[] args)
        {
            //Deklarasi Variabel
            int kodeA;
            int kodeB;
            int kodeC;
            int jumlahKode;
            string tebakanA;
            string tebakanB;
            string tebakanC;

            int hasilTambah;
            int hasilKali;

            //Inisialisasi Variabel
            kodeA = 4;
            kodeB = 8;
            kodeC = 16;

            jumlahKode = 3;

            //Operasi Aritmatika
            hasilTambah = kodeA+kodeB+kodeC;
            hasilKali = kodeA*kodeB*kodeC;

            //Intro
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server...");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine("Password terdiri atas "+jumlahKode+" angka");
            Console.WriteLine("Jika ditambahkan hasilnya "+hasilTambah);
            Console.WriteLine("Jika dikalikan hasilnya "+hasilKali);

            //Input user
            Console.Write("Masukkan kode 1 : ");
            tebakanA = Console.ReadLine();
            Console.Write("Masukkan kode 2: ");
            tebakanB = Console.ReadLine();
            Console.Write("Masukkan kode 3: ");
            tebakanC = Console.ReadLine();

            Console.WriteLine("Tebakan Anda : "+tebakanA +"  "+tebakanB+"   "+tebakanC+" ?");

            if(tebakanA == kodeA.ToString() && tebakanB == kodeB.ToString() && tebakanC == kodeC.ToString())
            {
                Console.WriteLine("Tebakan anda benar");
            }else{
                Console.WriteLine("Tebakan anda salah");
            }    
           
        }

    }
}