using ControleFinancas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Configuration;

namespace ControleFinancas.DAO
{
    public class ControleFinancasContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet <Movimentacao> Movimentacoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Movimentacao>().HasRequired(m => m.Usuario);
        }
    }
}