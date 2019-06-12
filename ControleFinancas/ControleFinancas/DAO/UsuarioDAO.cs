using ControleFinancas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleFinancas.DAO
{
    public class UsuarioDAO
    {
        private ControleFinancasContext context;

        public UsuarioDAO(ControleFinancasContext context)
        {
            this.context = context;
        }
        public void Adiciona(Usuario usuario)
        {
            context.Usuarios.Add(usuario);
            context.SaveChanges();
        }
        public IList<Usuario> Lista()
        {
            return context.Usuarios.ToList();
        }
    }
}