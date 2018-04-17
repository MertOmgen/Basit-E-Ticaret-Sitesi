using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_7
{
    class Sepet
    {
        private List<URUN> URUN = new List<URUN>();

        public void Add(URUN yeniURUN)
        {
            if (yeniURUN != null)
            {
                URUN.Add(yeniURUN);  //Bu Kısım Polymorphism kısmını yaptığımız yerdir.Tüm ürünler buraya product sınıfı gibi davrandığı için  girebilir
            }
        }

        public double TotalPrice()
        {
            double totalPrice = 0;
            foreach (var product in URUN)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
        public double TotalPriceWithKDV()
        {
            double totalPrice = 0;
            foreach (var product in URUN)
            {
                totalPrice += product.SetKdv();
            }
            return totalPrice;
        }
        public List<URUN> GetProducts()
        {
            return URUN;
        }
    }
}
