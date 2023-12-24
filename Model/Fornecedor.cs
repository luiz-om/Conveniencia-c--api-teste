using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conveniencia.Model
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }



        public IList<Produto> Produtos { get; set; } 
    }
}