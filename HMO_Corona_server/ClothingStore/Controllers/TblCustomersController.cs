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


    
    public class TblCustomersController: ControllerBase
    {
        ICustomersService service;
        public TblCustomersController(ICustomersService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("GetAll")]
        public List<CCustomers> GetAll()
        {

            return service.GetList();
        }

        [HttpPut]
        [Route("Create")]
        public List<CCustomers> Create([FromBody] CCustomers objToCreate)
        {

            service.AddCustomer(objToCreate);
            return GetAll();

        }
        [HttpGet("{id}")]
        public CCustomers GetById(string id)
        {

            return service.GetCustById(id);
        }



    }
}
