using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GonzabaNMC_6_EndpointsEightToTen.Services;
using Microsoft.AspNetCore.Mvc;

namespace GonzabaNMC_6_EndpointsEightToTen.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class Magic8BallController : ControllerBase
    {
        private readonly Magic8BallService _magic8BallService;
        public Magic8BallController(Magic8BallService magic8BallService)
        {
            _magic8BallService=magic8BallService;
        }
        [HttpPost("Fortune/{Question}")]
        public string Fortune(string Question)
    {
        return _magic8BallService.Fortune(Question);
    }

    }
