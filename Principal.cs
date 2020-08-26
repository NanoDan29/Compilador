
using System;

using System.Windows.Forms;
using ProyectoCompiladores.Léxico;
using ProyectoCompiladores.Léxico.Views;
using ProyectoCompiladores.Sintáctico.Métodos;
using ProyectoCompiladores.Sintáctico.Views;

namespace ProyectoCompiladores
{
    public partial class Principal : Form
    {

        CargarArchivos misArchivos = new CargarArchivos();
        winLexico winlexico;
        winSintactico winsintactico;


        public Principal()
        {
            InitializeComponent();
            winlexico = new winLexico();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            misArchivos.listaReglas();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            contenedor.Controls.Clear();
            contenedor.Controls.Add(winlexico);
            winlexico.BringToFront();
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            winsintactico = new winSintactico();
            contenedor.Controls.Clear();
            contenedor.Controls.Add(winsintactico);
            winsintactico.BringToFront();
        }   
    }
}
