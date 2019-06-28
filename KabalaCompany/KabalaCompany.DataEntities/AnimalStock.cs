using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KabalaCompany.DataEntities
{
    [Table(nameof(AnimalStock), Schema = "Warehouse")]
    public class AnimalStock
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public DateTime LastEditedWhen { get; set; }

        public int AnimalId { get; set; }
        public Animal Animal { get; set; }

        public int LastEditedById { get; set; }
        public User LastEditedBy { get; set; }
    }
}
