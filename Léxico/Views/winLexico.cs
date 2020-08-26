using Newtonsoft.Json;
using ProyectoCompiladores.Léxico.Clases;
using ProyectoCompiladores.Léxico.Metodos;
using ProyectoCompiladores.Sintáctico.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace ProyectoCompiladores.Léxico.Views
{
    public partial class winLexico : UserControl
    {
        DataTable dt;
        CargarArchivos cargarArvhivos = new CargarArchivos();
        MatrizTransicion matriz = new MatrizTransicion();
        String lexico = Path.GetFullPath("../../Archivos/Lexico");
        String sintactico = Path.GetFullPath("../../Archivos/Sintactico");


        public winLexico()
        {
            InitializeComponent();
            dt = tomarMatrizTransicion();
            matriz.matrizTransicion(dt);
            tblPrifil.DataSource = matriz.matrizPrifil();
            tblValor.DataSource = matriz.matrizValor();
            tblAlfabeto.DataSource = cargarArvhivos.listaTokens();
            cargarArvhivoTxt();
        }

        private void cargarArvhivoTxt()
        {
            string path = lexico + "\\archivo.txt";
            string text = File.ReadAllText(path);
            txtLexico.Text = text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            //Guardar en un txt pasar a una funcion¡¡¡¡¡
           
            string cadenaTxt = txtLexico.Text;
            string path = lexico + "\\archivo.txt";


            if (File.Exists(path))
            {
                using (StreamWriter guardarArchivo = File.CreateText(path))
                { guardarArchivo.Write(cadenaTxt); };

            }
            else
            {
                //Creamos el archivo
                StreamWriter crearArchvio = new StreamWriter(path);

                //Guardar archivo
                using (StreamWriter guardarArchivo = File.CreateText(path))
                { guardarArchivo.Write(cadenaTxt); };
            }
            //

            string cadenaTransformada = "";
            string[] vectorCadena = cadenaTxt.Split('\n');

            List<Tokens> tokensReconocidos = new List<Tokens>();
            Tokens miToken;

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

            var tokensReonocidos = cargarArvhivos.listaTokens();
            var lista = matriz.movimientos(cadenaTransformada);
            foreach (var item in lista)
            {
                if (item.EstadoFinal < 0 && item.EstadoFinal != -999)
                {
                    foreach (var item1 in tokensReonocidos)
                    {

                        if (item.EstadoFinal * -1 == item1.NumeroToken)
                        {

                            miToken = new Tokens
                            {
                                LexemaToken = item1.LexemaToken,
                                NombreToken = item1.NombreToken,
                                NumeroToken = item1.NumeroToken,
                                SinonimoToken = item1.SinonimoToken
                            };
                            tokensReconocidos.Add(miToken);
                            break;
                        }
                    }
                }

            }
            tblTokenReconocidos.DataSource = tokensReconocidos;

            //Crear funcion
            
            string json = JsonConvert.SerializeObject(tokensReconocidos);
            string path2 = sintactico + "\\TokensReconocidos.json";
            File.WriteAllText(path2, json);

        }

        public DataTable tomarMatrizTransicion()
        {
            dt = cargarArvhivos.matrizTransicion();
            tblTrancisiones.DataSource = dt;
            return dt;
        }

        private void tblTrancisiones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            DataGridView dgv = sender as DataGridView;



            if (e.RowIndex != 0 && e.ColumnIndex != 0)   //Si el valor de la celda contiene la palabra hora
            {
                if (Convert.ToInt32(e.Value) == -999)
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
    }


}
