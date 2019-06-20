using System;
using System.Collections.Generic;
using System.Text;

namespace KabalaCompany.DataEntity
{
    public class SupplierContactPerson
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public virtual IEnumerable<Supplier> Suppliers { get; set; }

    }
}
