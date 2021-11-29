using System.ComponentModel.DataAnnotations;

namespace Filmes.Models
{

    public class Filmess
    { 


        public int Id {get; set;}

        [Required(ErrorMessage = "Este Campo é Obrigatorio")]
        public string Titulo {get; set;}
        [Required(ErrorMessage = "Este Campo é Obrigatorio")]
        public string Diretor {get; set;}
        public string Genero { get; set; }
        [Range(1,400, ErrorMessage ="Duração deve ter no máximo 1min")]
        public int Duracao { get; set; }
        
                 
    }

}