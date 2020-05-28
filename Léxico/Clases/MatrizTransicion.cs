using ProyectoCompiladores.Léxico.Metodos;
using System;
using System.Collections.Generic;
using System.Data;

namespace ProyectoCompiladores.Léxico.Clases
{
    class MatrizTransicion
    {

        string[,] MTransicion;



        public string[,] matrizTransicion(DataTable dt)
        {

            MTransicion = new string[dt.Rows.Count, dt.Columns.Count - 1];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    if (j == 0)
                    {

                    }
                    else
                    {

                        MTransicion[i, j - 1] = dt.Rows[i][j].ToString();

                    }
                }
            }
            return MTransicion;
        }

        //Matriz Valor
        public List<matrizValor> matrizValor()
        {
            List<matrizValor> lista = new List<matrizValor>();
            matrizValor matriz;
            int aux = 0;

            for (int i = 1; i < MTransicion.GetLength(0); i++)
            {
                for (int j = 0; j < MTransicion.GetLength(1); j++)
                {
                    if (MTransicion[i, j] != "-999")
                    {
                        matriz = new matrizValor
                        {
                            Id = (aux++) + "",
                            Valor = MTransicion[i, j] + "",
                            Columna = (j) + "",
                            Dato = (MTransicion[0, j]) + ""
                        };
                        lista.Add(matriz);
                    };
                }

            }


            return lista;
        }


        //Matriz Prifil
        public List<matrizPrifil> matrizPrifil()
        {
            List<matrizPrifil> lista = new List<matrizPrifil>();
            int acuCantidadItemsFilas = 0;
            int aux = 0;
            matrizPrifil matriz;

            for (int i = 0; i < MTransicion.GetLength(0); i++)
            {
                for (int j = 0; j < MTransicion.GetLength(1); j++)
                {

                    if (MTransicion[i, j] != "-999" && i != 0)
                    {
                        acuCantidadItemsFilas++;
                    }
                }


                if (i == 1)
                {
                    matriz = new matrizPrifil
                    {
                        Numfila = (i - 1) + "",
                        Prifil = "0",
                        Fila = acuCantidadItemsFilas + ""
                    };
                    aux = acuCantidadItemsFilas;
                    lista.Add(matriz);

                }

                else if (i > 1)
                {

                    matriz = new matrizPrifil
                    {
                        Numfila = (i - 1) + "",
                        Prifil = aux + "",
                        Fila = acuCantidadItemsFilas + ""
                    };
                    lista.Add(matriz);
                    aux += acuCantidadItemsFilas;
                }


                acuCantidadItemsFilas = 0;
            }



            return lista;
        }


        //Acceso a la tabla compacta
        public int acceso(int i, int j)
        {

     


            int prifil = Convert.ToInt32(matrizPrifil()[i].Prifil);
            int repeteiciones = Convert.ToInt32(matrizPrifil()[i].Fila);
            int valor = -999;



            for (int k = prifil; k < prifil + repeteiciones; k++)
            {

                if (j == Convert.ToInt32(matrizValor()[k].Columna))
                {

                    valor = Convert.ToInt32(matrizValor()[k].Valor);

                    break;
                }

            }




            return valor;
        }

        public List<movimientos> movimientos(String cadena)
        {
            List<movimientos> lista = new List<movimientos>();
            movimientos misMovimientos;
            


            char[] cortar = cadena.ToCharArray();
            int valor = 0;
            int aux = 0;

            for (int i = 0; i < cortar.Length; i++)
            {
                for (int j = 0; j < MTransicion.GetLength(1); j++)
                {

                    if (cortar[i].Equals(Convert.ToChar(MTransicion[0, j])))
                    {
                        if (valor == -999 || valor<0)
                        {
                            valor = 0;
                            aux = 0;
                        }
                        valor = acceso(valor, j);

                        misMovimientos = new movimientos
                        {
                            EstadoInicial = aux + "",
                            Leyendo = MTransicion[0, j],
                            EstadoFinal = valor + ""
                        };
                        aux = valor;
                        lista.Add(misMovimientos);
                    }



                }

            }
            return lista;
        }
    }
}
