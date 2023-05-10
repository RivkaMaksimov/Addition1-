using AutoMapper;
using Common;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace App_Services.Profiles
{
  public  class VaccinesProfile : Profile
    {
        public VaccinesProfile()
        {
            CreateMap<TblVaccines, CVaccines>().ReverseMap();
        }
       
    }
}
