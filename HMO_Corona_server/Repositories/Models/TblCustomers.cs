using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class TblCustomers
    {
        public TblCustomers()
        {
            TblCoronaDisease = new HashSet<TblCoronaDisease>();
            TblVaccineGetting = new HashSet<TblVaccineGetting>();
        }

        public string CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerAddress { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }

        public virtual ICollection<TblCoronaDisease> TblCoronaDisease { get; set; }
        public virtual ICollection<TblVaccineGetting> TblVaccineGetting { get; set; }
    }
}
