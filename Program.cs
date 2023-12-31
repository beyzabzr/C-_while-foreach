﻿using System;
namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            // 1'den baslayarak konsoldan girilen sayi dahil o sayiya kadar olan ortalama hesaplayip konsola yazdiran program
            Console.WriteLine("Lütfen bir sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);
            Console.WriteLine("*******");

            // a'dan z'ye kadar olan harfler konsola yazdiran program
            char character = 'a';
            while (character < 'z')
            {
                Console.Write(character);
                character++;

            }
            Console.WriteLine("******");
            //Foreach
            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}