using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sifreleme_Algoritmasi
{
    class Program
    {
        public static int asaltut;
        public static long fibotut;
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.TelnoAl();
            Console.Read();
        }
        void TelnoAl()
        {
        don:
            Console.WriteLine("Cep Telefonunuzun Başında '0' Olmadan Giriniz!");
            string str = " ";
            str = Console.ReadLine();
            long a = Int64.Parse(str);
            int tutucu = str.Length;
            if (tutucu == 10 && a > 5000000000 && a < 6000000000)
                Console.WriteLine("Başarılı giriş yaptınız.Yönlendiriliyorsunuz...");
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız lütfen tekrar deneyin");
                goto don;
            }
            Toplam(ref a);
        }
        void Toplam(ref long telno)
        {
            long top = 5, kalan = 0;
            for (int i = 0; i < telno; i++)
            {
                kalan = telno % 10;
                //telno = telno - kalan;
                telno /= 10;
                top += kalan;
            }
            //Console.WriteLine("Rakamların Toplamı : " + top);
            fibonacci(ref top);
            Asal(ref top);
        }
        static void fibonacci(ref long gelen)
        {
            long x = 0;
            long y = 1, z = 0;
            long sayi;
            for (int i = 0; i < gelen - 2; i++)
            {
                z = x + y;
                x = y;
                y = z;
            }
            //Console.WriteLine(gelen + ". Fibonacci Sayısı : " + z);
            Program prog = new Program();
            fibotut = z;
        }
        void Asal(ref long deger)
        {
            int sayac, tutucu = 0;
            for (int i = 2; i < deger * 5 - 25; i++)
            {
                sayac = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        sayac++;
                }
                if (sayac == 0)
                {
                    //Console.Write(i + "  ");
                    tutucu = i;
                }
            }
            //Console.WriteLine("\n" + deger + ". asal sayı : " + tutucu);
            asaltut = tutucu;
            Birlestir();
        }
        void Birlestir()
        {
            string fiboyaz = fibotut.ToString();
            string asalyaz = asaltut.ToString();
            //Console.WriteLine("STRFİBO : "+fiboyaz);
            //Console.WriteLine("STRASAL : "+asalyaz);
            Console.WriteLine("Şifreniz : " + asalyaz + fiboyaz + " \nİyi Seyirler...");
        }
    }
}
