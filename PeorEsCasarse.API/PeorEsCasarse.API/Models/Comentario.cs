using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeorEsCasarse.API.Models
{
    public class Comentario
    {
        public string Texto { get; set; }
        public int Autor { get; set; }
        public DateTime Fecha { get; set; }
    }
}
