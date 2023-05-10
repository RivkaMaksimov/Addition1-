using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Services
{
    public interface ICustomersService
    {
       
        void AddCustomer(CCustomers objToCreate);

        List<CCustomers> GetList();

        CCustomers GetCustById(string id);

    }
}
