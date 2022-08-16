using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama
            string[] renkler = new string[5];
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Koyun" };

            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve erişim
            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngüler, dizi kullanımı
            //Kullanıcıdan girilen n tane sayının ortalamasını alma

            Console.Write("Lütfen dizinin eleman sayısını giriniz:");
            int n = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Lütfen {0}. elemanı giriniz: ",i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (int sayi in sayiDizisi)
            {
                toplam += sayi;
            }

            Console.WriteLine("Ortalama: "+toplam/n);

        }
    }
}
