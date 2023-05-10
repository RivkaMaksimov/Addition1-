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
    
     [ApiController]
    public class TblCorona_diseaseController : ControllerBase
    {
        ICorona_diseaseService service;
        public TblCorona_diseaseController(ICorona_diseaseService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("GetAll")]
        public List<CCorona_disease> GetAll()
        {

            return service.GetDiseasesList();
        }

      // [HttpGet]
      // [Route("GetById/{id}")]
       [HttpGet("{id}")]
        public CCorona_disease GetById(int id)
        {

            return service.GetDiseaseById(id);
        }

        

        [HttpPut]
        [Route("Create")]
        public List<CCorona_disease> Create([FromBody] CCorona_disease objToCreate)
        {
            service.AddDisease(objToCreate);
            return GetAll();
        }
        [HttpPut]
        [Route("Update")]
        public List<CCorona_disease> Update([FromBody] CCorona_disease objToUpDate)
        {

            service.UpdateDisease(objToUpDate);
            return GetAll();
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public List<CCorona_disease> Delete(int id)
        {
            service.deleteDisease(id);
            return  GetAll();
        }

    }
}
