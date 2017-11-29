using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeorEsCasarse.API.Models
{
    public class Frase
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public int Autor { get; set; }
        public DateTime Fecha { get; set; }
        public int Likes { get; set; }
        List<Comentario> Comentarios {get; set;}

        public Frase()
        {

        }
}
}
