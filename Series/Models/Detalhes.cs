using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Series.Models
{
    public class Detalhes
    {
        
        public int SerieId { get; set; }
        [Key]
        public string Nome { get; set; }

        public int Temporadas { get; set; }

        public int NEpisodios { get; set; }

        public string Realizador { get; set; }

        public string Elenco { get; set; }

        public string Desc { get; set; }

        public string SerieImg { get; set; }

        public int Rating { get; set; }

        public string Link { get; set; }

        public virtual ICollection<Episodios> ListaEpisodios { get; set; }

        public virtual ICollection<Videos> ListaDeVideos { get; set; }
        //public virtual ICollection<Episodios> ListaDeEpisodios { get; set; }
    }
}