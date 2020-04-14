using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompiladores.Léxico.Metodos
{
    class Tokens
    {
        private int numeroToken;
        private string sinonimoToken;
        private string nombreToken;
        private string lexemaToken;

        public int NumeroToken { get => numeroToken; set => numeroToken = value; }
        public string SinonimoToken { get => sinonimoToken; set => sinonimoToken = value; }
        public string NombreToken { get => nombreToken; set => nombreToken = value; }
        public string LexemaToken { get => lexemaToken; set => lexemaToken = value; }
    }
}
