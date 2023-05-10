using AutoMapper;
using Common;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace App_Services.Profiles
{
  public  class Corona_diseaseProfile : Profile
    {
        public Corona_diseaseProfile()
        {
            CreateMap<TblCoronaDisease, CCorona_disease>().ReverseMap();
        }
       
    }
}
