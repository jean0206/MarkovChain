using System;

namespace Modelo
{
    public class Matriz
    {
        public double[,] multiplyMatrix(double[,] matriz, int exponenet) {
            double[,] a = matriz;
            double[,] b = matriz;
            double[,] c= new double[a.Length,a.Length];
            int x = 0;
            while (x<exponenet) { 
            
                c = new double[a.GetLength(0), b.GetLength(0)];
                for (int i = 0; i < c.GetLength(0); i++)
                {
                    for (int j = 0; j < c.GetLength(0); j++)
                    {
                        c[i, j] = 0;
                        for (int k = 0; k < a.GetLength(0); k++) //OR k<b.GetLength(0)
                            c[i, j] = c[i, j] + a[i, k] * b[k, j];
                    }
                }
                a = c;
                b = c;
                x++;
            }
            return c;
        }


        
    }

}
