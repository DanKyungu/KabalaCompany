using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KabalaCompany.DataEnties
{
    [Table(nameof(AnimalSupplier), Schema = "Sales")]
    public class AnimalSupplier
    {
        [Required]
        public int Id { get; set; }

        public int AnimalId { get; set; }
        public Animal Animal { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}
