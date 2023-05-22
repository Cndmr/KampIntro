using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Name +"Müşteri Eklendi");
        }
        public void Sil (Musteri musteri)
        {
            Console.WriteLine(musteri.Name +"Müşteri Silindi");
        }
        public void Listele(Musteri[] musteriler)
         
        {
            Console.WriteLine("Müşteri Listesi");
            foreach (var item in musteriler)
            {
                Console.WriteLine(item.Name + item.Surname + item.PhoneNumber);

            }

        }
    }
}
