using ControleFinancas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleFinancas.Models
{
    public class MovimentacoesPorUsuarioModel
    {
        public int? UsuarioId { get; set; }
        public IList<Movimentacao> Movimentacoes { get; set; }
        public IList<Usuario> Usuarios { get; set; }
    }
}