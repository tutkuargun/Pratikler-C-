﻿using System;

namespace enumlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik = 32;
            if (sicaklik <=(int)HavaDurumu.Normal)
                Console.WriteLine("Hava soğuk!");
            else if(sicaklik >= (int)HavaDurumu.Sicak)
                Console.WriteLine("Hava çok sıcak!");
            else if(sicaklik >= (int)HavaDurumu.Normal && sicaklik <=(int)HavaDurumu.CokSicak)
                 Console.WriteLine("hadi dışarı çıkalım!"); 
        }
    }
    enum Gunler
    {
        Pazartesi ,
        Salı ,
        Çarşamba,
        Perşembe,
        Cuma = 24,
        Cumartesi,
        Pazar

    }
    enum HavaDurumu
    {
        Soguk =5,
        Normal = 20,
        Sicak = 25,
        CokSicak =30
    }
}
