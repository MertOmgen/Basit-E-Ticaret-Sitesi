using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_7
{
    public enum ArabaUreticisi
    {
        BMW = 1,
        Mercesedes = 2,
        FIAT = 3,
        Volkwvagen = 4,
        FORD = 5,
        Lamborghini = 6
    }
    public enum BMW
    {
        Series1 = 1,
        Series2 =2,
        Series3=3,
        Series4=4,
        SeriesM=5
    }
    public enum Mercedes
    {
        AMG = 1,
        SeriesA =2,
        SeriesB=3,
        SeriesC=4,
        SeriesE=5
    }
    public enum FIAT
    {
        Albea = 1,
        Brava = 2,
        Bravo =3,
        Coupe =4,
        Egea = 5
    }
    public enum Volkswagen
    {
        Arteon = 1,
        Bora =2,
        Golf=3,
        Jetta=4,
        Passat =5
    }
    public enum FORD
    {
        Escort = 1,
        Focus =2,
        Fusion = 3,
        Mustang = 4,
        Taunus =5
    }
    public enum Lamborghini
    {
        Aventador = 1,
        Gallardo = 2,
        Huracan = 3
    }
    class Araba : URUN
    {
        public ArabaUreticisi araba { get; set; }
        public BMW BMW { get; set; }
        public Mercedes Mercedes { get; set; }
        public FIAT FIAT { get; set; }
        public Volkswagen Volkswagen { get; set; }
        public FORD FORD { get; set; }
        public Lamborghini Lamborghini { get; set; }

        public Araba(ArabaUreticisi araba)
        {
            switch (araba)
            {
                case ArabaUreticisi.BMW:
                    switch (BMW)
                    {
                        case BMW.Series1:
                            this.Price = 50000;
                            this.UrunID = 30123423;
                            this.UrunIsmi = "BMW 1 Serisi";
                            break;
                        case BMW.Series2:
                            this.Price = 60000;
                            this.UrunID = 30223423;
                            this.UrunIsmi = "BMW 2 Serisi";
                            break;
                        case BMW.Series3:
                            this.Price = 70000;
                            this.UrunID = 30323423;
                            this.UrunIsmi = "BMW 3 Serisi";
                            break;
                        case BMW.Series4:
                            this.Price = 80000;
                            this.UrunID = 30423423;
                            this.UrunIsmi = "BMW 4 Serisi";
                            break;
                        case BMW.SeriesM:
                            this.Price = 90000;
                            this.UrunID = 30523423;
                            this.UrunIsmi = "BMW M Serisi";
                            break;
                        default:
                            break;
                    }
                    break;
                case ArabaUreticisi.Mercesedes:
                    switch (Mercedes)
                    {
                        case Mercedes.AMG:
                            this.Price = 70000;
                            this.UrunID = 40023423;
                            this.UrunIsmi = "Mercedes AMG Serisi";
                            break;
                        case Mercedes.SeriesA:
                            this.Price = 80000;
                            this.UrunID = 40123423;
                            this.UrunIsmi = "Mercedes A Serisi";
                            break;
                        case Mercedes.SeriesB:
                            this.Price = 90000;
                            this.UrunID = 40223423;
                            this.UrunIsmi = "Mercedes B Serisi";
                            break;
                        case Mercedes.SeriesC:
                            this.Price = 100000;
                            this.UrunID = 40323423;
                            this.UrunIsmi = "Mercedes C Serisi";
                            break;
                        case Mercedes.SeriesE:
                            this.Price = 110000;
                            this.UrunID = 40423423;
                            this.UrunIsmi = "Mercedes E Serisi";
                            break;
                        default:
                            break;
                    }
                    break;
                case ArabaUreticisi.FIAT:
                    switch (FIAT)
                    {
                        case FIAT.Albea:
                            this.Price = 10000;
                            this.UrunID = 50023423;
                            this.UrunIsmi = "FIAT Albea";
                            break;
                        case FIAT.Brava:
                            this.Price = 15000;
                            this.UrunID = 50123423;
                            this.UrunIsmi = "FIAT Brava";
                            break;
                        case FIAT.Bravo:
                            this.Price = 20000;
                            this.UrunID = 50223423;
                            this.UrunIsmi = "FIAT Bravo";
                            break;
                        case FIAT.Coupe:
                            this.Price = 25000;
                            this.UrunID = 50323423;
                            this.UrunIsmi = "FIAT Coupe";
                            break;
                        case FIAT.Egea:
                            this.Price = 30000;
                            this.UrunID = 50423423;
                            this.UrunIsmi = "FIAT Egea";
                            break;
                        default:
                            break;
                    }
                    break;
                case ArabaUreticisi.Volkwvagen:
                    switch (Volkswagen)
                    {
                        case Volkswagen.Arteon:
                            this.Price = 40000;
                            this.UrunID = 60023423;
                            this.UrunIsmi = "Volkswagen Arteon";
                            break;
                        case Volkswagen.Bora:
                            this.Price = 50000;
                            this.UrunID = 60123423;
                            this.UrunIsmi = "Volkswagen Bora";
                            break;
                        case Volkswagen.Golf:
                            this.Price = 60000;
                            this.UrunID = 60223423;
                            this.UrunIsmi = "Volkswagen Golf";
                            break;
                        case Volkswagen.Jetta:
                            this.Price = 70000;
                            this.UrunID = 60323423;
                            this.UrunIsmi = "Volkswagen Jetta";
                            break;
                        case Volkswagen.Passat:
                            this.Price = 80000;
                            this.UrunID = 60423423;
                            this.UrunIsmi = "Volkswagen Passat";
                            break;
                        default:
                            break;
                    }
                    break;
                case ArabaUreticisi.FORD:
                    switch (FORD)
                    {
                        case FORD.Escort:
                            this.Price = 20000;
                            this.UrunID = 70023423;
                            this.UrunIsmi = "FORD Escort";
                            break;
                        case FORD.Focus:
                            this.Price = 25000;
                            this.UrunID = 70123423;
                            this.UrunIsmi = "FORD Focus";
                            break;
                        case FORD.Fusion:
                            this.Price = 30000;
                            this.UrunID = 70223423;
                            this.UrunIsmi = "FORD Fusion";
                            break;
                        case FORD.Mustang:
                            this.Price = 100000;
                            this.UrunID = 70323423;
                            this.UrunIsmi = "FORD Mustang";
                            break;
                        case FORD.Taunus:
                            this.Price = 40000;
                            this.UrunID = 70423423;
                            this.UrunIsmi = "FORD Taunus";
                            break;
                        default:
                            break;
                    }
                    break;
                case ArabaUreticisi.Lamborghini:
                    switch (Lamborghini)
                    {
                        case Lamborghini.Aventador:
                            this.Price = 200000;
                            this.UrunID = 10023423;
                            this.UrunIsmi = "Lamborghini Aventador";
                            break;
                        case Lamborghini.Gallardo:
                            this.Price = 220000;
                            this.UrunID = 10123423; 
                            this.UrunIsmi = "Lamborghini Gallardo";
                            break;
                        case Lamborghini.Huracan:
                            this.Price = 250000;
                            this.UrunID = 10223423;
                            this.UrunIsmi = "Lamborghini Huracan";
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
