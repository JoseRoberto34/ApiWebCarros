using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Web.Carros.Data;
using Api.Web.Carros.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Web.Carros.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CarrosController : ControllerBase
    {
        private ApplicationDbContext _context;
        public CarrosController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Carro> Get()
        {
            return _context.Carros;
        }
        [HttpPost]
        public IActionResult Post(Carro carro)
        {
            if(carro != null)
            {
                _context.Carros.Add(carro);
                _context.SaveChanges();
                return Ok("Carro Adicionado na garagema");
            }
            return BadRequest();
        }
    }
}
