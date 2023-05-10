using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Repositories.Models;

namespace Repositories
{
    public class VaccinesRepository : IVaccinesRepository
    {
        HMO_corona_database context;
        public VaccinesRepository(HMO_corona_database context)
        {
            this.context = context;
        }
        public void Create(TblVaccines objToCreate)
        {
            context.TblVaccines.Add(objToCreate);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
           /* context.TblVaccines.Remove(GetById(id));
            context.SaveChanges();*/
        }

        
        public List<TblVaccines> GetAll()
        {
            return context.TblVaccines.ToList();
            /*.Include(c => c.CategoryId)*/
        }

        public TblVaccines GetById(int id)
        {
           
            return context.TblVaccines.FirstOrDefault(c => c.VaccineId == id);
        }

     
        public void Update(TblVaccines objToUpdate)
        {
            context.TblVaccines.Update(objToUpdate);
            context.SaveChanges();
        }

        
    }
}
