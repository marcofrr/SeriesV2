using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Series.Models
{
    public class Videos
    {
        [Key]
        public int VideoId { get; set; }


        public string Video { get; set; }

        public string Titulo { get; set; }
    }
}