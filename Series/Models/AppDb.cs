using System;
using System.Collections.Generic;
using System.Data.Entity;

using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Series.Models
{
    public class AppDb : DbContext
    {

        public AppDb() : base("AppDb")
        { }

        public virtual DbSet<Series> Series { get; set; }

        public virtual DbSet<Detalhes> Detalhes { get; set; }

        public virtual DbSet<Episodios> Episodios { get; set; }

        public virtual DbSet<Videos> Videos { get; set; }

        public virtual DbSet<Pessoas> Pessoas { get; set; }

        public virtual DbSet<Projetos> Projetos { get; set; }


    }
}
