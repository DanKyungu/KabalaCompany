using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KabalaCompany.DataEnties
{
    [Table(nameof(OrderLines), Schema = "Sales")]
    public class OrderLines
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(100)]
        [Required]
        public string Description { get; set; }

        [Required]
        public int OrderQuantity { get; set; }

        [Required]
        public double UnitPrice { get; set; }

        [Required]
        public DateTime LastEditedWhen { get; set; }

        public int LastEditedById { get; set; }
        public User LastEditedBy { get; set; }

        public int OrderId { get; set; }
        public Orders Order { get; set; }

        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
    }
}
