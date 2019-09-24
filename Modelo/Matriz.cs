using System;

namespace Modelo
{
    public class Matriz
    {
        public double[][] multiplicarMatriz(double[][] matriz, int exponenete) {
            double[][] matrizTem = matriz;
            double n = matriz[0].Length;
            // filas de la matriz A
            double m = matriz.Length;
            // filas de la matriz B
            double n2 = matriz.Length;
            // columnas de la matriz B
            double o = matriz[0].Length;
            // nueva matriz 
            double[][] c = new double[m][o];
            // se comprueba si las matrices se pueden multiplicar
           
                for (int i = 0; i < n - 1; i++)
                {
                    int a = 0;
                    for (int j = 0; j < n2 - 1; j++)
                    {
                        //aqui se multiplica la matriz
                        a = a + (matriz[i][j] * B[j][i]);
                    }

                }
            
            /**
             *  si no se cumple la condición se retorna una matriz vacía
             */
            return c;
            return null;
        }
        
    }

}
