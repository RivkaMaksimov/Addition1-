using App_Services;
using Common;
using Microsoft.AspNetCore.Mvc;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMO_corona_database.Controllers
{
    [Route("api/[controller]")]
   // [ApiController]
    public class TblVaccinesController : ControllerBase
    {
        IVaccinesService service;
        public TblVaccinesController(IVaccinesService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("GetAll")]
        public List<CVaccines> GetAll()
        {
           
            return service.GetList();
        }


      //  [HttpGet]
       /// [Route("GetById/{id}")]
        [HttpGet("{id}")]
        public CVaccines GetById(int id)
        {

            return service.GetVaccineById(id);
        }

        [HttpPut]
        [Route("Create")]
        public List<CVaccines> Create( [FromBody] CVaccines objToCreate)
        {
            service.AddVaccine(objToCreate);
            return GetAll();


        }
        [HttpPut]
        [Route("Update")]
        public List<CVaccines> Update([FromBody] CVaccines objToUpDate)
        {

            service.UpdateVaccine(objToUpDate);
            return GetAll();
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public List<CVaccines> Delete(int id)
        {
            service.deleteVaccine(id);
            return GetAll();
        }

    }
}
