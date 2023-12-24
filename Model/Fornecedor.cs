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
        public int MyProperty { get; set; }
        public bool Ativo { get; set; }
        


        public List<Produto> Produtos { get; set; } = new();
    }
}