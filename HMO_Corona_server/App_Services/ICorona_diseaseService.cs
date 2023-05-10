using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Services
{
   public  interface ICorona_diseaseService
    {
        List<CCorona_disease> GetDiseasesList();
        CCorona_disease GetDiseaseById(int id);
        void AddDisease(CCorona_disease objToCreate);
        void deleteDisease(int id);
        void UpdateDisease(CCorona_disease objToUpDate);

    }
}
