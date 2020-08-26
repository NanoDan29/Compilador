using ExcelDataReader;
using Newtonsoft.Json;
using ProyectoCompiladores.Léxico.Metodos;
using ProyectoCompiladores.Sintáctico.Métodos;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace ProyectoCompiladores.Léxico
{
    class CargarArchivos
    {

        string lexico = Path.GetFullPath("../../Archivos/Lexico");
        string sintactico = Path.GetFullPath("../../Archivos/Sintactico");

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


        //Cargar archivs sintacticos

        public List<ReglasGramaticales> listaReglas()
        {
            string path = sintactico + "\\ReglasGramaticales.json";
            List<ReglasGramaticales> listaReglasGramaticas = new List<ReglasGramaticales>();
            string archivo = File.ReadAllText(path);
            listaReglasGramaticas = JsonConvert.DeserializeObject<List<ReglasGramaticales>>(archivo);

            return listaReglasGramaticas;
        }

        public DataTable matrizAction()
        {
            FileStream fileStream;
            string path = sintactico + "\\ActionGramatica.xlsx";
            fileStream = File.Open(path, FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateReader(fileStream);
            var result = reader.AsDataSet();
            fileStream.Close();
            reader.Close();
            return result.Tables[0];
        }


        public DataTable matrizGoTo()
        {
            FileStream fileStream;
            string path = sintactico + "\\GoToGramatica.xlsx";
            fileStream = File.Open(path, FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateReader(fileStream);
            var result = reader.AsDataSet();
            fileStream.Close();
            reader.Close();
            return result.Tables[0];
        }

        public List<First> ListaFirst()
        {
            string path = sintactico + "\\First.json";
            List<First> listaFirst = new List<First>();
            string archivo = File.ReadAllText(path);
            listaFirst = JsonConvert.DeserializeObject<List<First>>(archivo);

            return listaFirst;
        }
        public List<Next> ListaNext()
        {
            string path = sintactico + "\\Next.json";
            List<Next> listaNext = new List<Next>();
            string archivo = File.ReadAllText(path);
            listaNext = JsonConvert.DeserializeObject<List<Next>>(archivo);

            return listaNext;
        }

        public List<Tokens> listaTokensReconocidos()
        {
            string path = sintactico + "\\TokensReconocidos.json";
            List<Tokens> tokensReconocidos = new List<Tokens>();
            string archivo = File.ReadAllText(path);
            tokensReconocidos = JsonConvert.DeserializeObject<List<Tokens>>(archivo);

            return tokensReconocidos;
        }

      

        public DataTable MatrizEntera()
        {
            FileStream fileStream;
            string path = sintactico + "\\MatrizEntera.xlsx";
            fileStream = File.Open(path, FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateReader(fileStream);
            var result = reader.AsDataSet();
            fileStream.Close();
            reader.Close();
            return result.Tables[0];
        }


    }
}
