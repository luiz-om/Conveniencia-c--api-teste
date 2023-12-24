using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conveniencia.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Estoque { get; set; }
        public decimal Preco { get; set; }
      public bool Ativo { get; set; }

        public IList<Fornecedor> Fornecedors { get; set; } = new();
    }
}