using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_7
{
    public enum  TelefonUreticisi
    {
        Apple = 1,
        Samsung = 2,
        NOKIA = 3,
        Huawei = 4,
        LG = 5
    }

    public enum Apple
    {
        IPhone6 = 1,
        IPhone6s = 2,
        IPhone7 = 3,
        IPhone7s = 4,
        IPhone8 = 5
    }
    public enum Samsung
    {
        S6 = 1,
        S7  = 2,
        S8 = 3,
       Note5 = 4,
       Note6 = 5
    }
    public enum NOKIA
    {
        N203 = 1,
        N303 = 2,
        N403 = 3,
        N503 = 4,
        N603 = 5
    }
    public enum Huawei
    {
        Mate8   = 1,
        Mate9 = 2,
        Mate10 = 3,
        Mate11 = 4,
        Mate12 = 5
    }
    public enum LG
    {
        G3= 1,
        G4= 2,
        G5= 3,
        G6= 4,
        G7= 5
    }


    class Telefon : URUN
    {
        public TelefonUreticisi uretici { get; set; }
        public Apple apple { get; set; }
        public Samsung samsung { get; set; }
        public NOKIA NOKIA { get; set; }
        public Huawei huawei { get; set; }
        public LG LG { get; set; }


        public Telefon(TelefonUreticisi uretici,Apple apple,Samsung samsung,NOKIA NOKIA,Huawei huawei,LG LG)
        {
            switch (uretici)
            {
                case TelefonUreticisi.Apple:
                    switch (apple)
                    {
                        case Apple.IPhone6:
                            this.Price = 300;
                            this.UrunID = 666212;
                            this.UrunIsmi = "Apple Iphone 6";
                            break;
                        case Apple.IPhone6s:
                            this.Price = 400;
                            this.UrunID = 676212;
                            this.UrunIsmi = "Apple Iphone 6s";
                            break;
                        case Apple.IPhone7:
                            this.Price = 500;
                            this.UrunID = 766212;
                            this.UrunIsmi = "Apple Iphone 7";
                            break;
                        case Apple.IPhone7s:
                            this.Price = 600;
                            this.UrunID = 776212;
                            this.UrunIsmi = "Apple Iphone 7s";
                            break;
                        case Apple.IPhone8:
                            this.Price = 700;
                            this.UrunID = 866212;
                            this.UrunIsmi = "Apple Iphone 8";
                            break;
                        default:
                            break;
                    }
                    break;
                case TelefonUreticisi.Samsung:
                    switch (samsung)
                    {
                        case Samsung.S6:
                            this.Price = 100;
                            this.UrunID = 506212;
                            this.UrunIsmi = "Samsun Galaxy S6";
                            break;
                        case Samsung.S7:
                            this.Price = 200;
                            this.UrunID = 516212;
                            this.UrunIsmi = "Samsun Galaxy S7";
                            break;
                        case Samsung.S8:
                            this.Price = 300;
                            this.UrunID = 526212;
                            this.UrunIsmi = "Samsun Galaxy S8";
                            break;
                        case Samsung.Note5:
                            this.Price = 600;
                            this.UrunID = 536212;
                            this.UrunIsmi = "Samsun Galaxy Note5";
                            break;
                        case Samsung.Note6:
                            this.Price = 700;
                            this.UrunID = 546212;
                            this.UrunIsmi = "Samsun Galaxy Note6";
                            break;
                        default:
                            break;
                    }
                    break;
                case TelefonUreticisi.NOKIA:
                    switch (NOKIA)
                    {
                        case NOKIA.N203:
                            this.Price = 50;
                            this.UrunID = 406212;
                            this.UrunIsmi = "NOKIA N203";
                            break;
                        case NOKIA.N303:
                            this.Price = 60;
                            this.UrunID = 416212;
                            this.UrunIsmi = "NOKIA N303";
                            break;
                        case NOKIA.N403:
                            this.Price = 70;
                            this.UrunID = 426212;
                            this.UrunIsmi = "NOKIA N403";
                            break;
                        case NOKIA.N503:
                            this.Price =80;
                            this.UrunID = 436212;
                            this.UrunIsmi = "NOKIA N503";
                            break;
                        case NOKIA.N603:
                            this.Price = 90;
                            this.UrunID = 446212;
                            this.UrunIsmi = "NOKIA N603";
                            break;
                        default:
                            break;
                    }
                    break;
                case TelefonUreticisi.Huawei:
                    switch (huawei)
                    {
                        case Huawei.Mate8:
                            this.Price = 800;
                            this.UrunID = 306212;
                            this.UrunIsmi = "Huawei Mate 8";
                            break;
                        case Huawei.Mate9:
                            this.Price = 900;
                            this.UrunID = 316212;
                            this.UrunIsmi = "Huawei Mate 9";
                            break;
                        case Huawei.Mate10:
                            this.Price = 1000;
                            this.UrunID = 326212;
                            this.UrunIsmi = "Huawei Mate 10";
                            break;
                        case Huawei.Mate11:
                            this.Price = 1100;
                            this.UrunID = 336212;
                            this.UrunIsmi = "Huawei Mate 11";
                            break;
                        case Huawei.Mate12:
                            this.Price = 1200;
                            this.UrunID = 346212;
                            this.UrunIsmi = "Huawei Mate 12";
                            break;
                        default:
                            break;
                    }
                    break;
                case TelefonUreticisi.LG:
                    switch (LG)
                    {
                        case LG.G3:
                            this.Price = 1000;
                            this.UrunID = 206212;
                            this.UrunIsmi = "LG G3";
                            break;
                        case LG.G4:
                            this.Price = 1100;
                            this.UrunID = 216212;
                            this.UrunIsmi = "LG G4";
                            break;
                        case LG.G5:
                            this.Price = 1200;
                            this.UrunID = 226212;
                            this.UrunIsmi = "LG G5";
                            break;
                        case LG.G6:
                            this.Price = 1300;
                            this.UrunID = 236212;
                            this.UrunIsmi = "LG G6";
                            break;
                        case LG.G7:
                            this.Price = 1400;
                            this.UrunID = 246212;
                            this.UrunIsmi = "LG G7";
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
