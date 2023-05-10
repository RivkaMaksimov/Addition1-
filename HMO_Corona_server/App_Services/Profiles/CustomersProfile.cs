using AutoMapper;
using Common;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Services.Profiles
{
 public   class CustomersProfile:Profile
    {
        public CustomersProfile()
        {
            CreateMap<TblCustomers, CCustomers>().ReverseMap();
        }
    }
}
