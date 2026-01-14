using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GonzabaNMC_6_EndpointsEightToTen.Services;
using Microsoft.AspNetCore.Mvc;

namespace GonzabaNMC_6_EndpointsEightToTen.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerService _restaurantPickerService;
        public RestaurantPickerController(RestaurantPickerService restaurantPickerService)
        {
            _restaurantPickerService=restaurantPickerService;
        }
    [HttpPost("Picker/{Category}")]
    public string Picker(string Category)
    {
        return _restaurantPickerService.Picker(Category);
    }
    }
