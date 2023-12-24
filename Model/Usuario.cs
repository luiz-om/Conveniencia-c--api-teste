using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conveniencia.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataCriacaoAcesso { get; set; }

        public DateTime DataDesativacaoAcesso{ get; set; }
    }
}