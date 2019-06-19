
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace KabalaCompany.DataEntity
{
    [Table(nameof(User), Schema = "Application")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Username { get; set; }

        [Required]
        [MaxLength(60)]
        public string Password { get; set; }

        public virtual IEnumerable<Employee> Employees { get; set; }

    }
}