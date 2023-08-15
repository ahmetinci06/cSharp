using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//üniversite sınavı alınan puana göre sayısal ve sözel tercih yapılıp buna göre bölüm belirleyen program kodunu yazınız koşul: soruyu önce if cümlecikleriyle çözünüz, soruyu switch case ile çözünüz.

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {
            var sayısal = new[] {
                "Koç Üniversitesi Bilgisayar Mühendisliği", //550
                "Boğaziçi Üniversitesi Elektrik-Elektronik Mühendisliği", //520
                "Orta Doğu Teknik Üniversitesi Makine Mühendisliği", //530
                "Galatasaray Üniversitesi Matematik", //480
                "Bahçeşehir Üniversitesi Yazılım Mühendisliği" //525
            };
            var sozel = new[] {
                "Ankara Üniversitesi Coğrafya", //370
                "Marmara Üniversitesi Film Tasarımı ve Yönetimi", //380
                "Yaşar Üniversitesi Gastronomi ve Mutfak Sanatları", //440
                "Yeditepe Üniversitesi Gazetecilik", //450
                "Galatasaray Üniversitesi İletişim Fakültesi"  //470
            };
            
            Console.Write("Lütfen Puanını 0 ile 600 arasında bir sayı olarak gir." + "\n\n" + "Puan: ");           
                        
            try
            {
                int puan = Convert.ToInt32(Console.ReadLine());
                if (puan < 0 || puan > 600)
                {
                    Console.Write("Yanlış Değer Girdiniz.");
                }
            }
            catch (Exception ex)
            {
                Console.Write("Hata: " + ex.Message);
                
            }


            Console.Write("\n" + "Bölümünü Seç. (Sayısal İçin 1, Sözel İçin 2 ye bas.)" + "\n\n" + "Bölüm: ");
            int bolum = Convert.ToInt16(Console.ReadLine());

            if (bolum != 1 && bolum != 2)
            {
                Console.Write("Lütfen Sadece 1 veya 2 yazıp bölümünüzü belirtiniz.");
                Console.Read();
            }
            else if (bolum == 1)
            {
                Console.Write("\n" + "Sayısal");
                
            }
            else if (bolum == 2)
            {
                Console.Write("\n" + "Sözel");
            }
            else
            {
                Console.Write("Geçersiz.");
            }


            //Console.Write(sayısal[0]);
            Console.Read();
            
            }
        }
    }

