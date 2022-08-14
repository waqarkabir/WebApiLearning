using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApiLearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public EmployeeController()
        {

        }

        [HttpGet]
        public IEnumerable<string> Get()
        { 
            return new List<string>() {"Waqar Kabir"};
        }
    }
}
