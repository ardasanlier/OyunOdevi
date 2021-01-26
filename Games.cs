using System;
using System.Collections.Generic;
using System.Text;

namespace OyunOdevi
{
    class Games
    {
        public string Ad { get; set; }
        public double Fiyat { get; set; }
        public string Kategori { get; set; }

        public void Sırala1(Games game)
        {
            Console.WriteLine("Oyun: {0}", game.Ad);
            Console.WriteLine("Fiyat: {0}", game.Fiyat*9/10);
        }
        public void Sırala2(Games game)
        {
            Console.WriteLine("Oyun: {0}", game.Ad);
            Console.WriteLine("Fiyat: {0}", game.Fiyat*7/10);
        }
        public void Sırala3(Games game)
        {
            Console.WriteLine("Oyun: {0}", game.Ad);
            Console.WriteLine("Fiyat: {0}", game.Fiyat*8/10);
        }
        public void Buy()
        {
            Console.WriteLine("Güle Güle Kullanın!");
        }
        public void Kampanyaspor()
        {
            Console.WriteLine("##### ŞOK KAMPANYA #####");
            Console.WriteLine("Spor ürünleri %10 indirimli");
        }
        public void Kampanyasavaş()
        {
            Console.WriteLine("##### ŞOK KAMPANYA #####");
            Console.WriteLine("Savaş ürünleri %30 indirimli");
        }
        public void Kampanyasimulasyon()
        {
            Console.WriteLine("##### ŞOK KAMPANYA #####");
            Console.WriteLine("Simulasyon ürünleri %20 indirimli");
        }
    }
}
