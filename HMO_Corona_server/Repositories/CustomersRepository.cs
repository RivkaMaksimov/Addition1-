using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Repositories.Models;
using static System.Net.WebRequestMethods;

namespace Repositories
{
    class CustomersRepository : ICustomersRepository
    {
        HMO_corona_database context;
        public CustomersRepository(HMO_corona_database context)
        {
            this.context = context;
        }
        public void Create(TblCustomers objToCreate)
        {
            context.TblCustomers.Add(objToCreate);
            context.SaveChanges();
        }
       
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

       
        public List<TblCustomers> GetAll()
        {
            return context.TblCustomers.ToList();
        }

      
        public void Update(TblCustomers objToUpdate)
        {
            throw new NotImplementedException();
        }

        public TblCustomers GetById(string id)
        {
            return context.TblCustomers.FirstOrDefault(c => c.CustomerId == id);
        }

        public TblCustomers GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
