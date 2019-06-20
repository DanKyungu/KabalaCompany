using System;
using System.Collections.Generic;
using System.Text;

namespace KabalaCompany.DataEntity
{
    public class Supplier
    {

        public int Id { get; set; }
        public string SupplierName { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankName { get; set; }
        public string PhysicalAddress { get; set; }
        public SupplierContactPerson PrimaryContactPersonId { get; set; }
        public SupplierContactPerson AlternativeContactPersonId { get; set; }

    }
}
