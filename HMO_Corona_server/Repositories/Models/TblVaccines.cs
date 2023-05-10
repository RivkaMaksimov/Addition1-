using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class TblVaccines
    {
        public TblVaccines()
        {
            TblVaccineGetting = new HashSet<TblVaccineGetting>();
        }

        public int VaccineId { get; set; }
        public string VaccineName { get; set; }
        public string ManufacturerName { get; set; }

        public virtual ICollection<TblVaccineGetting> TblVaccineGetting { get; set; }
    }
}
