﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanAbtraction.Interface
{
    public class MieAyam : IMakanan
    {
        public void Bahan()
        {
            Console.WriteLine("Bahab Pembuatan Mie Ayam : ");
            Console.WriteLine("1. Tepung Terigu");
            Console.WriteLine("2. Daging Ayam");
            Console.WriteLine("3. Sayuram Kubis/Bayam/Cesin");
        }
    }
}
