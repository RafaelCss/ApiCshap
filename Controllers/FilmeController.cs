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
        public void AdicionaFilme ([FromBody]Filmess filme)
        {   
           filme.Id =Id++;   
           filmes.Add(filme);
          
        }
        [HttpGet]
        public IEnumerable<Filmess> ConsultarFilmes()
        {

            return filmes;
        }

        [HttpGet("{id}")]
        public Filmess RecuperaFilmesPorId(int id)
        {
            return filmes.FirstOrDefault(filme => filme.Id == id);
        }
    }
}