using Common;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Services
{
   public interface IVaccinesService
    {
        List<CVaccines> GetList();
        CVaccines GetVaccineById(int id);
        void AddVaccine(CVaccines objToCreate);
        void deleteVaccine(int id);
        void UpdateVaccine(CVaccines objToUpDate);



    }
}
