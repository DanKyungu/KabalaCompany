
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace KabalaCompany.DataEntity
{
    [Table(nameof(User), Schema = "Application")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Username { get; set; }

        [Required]
        [MaxLength(60)]
        public string Password { get; set; }

        public virtual IEnumerable<Employee> Employees { get; set; }
        public virtual IEnumerable<AnimalStock> AnimalStocks { get; set; }
        public virtual IEnumerable<OrderLines> OrderLines { get; set; }
        public virtual IEnumerable<Orders> Orders { get; set; }

        [InverseProperty("User")]
        public virtual IEnumerable<PurchaseOrders> UserPurchaseOrders { get; set; }

        [InverseProperty("LastEditedBy")]
        public virtual IEnumerable<PurchaseOrders> EditedPurchaseOrders { get; set; }

        [InverseProperty("LastEditedBy")]
        public virtual IEnumerable<PurchaseOrderLines> CreatedPurchaseOrderLines { get; set; }

        public virtual IEnumerable<PurchaseOrderLines> EditedPurchaseOrderLines { get; set; }
    }
}