using ControleFinancas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleFinancas.DAO
{
    public class MovimentacaoDAO
    {
        private ControleFinancasContext context;

        public MovimentacaoDAO(ControleFinancasContext context)
        {
            this.context = context;
        }
        public void Adiciona(Movimentacao movimentacao)
        {
            context.Movimentacoes.Add(movimentacao);
            context.SaveChanges();
        }
        public IList<Movimentacao> Lista()
        {
            return context.Movimentacoes.ToList();
        }
    }
}