using System;
using System.Collections.Generic;
using System.Text;

namespace KabalaCompany.DataEntity
{
    public class PurchaseOrders
    {
        public int Id { get; set; }
        public Supplier SupplierId { get; set; }
        public User OrderPlacedBy { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public bool IsOrderCompleted { get; set; }
        public bool IsOrderFinalizedOnTime { get; set; }
        public string Comments { get; set; }
        public User LastEditedBy { get; set; }
        public DateTime LastEditedWhen { get; set; }



    }
}
