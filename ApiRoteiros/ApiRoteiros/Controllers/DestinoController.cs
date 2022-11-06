using ApiRoteiros.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiRoteiros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinoController : ControllerBase
    {
        private readonly DestinoDbContext _context;

        public DestinoController(DestinoDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Destino> GetDestino()
        {
            return _context.Destino;
        }

       
        [HttpGet("{id}")]
        public IActionResult GetDestinoPorId(int id)
        {
            Destino Destino = _context.Destino.SingleOrDefault(modelo => modelo.Id == id);
            if (Destino == null)
            {
                return NotFound();
            }
            return new ObjectResult(Destino);
        }

        [HttpPost]
        public IActionResult CriarDestino(Destino item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _context.Destino.Add(item);
            _context.SaveChanges();
            return new ObjectResult(item);

        }

   
        [HttpPut("{id}")]
        public IActionResult AtualizaDestino(int id, Destino item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();



            return new NoContentResult();
        }

   
        [HttpDelete("{id}")]
        public IActionResult DeletaDestino(int id)
        {
            var Destino = _context.Destino.SingleOrDefault(m => m.Id == id);



            if (Destino == null)
            {
                return BadRequest();
            }


            _context.Destino.Remove(Destino);
            _context.SaveChanges();
            return Ok(Destino);
        }

    }
}
