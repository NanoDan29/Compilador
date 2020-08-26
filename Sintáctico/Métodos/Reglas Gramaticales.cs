using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompiladores.Sintáctico.Métodos
{
    class ReglasGramaticales
    {
        private int numeroRegla;
        private string parteIzquierda;
        private string parteDerecha;
        private int longitud;
        private object dato;
        private string tipo;

        public int NumeroRegla { get => numeroRegla; set => numeroRegla = value; }
        public string ParteIzquierda { get => parteIzquierda; set => parteIzquierda = value; }
        public string ParteDerecha { get => parteDerecha; set => parteDerecha = value; }
        public int Longitud { get => longitud; set => longitud = value; }
        public object Dato { get => dato; set => dato = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
