using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public Cor Cor { get; set; }
        public Modelo Modelo { get; set; }
        public Combustivel Combustivel { get; set; }
        public Cambio Cambio { get; set; }
        public int Ano { get; set; }
        public string Observacao { get; set; }
    }
}
