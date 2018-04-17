using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_7
{
    class URUN
    {
        public int UrunID { get; set; }
        public double Price { get; set; }
        public string UrunIsmi { get; set; }

        public URUN()
        {

        }
        public URUN(
            int productId,
            string productCode,
            string productName,
            double price)
        {
            this.UrunID = productId;
            this.UrunIsmi = productName;
            this.Price = price;
        }

        public double SetKdv()
        {
            return this.Price * 1.18;
        }
    }
}
