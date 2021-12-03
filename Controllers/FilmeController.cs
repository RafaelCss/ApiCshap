using Filmes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Filmes.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        
        private static List<Filmess> filmes = new List<Filmess>();
        private static int Id = 1; 

        [HttpPost]
        public IActionResult AdicionaFilme ([FromBody]Filmess filme)
        {   
           filme.Id =Id++;   
           filmes.Add(filme);
           return CreatedAtAction(nameof(RecuperaFilmesPorId), new {Id = filme.Id}, filme);
          
        }
        [HttpGet]
        public IActionResult  ConsultarFilmes()
        {
            return Ok(filmes);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaFilmesPorId(int id)
        {
            Filmess filme = filmes.FirstOrDefault(filme => filme.Id == id);
            if(filme != null)
            {
                return Ok(filme);
            }

            return NotFound();
        }
    }
}