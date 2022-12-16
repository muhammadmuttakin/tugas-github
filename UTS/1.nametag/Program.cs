using System;

namespace nametag
{
    class program
    {
        static void Main(string[]args)
        {
            string Nama;
            string NIM;
            string konsentrasi;

            Console.WriteLine("Nama               :");
            Nama = Console.ReadLine();
            Console.WriteLine("NIM                :");
            NIM = Console.ReadLine();
            Console.WriteLine("Konsentrasi        :");
            konsentrasi = Console.ReadLine();



            Console.WriteLine("|********************************|");
            Console.WriteLine("{0,-8} {1,25}", "|Nama:", Nama+"|");
            Console.WriteLine("{0,-16} {1,17}", "|", NIM+"|");
            Console.WriteLine("|--------------------------------|");
            Console.WriteLine("{0,-16} {1,17}", "|", konsentrasi+"|");
            Console.WriteLine("|********************************|");
        }
    }
}
