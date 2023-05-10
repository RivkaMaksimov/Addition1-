using AutoMapper;
using Common;
using Repositories;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Services
{
    public class CustomersService : ICustomersService
    {
        ICustomersRepository repo;
        IMapper mapper;
        public CustomersService(ICustomersRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }
       
        public void AddCustomer(CCustomers objToCreate)
        {
            TblCustomers customer = mapper.Map<TblCustomers>(objToCreate);
            repo.Create(customer);
        }

        public List<CCustomers> GetList()
        {
            List<CCustomers> custList = new List<CCustomers>();

            foreach (var item in repo.GetAll())
            {
                CCustomers ccust = mapper.Map<TblCustomers, CCustomers>(item);
                custList.Add(ccust);

            }
            return custList;
        }

        public CCustomers GetCustById(string id)
        {

            CCustomers custC = mapper.Map<TblCustomers, CCustomers>(repo.GetById(id));

            return custC;
        }
    }

  

    
}
