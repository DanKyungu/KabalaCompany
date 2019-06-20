using System;
using System.Collections.Generic;
using System.Text;

namespace KabalaCompany.DataEntity
{
    public class OrderLines
    {
        public int Id { get; set; }
        public Orders OrderId { get; set; }
        public Animal AnimalId { get; set; }
        public string Description { get; set; }
        public int OrderQuantity { get; set; }
        public int UnitPrice { get; set; }
        public User LastEditedBy { get; set; }
        public DateTime LastEditedWhen { get; set; }

    }
}
