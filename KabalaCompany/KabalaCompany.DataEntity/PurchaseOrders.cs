using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KabalaCompany.DataEntity
{
    [Table(nameof(PurchaseOrders), Schema = "Purchasing")]
    public class PurchaseOrders
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public DateTime ExpectedDeliveryDate { get; set; }

        [Required]
        public bool IsOrderCompleted { get; set; }

        [Required]
        public bool IsOrderFinalizedOnTime { get; set; }

        [MaxLength(60)]
        [Required]
        public string Comments { get; set; }
        
        [Required]
        public DateTime LastEditedWhen { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        public int OrderPlacedById { get; set; }
        public Orders OrdersPlaced { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int LastEditedById { get; set; }
        public User LastEditedBy { get; set; }

        public IEnumerable<PurchaseOrderLines> PurchaseOrderLines { get; set; }
    }
}
