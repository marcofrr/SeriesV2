using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Series.Models
{
    public class Episodios
    {
        [Key]
        public int EpisodioId { get; set; }

        public int NEpisodio { get; set; }

        public int Temporada { get; set; }

        public string Img { get; set; }

        public int SerieId { get; set; }

        public string Episodio { get; set; }

        public string Titulo { get; set; }
    }
}