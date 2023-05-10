using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositories.Models;

namespace Repositories
{
    public class Vaccine_gettingRepository : IVaccine_gettingRepository
    {

        HMO_corona_database context;

        public Vaccine_gettingRepository(HMO_corona_database context)
        {
            this.context = context;
        }
        public void Create(TblVaccineGetting objToCreate)
        {
            context.TblVaccineGetting.Add(objToCreate);
            context.SaveChanges();
        }
       

        
            public TblVaccineGetting GetByVasCust(int vID, string custID)
            {
            
             return context.TblVaccineGetting.FirstOrDefault(c => c.VaccineId == vID & c.CustomerId == custID);
           }

        public TblVaccineGetting GetById(int id)
        {
            throw new NotImplementedException();

        }
        public void Delete(int Vid, string Cid)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TblVaccineGetting> GetAll()
        {
            return context.TblVaccineGetting.ToList();
        }

        
       

        public void Update(TblVaccineGetting objToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
