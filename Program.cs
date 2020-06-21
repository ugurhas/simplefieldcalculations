using System;

namespace ConsoleApp2_fonk.örnek_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kare, üçgen veya dairenin alanını hesaplayın

            Console.WriteLine("Lütfen hesaplamak istediğiniz alan türünü seçiniz: \n1-Kare \n2-Daire \n3-Üçgen");
            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {
                Console.WriteLine("Lütfen karenin kenar uzunluğunu giriniz: ");
                int karekenar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hesaplamak istediğiniz karenin alanı: "+karealani(karekenar));
            }

            else if (secim == 2)
            {
                Console.WriteLine("Lütfen dairenin yarıçapını giriniz: ");
                int yaricap = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hesaplamak istediğiniz dairenin alanı: " + dairealani(yaricap) + " (Pi sayısı 3 olarak kabul edilmiştir.)");
            }

            else if (secim == 3)
            {
                Console.WriteLine("Lütfen üçgenin taban uzunluğunu giriniz: ");
                int taban = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Lütfen üçgenin yüksekliğini giriniz: ");
                int yukseklik = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Hesaplamak istediğiniz üçgenin alanı: " + ucgenalani(taban, yukseklik));
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız.");
            }
        }

        static int karealani(int kenar)
        {
            return kenar * kenar;
        }

        static int dairealani(int yaricap)
        { 
            return 3 * yaricap * yaricap;
        }

        static int ucgenalani(int taban, int yukseklik)
        {
            return taban * yukseklik / 2;
        }
    }
}
