using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KabalaCompany.DataEntity
{
    [Table(nameof(Supplier), Schema = "Supplier")]
    public class Supplier
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(60)]
        [Required]
        public string SupplierName { get; set; }

        [MaxLength(60)]
        [Required]
        public string BankAccountNumber { get; set; }

        [MaxLength(60)]
        [Required]
        public string BankName { get; set; }

        [MaxLength(60)]
        [Required]
        public string PhysicalAddress { get; set; }

        public int PrimaryContactPersonId { get; set; }
        public SupplierContactPerson PrimaryContactPerson { get; set; }

        public int AlternativeContactPersonId { get; set; }
        public SupplierContactPerson AlternativeContactPerson { get; set; }

        public IEnumerable<PurchaseOrders> PurchaseOrders { get; set; }
        public IEnumerable<AnimalSupplier> AnimalSuppliers { get; set; }
    }
}
