using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Series.Models
{
    public class Series
    {
        [Key]
        public int SerieId { get; set; }

        public string nomeId { get; set; }

        public string NomeSerie { get; set; }

        public string SerieImg { get; set; }


    }
}