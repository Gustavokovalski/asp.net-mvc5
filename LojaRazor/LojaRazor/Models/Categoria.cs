using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaRazor.Models
{
    public class Categoria
    {
        public string Nome { get; set; }

        public Categoria(string nome)
        {
            this.Nome = nome;
        }
    }
}