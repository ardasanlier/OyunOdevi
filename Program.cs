using System;
using System.Collections.Generic;

namespace OyunOdevi
{
    class Program
    {
        static void Main(string[] args)
        {
            int kategoris, bosdeger2,bosdeger;
            Games game1 = new Games();
            Games game2 = new Games();
            Games game3 = new Games();
            Games game4 = new Games();
            Games game5 = new Games();
            Games game6 = new Games();

            List<Games> kategorispor = new List<Games>() { game1,game6 };
            List<Games> kategorisavaş = new List<Games>() { game2,game5 };
            List<Games> kategorisimulasyon = new List<Games>() { game3,game4 };

            game1.Ad = "Fifa 21";
            game1.Fiyat = 369.9;
            game1.Kategori = "Spor";

            game2.Ad = "PUBG";
            game2.Fiyat = 69.9;
            game2.Kategori = "Savaş";

            game3.Ad = "Sims";
            game3.Fiyat = 99.9;
            game3.Kategori = "Simulasyon";

            game4.Ad = "Minecraft";
            game4.Fiyat = 229.9;
            game4.Kategori = "Simulasyon";

            game5.Ad = "Halo4";
            game5.Fiyat = 219.9;
            game5.Kategori = "Savaş";

            game6.Ad = "NBA2K21";
            game6.Fiyat = 329.9;
            game6.Kategori = "Spor";

            Dictionary<string,string> Edevlet = new Dictionary<string,string>() { };
            Edevlet.Add("Ahmet", "11023902110");
            Edevlet.Add("Fatma", "13809120936");

            CustomerManager customer1 = new CustomerManager();
            Console.WriteLine("Tc numaranız: ");
            customer1.TcNo = Console.ReadLine();
            Console.WriteLine("Adınız: ");
            customer1.Ad = Console.ReadLine();
            Console.WriteLine("Soyadınız: ");
            customer1.Soyad = Console.ReadLine();

            foreach(KeyValuePair<string,string> edevlet in Edevlet)
            {
                if (customer1.Ad == edevlet.Key)
                {
                    if (customer1.TcNo == edevlet.Value)
                    {
                        customer1.Add(customer1);
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz profil");
                    }
                }
            }
            Console.WriteLine("silmek için 1e güncellemek için 2ye oyun almak için 3e basın: ");
            bosdeger = Convert.ToInt32(Console.ReadLine());
            if (bosdeger == 1)
            {
                customer1.Delete(customer1);
            }
            if (bosdeger == 2)
            {
                customer1.Upload(customer1);
            }
            Console.WriteLine("1.Spor");
            Console.WriteLine("2.Savaş");
            Console.WriteLine("3.Simulasyon");
            Console.WriteLine("Kaçıncı kategoriden bir oyun almak istersiniz");
            kategoris = Convert.ToInt32(Console.ReadLine());
            if (kategoris == 1)
            {
                game1.Kampanyaspor();
                foreach (Games game in kategorispor)
                {
                    game.Sırala1(game);
                }
            }
            if (kategoris == 2)
            {
                game2.Kampanyasavaş();
                foreach (Games game in kategorisavaş)
                {
                    game.Sırala2(game);
                }
            }
            if (kategoris == 3)
            {
                game3.Kampanyasimulasyon();
                foreach (Games game in kategorisimulasyon)
                {
                    game.Sırala3(game);
                }
            }
            Console.WriteLine("Almak için 1i girin: ");
            bosdeger2 = Convert.ToInt32(Console.ReadLine());
            if (bosdeger2 == 1)
            {
                game1.Buy();
            }
        }
    }
}
