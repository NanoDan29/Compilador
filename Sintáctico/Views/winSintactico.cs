
using ProyectoCompiladores.Léxico;
using ProyectoCompiladores.Sintáctico.Clases;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoCompiladores.Sintáctico.Views
{
    public partial class winSintactico : UserControl
    {

        CargarArchivos misArchivos = new CargarArchivos();
        AnalizadorGramatica miAnalizador = new AnalizadorGramatica();


        public winSintactico()
        {
            InitializeComponent();
            cargarArchivos();
        }

        public void cargarArchivos()
        {
            tblReglasGramaticles.DataSource = misArchivos.listaReglas();
            tblAction.DataSource = misArchivos.matrizAction();
            tblGoTo.DataSource = misArchivos.matrizGoTo();
            tblFirst.DataSource = misArchivos.ListaFirst();
            tblNext.DataSource = misArchivos.ListaNext();
            tblTokensReconocidosS.DataSource = misArchivos.listaTokensReconocidos();
            miAnalizador.matrizLALR = misArchivos.MatrizEntera();
            miAnalizador.reglasGramaticales = misArchivos.listaReglas();

            miAnalizador.llenarPilaSintactica(misArchivos.listaTokensReconocidos());

            miAnalizador.analizadorLALR();

            tblPila.DataSource = miAnalizador.listaPila;
            tblEntrada.DataSource = miAnalizador.listaEntrada;
            tblAccion.DataSource = miAnalizador.listaAccion;


        }


        private void tblAction_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (e.RowIndex != 0 && e.ColumnIndex != 0)   //Si el valor de la celda contiene la palabra hora
            {
                if (Convert.ToInt32(e.Value) >= 200)
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Red;
                }
                else if (Convert.ToInt32(e.Value) < 0)
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Green;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Orange;
                }

            }
        }

        private void tblGoTo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (e.RowIndex != 0 && e.ColumnIndex != 0)   //Si el valor de la celda contiene la palabra hora
            {
                if (Convert.ToInt32(e.Value) >= 200)
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Red;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Green;
                }

            }
        }
    }
}
