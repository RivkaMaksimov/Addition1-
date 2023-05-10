using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class TblCoronaDisease
    {
        public int DiseaseId { get; set; }
        public string CustomerId { get; set; }
        public DateTime? PositiveResult { get; set; }
        public DateTime? RecoveryDate { get; set; }

        public virtual TblCustomers Customer { get; set; }
    }
}
