using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KabalaCompany.DataEntity
{
    [Table(nameof(SupplierContactPerson),Schema = "Supplier")]
    public class SupplierContactPerson
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(60)]
        [Required]
        public string FullName { get; set; }

        [MaxLength]
        [Required]
        public string PhoneNumber { get; set; }

        [MaxLength]
        [Required]
        public string EmailAddress { get; set; }

        public virtual IEnumerable<Supplier> PrimarySuppliers { get; set; }

        public virtual IEnumerable<Supplier> AlternativeSuppliers { get; set; }

    }
}
