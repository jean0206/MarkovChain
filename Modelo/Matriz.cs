using System;
using System.IO;
using System.Double;

namespace Modelo
{
    public class Matriz
    {
        //This method multiplies two  matrices nxn
        public double[,] multiplyMatrix(double[,] matriz,double[,] matriz2)
        {
            double[,] a = matriz;
            double[,] b = matriz2;
            double[,] c = new double[a.Length, a.Length];
            c = new double[a.GetLength(0), b.GetLength(0)];
            int x = 0;        
            for (int i = 0; i < c.GetLength(0); i++)
             {
                for (int j = 0; j < c.GetLength(0); j++)
                {
                    for (int k = 0; k < c.GetLength(0); k++)
                     {
                       c[i, j] = c[i, j] + a[i, k] * b[k, j];
                     }
                 }

             }           
                 
            return c;
        }

        //This method raises an array N times
        public double[,] multiply(double[,] actual,double[,] simple,int exponente) {
            double[,] final = new double[actual.GetLength(0), actual.GetLength(0)];
            int conta = 0;
            
            while (conta < exponente-1) {
               final= multiplyMatrix(actual, simple);
                simple = final;
                conta++;
            }

            return final;
        }
        public double[,] ReadArchive()
        {
            double[,] resultado;
            StreamReader reader = new StreamReader("matrixDates.csv");
            StreamReader reader1 = new StreamReader("matrixDates.csv");
            string line;         
            String[] ini = reader1.ReadLine().Split(';');
            resultado = new double[ini.GetLength(0), ini.GetLength(0)];
            int i = 0;
            while ((line = reader.ReadLine()) != null)
            {
                String[] values = line.Split(';');
                for (int j = 0; j < resultado.GetLength(0); j++) {
                    resultado[i, j] = Convert.ToDouble(values[j]);
                }
                i++;
            }
            return resultado;
        }

        public double[] returnLimitProbabiliity() {
            double[] probability = new Double[9];
            StreamReader reader = new StreamReader("ProbLimites.txt");
            string line;
            int i = 0;
            while ((line = reader.ReadLine()) != null && i<probability.Length) {
                probability[i] = Convert.ToDouble(line);
                i++;
            }
            return probability;
        }

    }

            
    }


