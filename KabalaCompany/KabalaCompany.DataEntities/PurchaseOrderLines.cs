using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KabalaCompany.DataEnties
{
    [Table(nameof(PurchaseOrderLines), Schema = "Sales")]
    public class PurchaseOrderLines
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Description { get; set; }

        [Required]
        public int OrderQuantity { get; set; }

        [Required]
        public int UnitPrice { get; set; }

        public DateTime LastEditedWhen { get; set; }

        public int PurchaseOrderId { get; set; }
        public PurchaseOrders PurchaseOrder { get; set; }

        public int AnimalId { get; set; }
        public Animal Animal { get; set; }

        public int LastEditedById { get; set; }
        public User LastEditedBy { get; set; }

    }
}
