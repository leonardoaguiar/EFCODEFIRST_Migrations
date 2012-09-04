using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using EFCODEFIRST_Migrations.Migrations;

namespace EFCODEFIRST_Migrations
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Gente> Gente { get; set; }

        public Contexto()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Contexto, Configuration>());
        }
    }
}
