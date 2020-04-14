using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompiladores.Léxico.Metodos
{
    class movimientos
    {
        private string estadoInicial, leyendo, estadoFinal;

        public string EstadoInicial { get => estadoInicial; set => estadoInicial = value; }
        public string Leyendo { get => leyendo; set => leyendo = value; }
        public string EstadoFinal { get => estadoFinal; set => estadoFinal = value; }
    }
}
