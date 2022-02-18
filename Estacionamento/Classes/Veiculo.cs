using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estacionamento.Classes
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public string Descricao { get; set; }
        public string ClienteNome { get; set; }
        public string ClienteTelefone { get; set; }
        public int EstacionadoNaVaga { get; set; }
    }
}
