using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Common;
using Repositories;
using Repositories.Models;

namespace App_Services
{
    public class Vaccine_gettingService : IVaccine_gettingService
    {
        IVaccine_gettingRepository repo;
        IMapper mapper;
        public Vaccine_gettingService(IVaccine_gettingRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public void AddVaccine_getting(CVaccine_getting objToCreate)
        {
            TblVaccineGetting vg = mapper.Map<TblVaccineGetting>(objToCreate);
            repo.Create(vg);
        }

        public void deleteVaccine_getting(int vID, string custID)
        {
            repo.Delete(vID, custID);
        }

        public void UpdateVaccine_getting(CVaccine_getting objToUpDate)
        {
            TblVaccineGetting vg = mapper.Map<TblVaccineGetting>(objToUpDate);
            repo.Update(vg);
        }
        public CVaccine_getting GetVaccine_gettingByVasCust(int vID, string custID)
        {

            CVaccine_getting vgC = mapper.Map<TblVaccineGetting, CVaccine_getting>(repo.GetByVasCust(vID, custID));

            return vgC;
        }


        public List<CVaccine_getting> GetList()
        {
            List<CVaccine_getting> vaccines_gList = new List<CVaccine_getting>();

            foreach (var item in repo.GetAll())
            {
                CVaccine_getting CVG = mapper.Map<TblVaccineGetting, CVaccine_getting>(item);
                vaccines_gList.Add(CVG);

            }
            return vaccines_gList;
        }

    }
}
