using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;


namespace Örnek_7
{
    class Register
    {
        System.Globalization.CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;

        string kullaniciadi = string.Empty,
               sifre = string.Empty,
               email = string.Empty,
               ad = string.Empty,
               soyad = string.Empty;

        DateTime date = new DateTime();
        int dogumTarihi = default(int);


        bool kontrolKullaniciAdi = default(bool),
         kontrolSifre = default(bool),
         kontrolEmail = default(bool),
         kontrolAd = default(bool),
         kontrolSoyad = default(bool),
         kontrolDogumTarihi = default(bool),
            kontrol = default(bool);
        

        public Register()
        {
            

            var regexItem = new Regex("^[a-zA-Z0-9]*$");
            var regexItem1 = new Regex("^[a-zA-Z]*$");
            Console.WriteLine("**************KAYIT OL****************");
            Bosluk();
            try
            {
                do
                {
                    if (kontrolKullaniciAdi == false)
                    {
                        Console.Write("Lütfen Kullanıcı Adınızı Belirtiniz : ");
                        kullaniciadi = Console.ReadLine();
                        kontrolKullaniciAdi = true;
                        Bosluk();
                        if (!regexItem.IsMatch(kullaniciadi))
                        {
                            Console.WriteLine("Lütfen Özel Karakter veya Boşluk Kullanmayınız..!");
                            kontrolKullaniciAdi = false;
                            Bosluk();
                            continue;
                        }
                    }
                    if (kontrolSifre == false)
                    {
                        Console.Write("Lütfen Şifrenizi Belirtiniz : ");
                        sifre = Console.ReadLine();
                        kontrolSifre = true;
                        Bosluk();
                        if (!regexItem.IsMatch(sifre))
                        {
                            Console.WriteLine("Lütfen Özel Karakter veya Boşluk Kullanmayınız..!");
                            kontrolSifre = false;
                            Bosluk();
                            continue;
                        }
                    }
                    if (kontrolEmail == false)
                    {
                        Console.Write("Lütfen Mail Adresinizi Belirtiniz : ");
                        email = Console.ReadLine();
                        kontrolEmail = true;
                        Bosluk();
                        if (kontrol == email.Contains("@"))
                        {
                            Console.WriteLine("Lütfen Geçerli Bir Mail Adresi Giriniz..!");
                            kontrolEmail = false;
                            Bosluk();
                            continue;
                        }
                    }
                    if (kontrolAd == false)
                    {
                        Console.Write("Adınız : ");
                        ad = Console.ReadLine();
                        kontrolAd = true;
                        Bosluk();
                        if (!regexItem1.IsMatch(ad))
                        {
                            Console.WriteLine("Lütfen Özel Karakter veya Boşluk Kullanmayınız..!");
                            kontrolAd = false;
                            Bosluk();
                            continue;
                        }
                    }
                    if (kontrolSoyad == false)
                    {
                        Console.Write("Soyadınız : ");
                        soyad = Console.ReadLine();
                        kontrolSoyad = true;
                        Bosluk();
                        if (!regexItem1.IsMatch(soyad))
                        {
                            Console.WriteLine("Lütfen Özel Karakter veya Boşluk Kullanmayınız..!");
                            kontrolSoyad = false;
                            Bosluk();
                            continue;
                        }
                    }
                    if (kontrolDogumTarihi == false)
                    {
                        Console.Write("Doğum Yılınız : ");
                        dogumTarihi = Convert.ToInt32(Console.ReadLine());
                        kontrolDogumTarihi = true;
                        Bosluk();
                        if (dogumTarihi <= 1920 || dogumTarihi >= DateTime.Now.Year)
                        {
                            Console.WriteLine("Lütfen Doğum Tarihini Tekrar Giriniz.!");
                            kontrolDogumTarihi = false;
                            Bosluk();
                            continue;
                        }
                    }

                    kullaniciBilgiler(
                        ad: ad,
                        soyad: soyad,
                        kullaniciAdi: kullaniciadi,
                        sifre: sifre,
                        email: email,
                        dogumTarihi: dogumTarihi
                        );

                } while (!regexItem.IsMatch(kullaniciadi) || !regexItem.IsMatch(sifre) || kontrol == email.Contains("@") || !regexItem1.IsMatch(ad) || !regexItem1.IsMatch(soyad) || dogumTarihi < 1920 || dogumTarihi >= DateTime.Now.Year);
            }
            catch(Exception ex)
            {
                Console.WriteLine("{0} Hatasını Yaptınız..!",ex.Message);
                Console.WriteLine("Program Kapatılıyor..!");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
            
            


        }
        public void kullaniciBilgiler(string ad,string soyad,string kullaniciAdi,string sifre,string email,int dogumTarihi)
        {
            System.Globalization.TextInfo textInfo = cultureInfo.TextInfo;

            StringBuilder kullanici = new StringBuilder();
            kullanici.Append("Adınız : " + textInfo.ToTitleCase(ad) );
         
            kullanici.Append("\nSoyadınız : " + textInfo.ToTitleCase(soyad));
            
            kullanici.Append("\nDoğum Tarihiniz : " + dogumTarihi);
            
            kullanici.Append("\nKullanıcı Adınız : " + textInfo.ToTitleCase(kullaniciAdi));
            
            kullanici.Append("\nŞifreniz : " + textInfo.ToTitleCase(sifre));

            kullanici.Append("\nEmail : " + email);
            Console.WriteLine(kullanici.ToString());
        }
        public void Bosluk()
        {
            Console.WriteLine();
        }
    }
    
}
