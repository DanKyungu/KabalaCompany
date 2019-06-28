using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KabalaCompany.DataEntity
{
    [Table(nameof(Animal),Schema = "Warehouse")]
    public class Animal
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(60)]
        [Required]
        public string AnimalName { get; set; }

        [MaxLength(60)]
        [Required]
        public int MinimumWeight { get; set; }

        [MaxLength(60)]
        [Required]
        public int MaximumWeight { get; set; }

        [MaxLength(60)]
        [Required]
        public double PricePerKg { get; set; }

        [MaxLength(60)]
        [Required]
        public double RetailPricePerKg { get; set; }

        public virtual IEnumerable<AnimalStock> AnimalStocks { get; set; }
        public virtual IEnumerable<OrderLines> OrderLines { get; set; }

        public virtual IEnumerable<PurchaseOrderLines> PurchaseOrderLines { get; set; }
        public virtual IEnumerable<AnimalSupplier> AnimalSuppliers { get; set; }
    }
}
