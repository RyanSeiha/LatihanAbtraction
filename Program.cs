using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LatihanAbtraction.AbstractClass;
//using LatihanAbtraction.Interface;

namespace LatihanAbtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Makanan makanan;

            makanan = new Bakso();
            makanan.Bahan();

            Console.WriteLine();

            makanan = new MieAyam();
            makanan.Bahan();

            Console.ReadKey();

            /*IMakanan makanan;

            makanan = new Bakso();
            makanan.Bahan();

            Console.WriteLine();

            makanan = new MieAyam();
            makanan.Bahan();

            Console.ReadKey();*/
        }
    }
}
