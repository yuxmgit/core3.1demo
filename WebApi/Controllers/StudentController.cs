using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using WebApi.InterFace;

namespace WebApi.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly ILogger<StudentController> _logger;
        private readonly IConfiguration _iConfiguration;
        private readonly IUserService _iUserService;


        public StudentController(ILogger<StudentController> logger,IConfiguration iConfiguration, IUserService iUserService)
        {

            _logger = logger;
            _iConfiguration = iConfiguration;
            _iUserService = iUserService;
        }

        [HttpGet]
        public string Get()
        {
          var boolean=  _iUserService.Sayhellow();
          return "Tom";
        }

        [HttpPost]
        public void Post()
        {

        }

        [HttpPut]
        public void Put()
        {

        }

        [HttpDelete]
        public void Delete()
        {

        }
    }
}
