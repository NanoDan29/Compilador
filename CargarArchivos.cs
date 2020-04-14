using ExcelDataReader;
using Newtonsoft.Json;
using ProyectoCompiladores.Léxico.Metodos;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompiladores.Léxico
{
    class CargarArchivos
    {

        string lexico = Path.GetFullPath("../../Archivos/Lexico");

        public DataTable matrizTransicion()
        {
            FileStream fileStream;
           
            Console.WriteLine(lexico);
            string path = lexico + "\\MatrizTransiciones.xlsx";
            fileStream = File.Open(path, FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateReader(fileStream);
            var result = reader.AsDataSet();
            fileStream.Close();
            reader.Close();
            return result.Tables[0];
        }

        public List<Tokens> listaTokens()
        {
            string path = lexico + "\\Alfabeto.json";
            List<Tokens> listaTokens = new List<Tokens>();
            string archivo = File.ReadAllText(path);
            listaTokens = JsonConvert.DeserializeObject<List<Tokens>>(archivo);
            return listaTokens;
        }
    }
}
