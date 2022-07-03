using System;
using System.Collections;

namespace EnglishTurkishDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string soru = string.Empty;
            Hashtable dizi = new Hashtable();
            do
            {
                Console.Clear();
                Console.Write("Eklemek İstediğiniz İngilizce Kelimeyi Giriniz: ");
                string ing = Console.ReadLine();
                bool kontrol = dizi.Contains(ing);
                if (kontrol == true)
                {
                    Console.WriteLine("Eklemek İstediğiniz Değer {0} sözlük içerisinde bulunmaktadır.{1} Değerin Türkçe Karşılığıdır..", ing, dizi[ing].ToString());
                }
                else
                {
                    Console.WriteLine("Girdiğiniz {0} İngilizce Kelimenin Türkçe Karşılığını Giriniz", ing);
                    Console.Write("Türkçe Karşılığı: ");
                    string tr = Console.ReadLine();
                    dizi.Add(ing, tr);
                }

                Console.WriteLine("Yeni Değer Eklemek İstiyor Musunuz?(E/H)");
                soru = Console.ReadLine();
                soru = soru.ToUpper();
            } while (soru != "H");
            foreach (var a in dizi.Keys)
            {
                Console.WriteLine("İngilizce Kelime: {0}\tTürkçe Karşılığı: {1}", a, dizi[a]);
            }
            Console.ReadLine();
        }
    }
}
