using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//klavyeden 2 adet sayı giriniz girilen sayıların toplamını ekrana yazdıran programın kodlarını yazınız.
namespace ConsoleApplication1
{
    class sayılar
    {
        static void Main(string[] args)
        {
            try
            {
                string x, y;
                Console.WriteLine("1. sayiyi giriniz: ");
                x = Console.ReadLine();
                Console.WriteLine("2. sayiyi giriniz: ");
                y = Console.ReadLine();
                Console.WriteLine(Convert.ToInt32(x) + Convert.ToInt16(y));
            }
            catch (Exception ex)
            {
                Console.Write("Lütfen sadece rakam giriniz." + " Hata: " + ex.Message);
            }

            Console.ReadKey();
            
        }
    }
}




//ekrana klavyeden girilen ad ve soyadaımızı yan yana yazdıran program kodunu yazınız koşul: ad ve soyad klavyeden ayrı ayrı alınacak

//klavyeden string olarak girilen 2 adet sayının çarpımının sonucu ekrana yazdıran kodu yaznız koşul: değişkeni string tanımla ama mateatiksel işleme uğrat

//klavyeden girilen 3 adet sayının toplmanın 5 eksiğini ekrana yazdıran program kodunu yazınız koşul: sayıları int olarak tanıumlayınız.