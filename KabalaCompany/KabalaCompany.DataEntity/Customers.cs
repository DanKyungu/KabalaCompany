using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KabalaCompany.DataEntity
{
    [Table(nameof(Customers), Schema = "Sales")]
    public class Customers
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(60)]
        [Required]
        public string CustomerName { get; set; }

        [MaxLength(60)]
        [Required]
        public string CustomerBankAccount { get; set; }

        [MaxLength(60)]
        [Required]
        public string CustomerBankName { get; set; }

        [MaxLength(10)]
        [Required]
        public string PhoneNumber { get; set; }

        [MaxLength(60)]
        [Required]
        public string EmailAddress { get; set; }

        [MaxLength(65)]
        [Required]
        public string CustomerAddress { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
