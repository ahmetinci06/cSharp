using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//öğrenci notu klavyeden girildikten sonra girilen not 0 la 49 arasındaysa ekrana ff yazsın, 50 ile 64 arasındaysa ekrana dd yazsın, 
//girilen not 65 ile 74 arasındaysı ekrana cc yazsın, 75 ile 84 arasındaysa ekrana bb yazsın, girilken not 85 ile 100 arasındaysa aa yazsın. Koşul = Klavyeden girileen sayı 0 ile 100 arasında olmalı.
namespace _0_5_not
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Not Giriniz: ");
            int not = Convert.ToInt32(Console.ReadLine());
            if (not < 0 || not > 100)
            {
                Console.Write("Hatalı not girdiniz. Not 0 dan küçük veya 100 den büyük olamaz");
            }
            else if (not >= 0 && not <= 49 )
            {
                Console.Write("FF");
            }
            else if (not >= 50 && not <= 64)
            {
                Console.Write("DD");
            }
            else if (not >= 65 && not <= 74)
            {
                Console.Write("CC");
            }
            else if (not >= 75 && not <= 84)
            {
                Console.Write("BB");
            }
            else if (not >= 85 && not <= 100)
            {
                Console.Write("AA");
            }

            Console.Read();

        }
    }
}