using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//klavyeden girilen 3 adet sayının toplmanın 5 eksiğini ekrana yazdıran program kodunu yazınız koşul: sayıları int olarak tanıumlayınız.
namespace _3_sayı
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.Write("1. Sayı: ");
                a = Convert.ToInt16(Console.ReadLine());
                Console.Write("2. Sayı: ");
                b = Convert.ToInt16(Console.ReadLine());
                Console.Write("3. Sayı: ");
                c = Convert.ToInt16(Console.ReadLine());
                Console.Write("Toplamın 5 eksiği: " + ((a + b + c) - 5));
            }
            catch(Exception ex)
            {
                Console.Write("Lütfen sadece rakam giriniz." + " Hata: " + ex.Message);
            }
                Console.Read();

        }
    }
}
