using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//klavyeden a ve b değişkenlere 2 adet sayı girildikten sonra girilen sayıların toplamı 20 den büyük ise ekrana sayıların toplamı 20 den büyüktür yazsın
namespace not
{
    class not
    {
        static void Main(string[] args)
        {
            try
            {
                int a , b = 15, top;
                Console.Write("1. Sayıyı Giriniz: ");

                a = Convert.ToInt32(Console.ReadLine());
                top = a + b;
                if ((top) >= 20)
                {
                    Console.Write("Sayıların Toplamı 20 den Büyük veya eşittir.");
                }
                else
                {
                    Console.Write("Sayıların toplamı 20 sayısından küçüktür.");
                }

            }
            catch (Exception ex)
            {

                Console.Write("Hata: " + ex.Message);

            }

            Console.Read();
        }
    }
}
