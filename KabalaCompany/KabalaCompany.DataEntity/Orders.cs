using System;
using System.Collections.Generic;
using System.Text;

namespace KabalaCompany.DataEntity
{
    public class Orders
    {
        public int Id { get; set; }
        public Customers CustomerId { get; set; }
        public User SalesPersonId { get; set; }

        public string OrderMethod { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ExpectedPickupDate { get; set; }
        public DateTime PickingCompletedWhen { get; set; }
        public User LastEditedBy { get; set; }
        public DateTime LastEditedWhen { get; set; }

    }
}
