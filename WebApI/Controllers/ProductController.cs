using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApI.Models;

namespace WebApI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]  
    public class ProductController : ControllerBase
    {
        private readonly IRepository repo;
        public ProductController(IRepository repository)
        {
            repo = repository;
        }
        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return repo.GetAllProducts();
        }
    }
}
