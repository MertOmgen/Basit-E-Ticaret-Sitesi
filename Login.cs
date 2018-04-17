using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Örnek_7
{
    class Login : Register
    {
        string girilenKullaniciAdi = string.Empty,
                   girilenSifre = string.Empty;
        int counter = default(int),
            counter1 = default(int);


        public Login()
        {
            Console.WriteLine("***********GİRİŞ YAP***********");
            Bosluk();
            do
            {
                Console.Write("Kullanıcı Adınızı Giriniz : ");
                girilenKullaniciAdi = Console.ReadLine();
                counter++;
                Bosluk();

                if (counter > 2)
                {

                    Console.WriteLine("Kullanıcı Adınızı Giremediniz.!");
                    break;
                }
                if (kullaniciadi == girilenKullaniciAdi)
                {
                    Console.Write("Lütfen Şifrenizi Giriniz : ");
                    girilenSifre = Console.ReadLine();
                    Bosluk();
                    counter1++;
                    if (counter1 > 2)
                    {
                        Console.WriteLine("Şifrenizi Giremediniz.!");
                        Console.WriteLine(Environment.NewLine);
                        Thread.Sleep(2000);
                        break;
                    }
                    if (kullaniciadi == girilenKullaniciAdi && sifre == girilenSifre)
                    {
                        Console.WriteLine("Başarıyla Giriş Yaptınız..Siteye Yönlendiriliyorsunuz.!");
                        Console.WriteLine(Environment.NewLine);
                        Thread.Sleep(2000);

                    }
                }

                } while (kullaniciadi != girilenKullaniciAdi || sifre != girilenSifre) ;
            }
            }
    }



      
        
    

