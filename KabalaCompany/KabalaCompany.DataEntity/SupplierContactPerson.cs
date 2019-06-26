using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KabalaCompany.DataEntity
{
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

        public virtual IEnumerable<Supplier> Suppliers { get; set; }

    }
}
