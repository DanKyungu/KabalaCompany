using System;
using System.Collections.Generic;
using System.Text;

namespace KabalaCompany.DataEntity
{
    public class AnimalStock
    {
        public int Id { get; set; }
        public Animal AnimalId { get; set; }
        public int Quantity { get; set; }
        public User LastEditedBy { get; set; }
        public DateTime LastEditedWhen { get; set; }

    }
}
