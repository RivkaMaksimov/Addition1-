using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Services
{
    public interface IVaccine_gettingService
    {
        List<CVaccine_getting> GetList();
        CVaccine_getting GetVaccine_gettingByVasCust(int vID, string custID);
        void AddVaccine_getting(CVaccine_getting objToCreate);
        void deleteVaccine_getting(int vID, string custID);
        void UpdateVaccine_getting(CVaccine_getting objToUpDate);
    }
}
