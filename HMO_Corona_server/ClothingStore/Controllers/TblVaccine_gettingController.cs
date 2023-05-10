using App_Services;
using Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMO_corona_database.Controllers
{
    [Route("api/[controller]")]
    // [ApiController]
    public class TblVaccine_gettingController : ControllerBase
    {
        IVaccine_gettingService service;
        public TblVaccine_gettingController(IVaccine_gettingService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("GetAll")]
        public List<CVaccine_getting> GetAll()
        {

            return service.GetList();
        }

       
        [HttpGet("{vID}/{custID}")]
        public CVaccine_getting GetVaccine_gettingByVasCust(int vID, string custID)
        {

            return service.GetVaccine_gettingByVasCust(vID, custID);
        }

        [HttpPost]
        [Route("Create")]
        public List<CVaccine_getting> Create([FromBody] CVaccine_getting objToCreate)
        {
            service.AddVaccine_getting(objToCreate);
            return GetAll();


        }
        [HttpPut]
        [Route("Update")]
        public List<CVaccine_getting> Update([FromBody] CVaccine_getting objToUpDate)
        {

            service.UpdateVaccine_getting(objToUpDate);
            return GetAll();
        }

        [HttpDelete]
        [Route("Delete/{Vid}/{Cid}")]
        public List<CVaccine_getting> Delete(int Vid, string Cid)
        {
            service.deleteVaccine_getting(Vid, Cid);
            return GetAll();
        }

    }
}
