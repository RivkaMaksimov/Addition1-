using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
 public   interface IVaccine_gettingRepository : IRepository<TblVaccineGetting>
    {
        void Delete(int Vid, string Cid);

        TblVaccineGetting GetByVasCust(int vID, string custID);
    }
}
