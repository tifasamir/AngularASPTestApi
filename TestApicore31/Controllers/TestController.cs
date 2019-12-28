

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApicore31.Data;
using TestApicore31.Models;

namespace TestApicore31.Controllers
{
    [Route("api/test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        TestDataAccessLayer objemployee = new TestDataAccessLayer();

        [HttpGet]
        [Route("")]
        public IEnumerable<Tbl001> Index()
        {
            return objemployee.GetAllEmployees();
        }

        [HttpPost]
        [Route("create")]
        public int Create([FromBody] Tbl001 employee)
        {
            return objemployee.AddEmployee(employee);
        }

        [HttpGet]
        [Route("details/{id}")]
        public Tbl001 Details(long id)
        {
            return objemployee.GetEmployeeData(id);
        }

        [HttpPut]
        [Route("edit/{id}")]
        public int Edit([FromBody]Tbl001 employee)
        {
            return objemployee.UpdateEmployee(employee);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public int Delete(int id)
        {
            return objemployee.DeleteEmployee(id);
        }

        //[HttpGet]
        //[Route("api/Employee/GetCityList")]
        //public IEnumerable<TblCities> Details()
        //{
        //    return objemployee.GetCities();
        //}
    }
}
