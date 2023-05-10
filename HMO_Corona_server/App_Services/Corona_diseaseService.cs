using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Common;

using Repositories;
using Repositories.Models;

namespace App_Services
{
  public  class Corona_diseaseService : ICorona_diseaseService
    {
        ICorona_diseaseRepository repo;
        IMapper mapper;
        public Corona_diseaseService(ICorona_diseaseRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }
        public void AddDisease(CCorona_disease objToCreate)
        {
            TblCoronaDisease clothing = mapper.Map<TblCoronaDisease>(objToCreate);
            repo.Create(clothing);
        }

        public void deleteDisease(int id)
        {
            repo.Delete(id);
        }

        

        public CCorona_disease GetDiseaseById(int id)
        {
            CCorona_disease disease = mapper.Map<TblCoronaDisease, CCorona_disease>(repo.GetById(id));

            return disease;
        }

        public List<CCorona_disease> GetDiseasesList()
        {
            List<CCorona_disease> diseasesList = new List<CCorona_disease>();

            foreach (var item in repo.GetAll())
            {
                CCorona_disease dis = mapper.Map<TblCoronaDisease, CCorona_disease>(item);
                diseasesList.Add(dis);

            }
            return diseasesList;
        }

        public void UpdateDisease(CCorona_disease objToUpDate)
        {
            TblCoronaDisease dis = mapper.Map<TblCoronaDisease>(objToUpDate);
            repo.Update(dis);
        }
    }
}
