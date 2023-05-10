using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class TblVaccineGetting
    {
        public int VaccineId { get; set; }
        public string CustomerId { get; set; }
        public DateTime? GettingDate { get; set; }

       public virtual TblCustomers Customer { get; set; }
       
        public virtual TblVaccines Vaccine { get; set; }
    }
}
