using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeorEsCasarse.API.Models;

namespace PeorEsCasarse.API.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/Frase")]
    public class FraseController : Controller
    {
        [HttpGet]
        public IEnumerable<Frase> Get()
        {
            List<Frase> vRetorno = new List<Frase>();
            vRetorno.Add(new Frase { Texto = "Hola don pepito", Autor = 1, Fecha = DateTime.Now, Id = 1 });
            return vRetorno;
        }

        [HttpGet(Name = "ObtenerFrases")]
        public IEnumerable<Frase> ObtenerFrases()
        {
            List<Frase> vRetorno = new List<Frase>();
            vRetorno.Add(new Frase { Texto = "Hola don pepito", Autor = 1, Fecha = DateTime.Now, Id = 1 });
            return vRetorno;
        }

        [HttpGet("{id}", Name = "GetFrase")]
        public IActionResult GetById(long id)
        {
            var item = new Frase { Texto = "Hola don pepito", Autor = 1, Fecha = DateTime.Now, Id = 1 };//_context.TodoItems.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            return new ObjectResult(item);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult AltaFrase([FromBody] Frase item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            /*_context.TodoItems.Add(item);
            _context.SaveChanges();*/

            item.Id = 2;

            return CreatedAtRoute("GetFrase", new { id = item.Id }, item);
        }
              
    }
}