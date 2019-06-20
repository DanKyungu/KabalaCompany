using System;
using System.Collections.Generic;
using System.Text;

namespace KabalaCompany.DataEntity
{
    public class Animal
    {
        public int Id { get; set; }
        public string AnimalName { get; set; }
        public int MinimumWeight { get; set; }
        public int MaximumWeight { get; set; }
        public int PricePerKg { get; set; }
        public int RetailPricePerKg { get; set; }

    }
}
