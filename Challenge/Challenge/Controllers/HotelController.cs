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
    public class HotelController : Controller
    {
        private readonly IHotelService _hotelService;

        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }


        // TODO: pasar los valores por params
        [HttpGet]
        public async Task<List<Record>> GetHotels()
        {
            return await _hotelService.GetHotels();
        }
    }
}
