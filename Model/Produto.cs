using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conveniencia.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nonme { get; set; }
        public int Estoque { get; set; }
        public double Preco { get; set; }
        public bool Ativo { get; set; }

        public List<Fornecedor> Fornecedors { get; set; } = new();
    }
}