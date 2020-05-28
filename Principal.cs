
using System;

using System.Windows.Forms;

using ProyectoCompiladores.Léxico.Views;

namespace ProyectoCompiladores
{
    public partial class Principal : Form
    {
    


        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    dt = matrizTransicion();
        //    tblTrancisiones.DataSource = dt;
        //    int columnas = tblTrancisiones.ColumnCount;
        //    int filas= tblTrancisiones.RowCount;
        //    Console.WriteLine(filas + "  "+columnas);
        //    matriz(filas,columnas);
        //}

        //private DataTable matrizTransicion()
        //{
        //    FileStream fileStream;
        //    var lexico = Path.GetFullPath("../../Archivos/Lexico");
        //    Console.WriteLine(lexico);
        //    string path = lexico + "\\MatrizTransiciones.xlsx";
        //    fileStream = File.Open(path, FileMode.Open, FileAccess.Read);
        //    var reader = ExcelReaderFactory.CreateReader(fileStream);
        //    var result = reader.AsDataSet();
        //    fileStream.Close();
        //    reader.Close();
          
        //    return result.Tables[0];

        //}

        //public void matriz(int filas=0, int columnas=0) {

        //    Console.WriteLine(filas + "  "+columnas);
        //    q = new string[filas-1, columnas];
        //    for (int i = 0; i < q.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < q.GetLength(1); j++)
        //        {
        //            q[i, j] = Convert.ToString(dt.Rows[i][j]);
                   
        //        }
              
        //    }
        //    Console.WriteLine(q);
        //}

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TblTrancisiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            contenedor.Controls.Clear();
            winLexico winlexico = new winLexico();
            contenedor.Controls.Add(winlexico);
            winlexico.BringToFront();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
