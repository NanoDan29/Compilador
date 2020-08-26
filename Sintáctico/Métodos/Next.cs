using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompiladores.Sintáctico.Métodos

{
    class Next
    {
        private int numeroNext;
        private string parteIzquierda, parteDerecha;

        public int NumeroFirst { get => numeroNext; set => numeroNext = value; }
        public string ParteIzquierda { get => parteIzquierda; set => parteIzquierda = value; }
        public string ParteDerecha { get => parteDerecha; set => parteDerecha = value; }
    }
}
