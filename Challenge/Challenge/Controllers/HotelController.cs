using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.Controllers
{
    [Route ("api/[controller]")]
    public class HotelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
