using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CarroServico
    {
        public int Id { get; set; }
        public Carro carro { get; set; }
        public Servico servico { get; set; }
        public bool Status { get; set; }
        public CarroServico() { }
    }
}
