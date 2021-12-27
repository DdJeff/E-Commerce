using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]  
    public class ProductController : ControllerBase
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public string GetAllProducts()
        {
            return "Hello Jesus";
        }
    }
}
