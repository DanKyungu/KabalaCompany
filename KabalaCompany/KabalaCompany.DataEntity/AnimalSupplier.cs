using System;
using System.Collections.Generic;
using System.Text;

namespace KabalaCompany.DataEntity
{
    public class AnimalSupplier
    {
        public int Id { get; set; }
        public Animal Animal { get; set; }
        public Supplier Supplier { get; set; }

    }
}
