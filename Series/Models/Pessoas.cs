using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Series.Models
{
    public class Pessoas
    {
        [Key]
        public int PessoaId { get; set; }

        public string PessoaNome { get; set; }
        
        public string Img { get; set; }

        public string Link { get; set; }

        public string Role { get; set; }

        public string Texto { get; set; }

        public string DataNasc { get; set; }

        public virtual ICollection<Projetos> ListaProjetos { get; set; }
    }
}