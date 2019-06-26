using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KabalaCompany.DataEntity
{
    [Table(nameof(Orders), Schema = "Sells")]
    public class Orders
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(60)]
        public string OrderMethod { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public DateTime ExpectedPickupDate { get; set; }

        [Required]
        public DateTime PickingCompletedWhen { get; set; }

        public DateTime LastEditedWhen { get; set; }

        public int LastEditedById { get; set; }
        [NotMapped]
        public User LastEditedBy { get; set; }

        public int SalesPersonId { get; set; }
        public User SalesPerson { get; set; }

        public int CustomerId { get; set; }
        public Customers Customer { get; set; }

        public virtual IEnumerable<OrderLines> OrderLines { get; set; }
    }
}
