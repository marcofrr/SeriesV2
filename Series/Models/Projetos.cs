using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Series.Models
{
    public class Projetos
    {
        [Key]
        public int ProjetoId { get; set; }

        public string Titulo { get; set; }

        public string Ano { get; set; }

        public string Img { get; set; }

        public string Link { get; set; }
    }
}