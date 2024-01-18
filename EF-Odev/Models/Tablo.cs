using System;
using System.Collections.Generic;

namespace EF_Odev.Models
{
    public partial class Tablo
    {
        public string FirstName { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
    }
}
