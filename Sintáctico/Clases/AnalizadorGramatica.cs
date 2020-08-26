using ProyectoCompiladores.Léxico.Metodos;
using ProyectoCompiladores.Sintáctico.Métodos;
using System;
using System.Collections.Generic;
using System.Data;

namespace ProyectoCompiladores.Sintáctico.Clases
{
    class AnalizadorGramatica
    {
        public DataTable matrizLALR;
        public List<ReglasGramaticales> reglasGramaticales;

        public List<pilaSintactica> miListaPilaSintactica = new List<pilaSintactica>();
        public pilaSintactica miPilaSintactica;

        public List<pilaTR> pilaTokensReconocidos = new List<pilaTR>();
        public pilaTR miPilaTR;

        //Lista que sera mostrada en la vista
        public List<movimientosPila> listaPila = new List<movimientosPila>();
        public movimientosPila miPilaM;

        //Lista que sera mostrada en la vista
        public List<movimientosEntrada> listaEntrada = new List<movimientosEntrada>();
        public movimientosEntrada miMovimientosEntrada;

        //Lista que sera mostrada en la vista
        public List<movimeintoAccion> listaAccion = new List<movimeintoAccion>();
        public movimeintoAccion miAccion;

        public void analizadorLALR()
        {
            //Creamos el analizador y en este metodo llenaremos las listas que 
            //se veran despues en la vista winlexico > Analizador LALR
            miPilaSintactica = new pilaSintactica()
            {
                Elemento = "0"
            };
            miListaPilaSintactica.Add(miPilaSintactica);

            miPilaM = new movimientosPila()
            {
                Num = 1,
                Pila = "[ 0 ]"
            };
            listaPila.Add(miPilaM);

            miMovimientosEntrada = new movimientosEntrada()
            {
                Num = 1,
                Entrada = obtenerEntradaFormatear(pilaTokensReconocidos)
            };
            listaEntrada.Add(miMovimientosEntrada);




            // Console.WriteLine(listaPila[0].Pila + " " + pilaTokensReconocidos[0].SinonimoToken);
            bool flag = true;
            int filaMatrizEntera = 1;
            int num = 2;
            int interseccion = 0;


            while (flag)
            {
                //if (!flagReconocioRegla)
                //{
                interseccion = Convert.ToInt32(matrizLALR.Rows[filaMatrizEntera][buscarToken(pilaTokensReconocidos[0].SinonimoToken)]);
                // }


                Console.WriteLine("fila: " + filaMatrizEntera + " Columna: " + buscarToken(pilaTokensReconocidos[0].SinonimoToken));
                Console.WriteLine(pilaTokensReconocidos[0].SinonimoToken);
                Console.WriteLine("interseccion: " + interseccion);
                if (interseccion == 999)
                {
                    miAccion = new movimeintoAccion()
                    {
                        Num = num - 1,
                        Accion = "Aceptar"
                    };
                    listaAccion.Add(miAccion);
                    flag = false;
                }
                //Aqui controlaremos errores
                else if (interseccion >= 200)
                {

                    Console.WriteLine("error");
                    flag = false;
                }
                else if (interseccion < 0)
                {
                    Console.WriteLine("Reconocio regla");



                    foreach (var item in reglasGramaticales)
                    {
                        if (item.NumeroRegla == (interseccion * -1))
                        {
                            //Agregamos accion Reconocer reglas
                            miAccion = new movimeintoAccion()
                            {
                                Num = num - 1,
                                Accion = "R(" + (interseccion * -1) + ") " + item.ParteIzquierda + " --> " + item.ParteDerecha
                            };
                            listaAccion.Add(miAccion);
                            break;
                        }
                    }

                    foreach (var item in reglasGramaticales)
                    {
                        if (item.NumeroRegla == interseccion * -1)
                        {
                            //Removemos de la pila el contenido de la regla
                            miListaPilaSintactica.RemoveRange(miListaPilaSintactica.Count - (item.Longitud * 2), item.Longitud * 2);
                            filaMatrizEntera = Convert.ToInt32(miListaPilaSintactica[miListaPilaSintactica.Count - 1].Elemento);
                            interseccion = Convert.ToInt32(matrizLALR.Rows[(filaMatrizEntera) + 1][buscarToken(item.ParteIzquierda)]);

                            //Y Agregamos a la pila sintactica la regla que se va a mostrar en la tabla pila
                            miPilaSintactica = new pilaSintactica()
                            {
                                Elemento = item.ParteIzquierda
                            };
                            miListaPilaSintactica.Add(miPilaSintactica);

                            miPilaSintactica = new pilaSintactica()
                            {
                                Elemento = (interseccion).ToString()
                            };
                            miListaPilaSintactica.Add(miPilaSintactica);

                            Console.WriteLine("Fila: " + filaMatrizEntera + " Col:" + item.ParteIzquierda);
                            Console.WriteLine(interseccion);
                        }
                    }


                    miMovimientosEntrada = new movimientosEntrada()
                    {
                        Num = num,
                        Entrada = obtenerEntradaFormatear(pilaTokensReconocidos)
                    };
                    listaEntrada.Add(miMovimientosEntrada);

                    //Agregamos la lista pilaM y formatemos para mostrar en la vista tblPila
                    miPilaM = new movimientosPila()
                    {
                        Num = num,
                        Pila = obtenerPilaFormatear(miListaPilaSintactica)
                    };
                    listaPila.Add(miPilaM);


                    //Console.WriteLine("interseccion: " + interseccion);
                    filaMatrizEntera = interseccion + 1;
                    //if (interseccion > 200) {
                    //    flag = false;
                    //}


                    num++;

                }
                else
                {
                    Console.WriteLine("Siguinte");


                    //Agregamos accion dezplazar
                    miAccion = new movimeintoAccion()
                    {
                        Num = num - 1,
                        Accion = "Desplaza"
                    };
                    listaAccion.Add(miAccion);

                    //Agregamos a la pila sintactica lo que se va a mostrar en la tabla pila

                    miPilaSintactica = new pilaSintactica()
                    {
                        Elemento = pilaTokensReconocidos[0].SinonimoToken.ToString()
                    };
                    miListaPilaSintactica.Add(miPilaSintactica);

                    miPilaSintactica = new pilaSintactica()
                    {
                        Elemento = (Math.Abs(interseccion)).ToString()
                    };
                    miListaPilaSintactica.Add(miPilaSintactica);

                    //Removemos token de pilaTR para poder utilizar el proximo token reconocido
                    pilaTokensReconocidos.RemoveAt(0);

                    //Agregamos y formatemoslos tokens segun la pilaTR
                    miMovimientosEntrada = new movimientosEntrada()
                    {
                        Num = num,
                        Entrada = obtenerEntradaFormatear(pilaTokensReconocidos)
                    };
                    listaEntrada.Add(miMovimientosEntrada);

                    //Agregamos la lista pilaM y formatemos para mostrar en la vista tblPila
                    miPilaM = new movimientosPila()
                    {
                        Num = num,
                        Pila = obtenerPilaFormatear(miListaPilaSintactica)
                    };
                    listaPila.Add(miPilaM);


                    //Console.WriteLine("interseccion: " + interseccion);
                    filaMatrizEntera = interseccion + 1; //Sumamos 1 por la pocicion de la matriz
                    num++;
                }

            }
        }

