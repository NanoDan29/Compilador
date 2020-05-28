using ProyectoCompiladores.Léxico.Clases;
using System;
using System.Data;
using System.Windows.Forms;


namespace ProyectoCompiladores.Léxico.Views
{
    public partial class winLexico : UserControl
    {
        DataTable dt;
        CargarArchivos cargarArvhivos = new CargarArchivos();
        MatrizTransicion matriz = new MatrizTransicion();

        public winLexico()
        {
            InitializeComponent();
            dt = tomarMatrizTransicion();
            matriz.matrizTransicion(dt);

            tblPrifil.DataSource = matriz.matrizPrifil();
            tblValor.DataSource = matriz.matrizValor();
            //matriz.acceso(94,53);

           
            tblAlfabeto.DataSource = cargarArvhivos.listaTokens();

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        public DataTable tomarMatrizTransicion()
        {
            dt = cargarArvhivos.matrizTransicion();
            tblTrancisiones.DataSource = dt;
            return dt;
        }

        private void TblTrancisiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WinLexico_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TblAlfabeto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

           
            String cadenaTxt = txtLexico.Text;
            String cadenaTransformada = "";
            String[] vectorCadena = cadenaTxt.Split('\n');

            for (int i = 0; i < vectorCadena.Length; i++)
            {
                if (vectorCadena[i] != "")
                {
                    cadenaTransformada += vectorCadena[i] + " ";
                }
            }
            vectorCadena = cadenaTransformada.Split(' ');
            cadenaTransformada = "";

            for (int i = 0; i < vectorCadena.Length; i++)
            {
                if (vectorCadena[i] != "")
                {
                    cadenaTransformada += vectorCadena[i] + "$";
                }
                
            }
            tblMovimientos.DataSource = matriz.movimientos(cadenaTransformada);









        }
    }
}
