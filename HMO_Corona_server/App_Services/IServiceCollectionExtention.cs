using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Services
{
   public static class  IServiceCollectionExtention
    {
        public static IServiceCollection AddServices(this IServiceCollection serviceCollection, IConfiguration config)
        {

            
             serviceCollection.AddScoped<IVaccinesService, VaccinesService>();
             serviceCollection.AddScoped<ICustomersService, CustomersService>();
             serviceCollection.AddScoped<ICorona_diseaseService, Corona_diseaseService>();
             serviceCollection.AddScoped<IVaccine_gettingService, Vaccine_gettingService>();

               serviceCollection.AddRepository(config);
         
            return serviceCollection;
        }
    }
}