        public void llenarPilaSintactica(List<Tokens> pila)
        {
            //Llenamos la pila sintatitca con lostokens reconocidos para usarlos mas adelante
            foreach (var item in pila)
            {
                miPilaTR = new pilaTR
                {
                    SinonimoToken = item.SinonimoToken
                };
                pilaTokensReconocidos.Add(miPilaTR);
            }

            miPilaTR = new pilaTR
            {
                SinonimoToken = "$"
            };
            pilaTokensReconocidos.Add(miPilaTR);

        }

        public string obtenerEntradaFormatear(List<pilaTR> miPila)
        {
            // Damos formata a la cadena que ira a la entrada
            string entrada = "";
            foreach (var item in miPila)
            {
                entrada += item.SinonimoToken + " ";
            }

            return entrada;
        }

        public string obtenerPilaFormatear(List<pilaSintactica> pila)
        {
            string pilaFormatear = "[ ";
            foreach (var item in pila)
            {
                pilaFormatear += item.Elemento + ", ";
            }
            pilaFormatear += "]";
            return pilaFormatear;
        }

        public int buscarToken(string token)
        {
            int col = 0;
            //Console.WriteLine("Token: " + token);
            for (int i = 0; i < matrizLALR.Columns.Count; i++)
            {
                if (matrizLALR.Rows[0][i].Equals(token))
                {
                    col = i;
                }

            }

            //Console.WriteLine(col);
            return col;
        }


    }
}
