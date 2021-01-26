using System;
using System.Collections.Generic;
using System.Text;

namespace OyunOdevi
{
    class CustomerManager
    {
        public int Id { get; set; }
        public string TcNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public void Add(CustomerManager customer)
        {
            Console.WriteLine("Aramıza Hoşgeldiniz Sayın {0} {1}", customer.Ad, customer.Soyad);
        }
        public void Delete(CustomerManager customer)
        {
            Console.WriteLine("Gitmene üzüldük {0}", customer.Ad);
        }
        public void Upload(CustomerManager customer)
        {
            Console.WriteLine("Hesabın güncellendi!");
        }
    }
}
