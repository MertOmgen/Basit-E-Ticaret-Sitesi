using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_7
{
    public enum BilgisayarUreticisi
    {
        MSİ = 1,
        Toshiba = 2,
        Monster =3
    }
    public enum MSİ
    {
        GT83 = 1,
        GV72 = 2,
        GF62 = 3
    }
    public enum Toshiba
    {
        L50 = 1,
        R50 = 2,
        W50 =3
    }
    public enum Monster
    {
        A7 = 1,
        S7=2,
        A5=3
    }
    class Bilgisayar:URUN
    {
        public BilgisayarUreticisi BilgisayarUreticisi { get; set; }
        public MSİ MSİ { get; set; }
        public Toshiba Toshiba { get; set; }
        public Monster Monster { get; set; }

        public Bilgisayar(BilgisayarUreticisi bilgisayarUreticisi)
        {
            switch (bilgisayarUreticisi)
            {
                case BilgisayarUreticisi.MSİ:
                    switch (MSİ)
                    {
                        case MSİ.GT83:
                            this.Price = 2000;
                            this.UrunID = 30230;
                            this.UrunIsmi = "MSİ GT83 Gaming Laptop";
                            break;
                        case MSİ.GV72:
                            this.Price = 3500;
                            this.UrunID = 31230;
                            this.UrunIsmi = "MSİ GV72 Gaming Laptop";
                            break;
                        case MSİ.GF62:
                            this.Price = 4300;
                            this.UrunID = 32230;
                            this.UrunIsmi = "MSİ GF62 Gaming Laptop";
                            break;
                        default:
                            break;
                    }
                    break;
                case BilgisayarUreticisi.Toshiba:
                    switch (Toshiba)
                    {
                        case Toshiba.L50:
                            this.Price = 1000;
                            this.UrunID = 20230;
                            this.UrunIsmi = "Toshiba L50 Laptop";
                            break;
                        case Toshiba.R50:
                            this.Price = 1400;
                            this.UrunID = 21230;
                            this.UrunIsmi = "Toshiba R50 Laptop";
                            break;
                        case Toshiba.W50:
                            this.Price = 4300;
                            this.UrunID = 22230;
                            this.UrunIsmi = "Toshiba W50 Laptop";
                            break;
                        default:
                            break;
                    }
                    break;
                case BilgisayarUreticisi.Monster:
                    switch (Monster)
                    {
                        case Monster.A7:
                            this.Price = 3000;
                            this.UrunID = 10230;
                            this.UrunIsmi = "Monster Abra A7 Gaming Laptop";
                            break;
                        case Monster.S7:
                            this.Price = 4000;
                            this.UrunID = 11230;
                            this.UrunIsmi = "Monster Abra S7 Gaming Laptop";
                            break;
                        case Monster.A5:
                            this.Price = 2200;
                            this.UrunID = 12230;
                            this.UrunIsmi = "Monster Abra A5 Gaming Laptop";
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
