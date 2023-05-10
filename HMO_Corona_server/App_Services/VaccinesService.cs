using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Common;
using Repositories;
using Repositories.Models;

namespace App_Services
{
    public class VaccinesService : IVaccinesService
    {
        IVaccinesRepository repo;
        IMapper mapper;
        public VaccinesService(IVaccinesRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public void AddVaccine(CVaccines objToCreate)
        {
            TblVaccines vas = mapper.Map<TblVaccines>(objToCreate);
            repo.Create(vas);
        }

        public void deleteVaccine(int id)
        {
            repo.Delete(id);
        }

        public void UpdateVaccine(CVaccines objToUpDate)
        {
            TblVaccines vas = mapper.Map<TblVaccines>(objToUpDate);
            repo.Update(vas);
        }
        public CVaccines GetVaccineById(int id)
        {

            CVaccines vasC = mapper.Map<TblVaccines, CVaccines>(repo.GetById(id));

            return vasC;
        }


        public List<CVaccines> GetList()
        {
            List<CVaccines> vaccinesList = new List<CVaccines>();

            foreach (var item in repo.GetAll())
            {
                CVaccines CVaccines = mapper.Map<TblVaccines, CVaccines>(item);
                vaccinesList.Add(CVaccines);

            }
            return vaccinesList;
        }

    }  
    }
