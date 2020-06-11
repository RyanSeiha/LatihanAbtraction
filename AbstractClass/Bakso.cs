using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanAbtraction.AbstractClass
{
    public class Bakso : Makanan
    {
        public override void Bahan()
        {
            Console.WriteLine("Bahab Pembuatan Bakso : ");
            Console.WriteLine("1. Tepung Tapioka");
            Console.WriteLine("2. Daging Sapi/Ayam/Ikan");
            Console.WriteLine("3. Telur");
        }
    }
}
