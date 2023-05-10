using AutoMapper;
using Common;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace App_Services.Profiles
{
    public class Vaccine_gettingProfile : Profile
    {
        public Vaccine_gettingProfile()
        {
            CreateMap<TblVaccineGetting, CVaccine_getting>().ReverseMap();
        }

    }
}
