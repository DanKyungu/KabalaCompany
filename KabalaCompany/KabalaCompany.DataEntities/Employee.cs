using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KabalaCompany.DataEnties
{
    [Table(nameof(Employee),Schema = "HR")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }

        [MaxLength(50)]
        public string PreferedName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [MaxLength(35)]
        public string Email { get; set; }

        [Required]
        public DateTime HiredDate { get; set; }

        [Required]
        public DateTime TerminationDate { get; set; } = new DateTime(9999, 12, 30);

        public int UserId { get; set; }
        public User User { get; set; }
       

    }
}
