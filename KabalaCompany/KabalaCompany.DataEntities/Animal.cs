using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KabalaCompany.DataEnties
{
    [Table(nameof(Animal),Schema = "Warehouse")]
    public class Animal
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(60)]
        [Required]
        public string AnimalName { get; set; }

        
        [Required]
        public int MinimumWeight { get; set; }

        [Required]
        public int MaximumWeight { get; set; }

        [Required]
        public double PricePerKg { get; set; }

        [Required]
        public double RetailPricePerKg { get; set; }

        public virtual ICollection<AnimalStock> AnimalStocks { get; set; }
        public virtual ICollection<OrderLines> OrderLines { get; set; }

        public virtual ICollection<PurchaseOrderLines> PurchaseOrderLines { get; set; }
        public virtual ICollection<AnimalSupplier> AnimalSuppliers { get; set; }
    }
}
