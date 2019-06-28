
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace KabalaCompany.DataEnties
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

        public virtual ICollection<Employee> Employees { get; set; }

        public virtual ICollection<AnimalStock> AnimalStocks { get; set; }

        [InverseProperty("LastEditedBy")]
        public virtual ICollection<Orders> Orders { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<PurchaseOrders> UserPurchaseOrders { get; set; }

        [InverseProperty("LastEditedBy")]
        public virtual ICollection<PurchaseOrders> EditedPurchaseOrders { get; set; }

        [InverseProperty("LastEditedBy")]
        public virtual ICollection<PurchaseOrderLines> CreatedPurchaseOrderLines { get; set; }

        [InverseProperty("LastEditedBy")]
        public ICollection<OrderLines> LastEditedOrderLines { get; set; }
    }
}