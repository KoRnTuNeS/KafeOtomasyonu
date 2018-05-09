using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KafeOtomasyonu.EntityLayer
{
    public class EUrun
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}
