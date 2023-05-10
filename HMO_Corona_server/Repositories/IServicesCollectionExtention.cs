using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
  public static  class IServicesExtentionCollection
    {
        public static IServiceCollection AddRepository(this IServiceCollection serviceCollection, IConfiguration config)
        {
           
           serviceCollection.AddScoped<ICorona_diseaseRepository, Corona_diseaseRepository>();
           serviceCollection.AddScoped<ICustomersRepository, CustomersRepository>();
         
            serviceCollection.AddScoped<IVaccinesRepository, VaccinesRepository>();
            serviceCollection.AddScoped<IVaccine_gettingRepository, Vaccine_gettingRepository>();
         

            //serviceCollection.AddDbContext<HMO_corona_database>(opt => opt.UseSqlServer(config.GetConnectionString("HMO_corona_databaseConnection")));
            serviceCollection.AddDbContext<HMO_corona_database>(opt => opt.UseSqlServer(@"Data Source=den1.mssql7.gear.host;Initial Catalog=hmocoronadb;User ID=hmocoronadb;Password=Dt9t_F-AtpkV"));
              return serviceCollection;
        }
    }
}
