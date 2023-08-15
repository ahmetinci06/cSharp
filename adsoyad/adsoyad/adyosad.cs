using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ekrana klavyeden girilen ad ve soyadaımızı yan yana yazdıran program kodunu yazınız koşul: ad ve soyad klavyeden ayrı ayrı alınacak
namespace adsoyad
{
    class adyosad
    {
        static void Main(string[] args)
        {
            string ad,soyad;
            Console.Write("Adını Gir: ");
            ad = Console.ReadLine();
            Console.Write("Soy Adını Gir: ");
            soyad = Console.ReadLine();
            Console.Write("Adın Ve Soyadın: " + ad + " " + soyad);
            Console.ReadKey();

        }
    }
}
