using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Progra3EduardoMontes
{   //Eduardo Montes de Oca Yglesias
    class DiagonalDifference
    {
        //metodo matriz con un parametro String 
        public void matrix(String numeroMatriz)
        {
            //arreglo de String que almacena "|" y separa el caracter especial con split
            String[] arreglo = numeroMatriz.Split('|');
            //matriz de int que almacena las filas y columnas
            int[,] matriz2 = new int[arreglo.Length, arreglo.Length];
            //for que recorre el arreglo
            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int a = 0; a < 1; a++)
                {
                    String[] separador = arreglo[i].Split(' ');
                    //for que recorre el arreglo separador
                    for (int b = 0; b < separador.Length; b++)
                    {
                        //convertira el String a entero y lo amacenara en la matriz 
                        matriz2[i, b] = int.Parse(separador[b].ToString());
                    }
                }
            }
            //for que imprime las filas de la matriz
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                //for que imprime las columnas de la matriz 
                for (int c = 0; c < matriz2.GetLength(1); c++)
                {
                    Console.Write(matriz2[i,c]);
                }
                Console.WriteLine();
            }
        }
    }
}

