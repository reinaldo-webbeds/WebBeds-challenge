using Challenge.Services;
using Microsoft.AspNetCore.Mvc;
using PruebaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.Controllers
{
    [Route ("api/[controller]")]
    public class HotelsController : Controller
    {
        private readonly IHotelService _hotelService;

        public HotelsController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }


        
        [HttpGet]
        public async Task<ActionResult<List<Record>>> GetHotels(int nights, int destinationId)
        {
            var hotels = await _hotelService.GetHotels(nights, destinationId);
            if (hotels.Any())
            {
                return Ok(hotels);
            }

            return NotFound(hotels);
        }
    }
}
