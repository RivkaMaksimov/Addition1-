using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public interface ICustomersRepository:IRepository<TblCustomers>
    {
        TblCustomers GetById(string id);
    }
}
