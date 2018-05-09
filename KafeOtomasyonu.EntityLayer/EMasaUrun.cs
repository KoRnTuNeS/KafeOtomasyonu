using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KafeOtomasyonu.EntityLayer
{
    public class EMasaUrun
    {
        public int ID { get; set; }
        public int TableID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
    }
}
