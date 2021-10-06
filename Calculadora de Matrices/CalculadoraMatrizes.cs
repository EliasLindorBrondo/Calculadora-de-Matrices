using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_Matrices
{
    public static class CalculadoraMatrizes
    {
        #region Operaciones
        public static float[,] Sumar(float[,] matrizA, float[,] matrizB)
        {
            float[,] matrizResultante = new float[matrizA.GetLongLength(0), matrizA.GetLength(1)];
            for (int x = 0; x < matrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultante.GetLength(1); y++)
                {
                    matrizResultante[x, y] = matrizA[x, y] + matrizB[x, y];
                }
            }
            return matrizResultante;
        }
        public static float[,] Resta(float[,] matrizA, float[,] matrizB)
        {
            float[,] matrizResultante = new float[matrizA.GetLongLength(0), matrizA.GetLength(1)];
            for (int x = 0; x < matrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultante.GetLength(1); y++)
                {
                    matrizResultante[x, y] = matrizA[x, y] - matrizB[x, y];
                }
            }
            return matrizResultante;
        }
        public static float[,] Multiplicacion(float[,] matrizA, float[,] matrizB)
        {
            float[,] matrizResultante = new float[matrizA.GetLength(0), matrizB.GetLength(1)];
            for (int x = 0; x < matrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultante.GetLength(1); y++)
                {
                    for (int n = 0; n < matrizB.GetLength(0); n++)
                    {                        
                        matrizResultante[x, y] += matrizA[x, n] * matrizB[n, y];
                    }
                }
            }
            return matrizResultante;
        }
        #endregion
        
        public static float[,] Opuesta(float[,] matriz)
        {
            float[,] matrizOpuesta = new float[matriz.GetLength(0), matriz.GetLength(1)];
            for (int x = 0; x < matrizOpuesta.GetLength(0); x++)
            {
                for (int y = 0; y < matrizOpuesta.GetLength(1); y++)
                {
                    matrizOpuesta[x, y] = matriz[x, y] * -1;
                }
            }
            return matrizOpuesta;
        }
        public static float[,] Traspuesta(float[,] matriz)
        {
            float[,] matrizTraspuesta = new float[matriz.GetLength(1), matriz.GetLength(0)];
            for (int x = 0; x < matrizTraspuesta.GetLength(0); x++)
            {
                for (int y = 0; y < matrizTraspuesta.GetLength(1); y++)
                {
                    matrizTraspuesta[x, y] = matriz[y, x];
                }
            }
            return matrizTraspuesta;
        }

        public static float[,] EscalarPorMatriz(float[,] matriz,int r)
        {
            float[,] EscalarMatriz = new float[matriz.GetLength(0), matriz.GetLength(1)];
            for (int x = 0; x < EscalarMatriz.GetLength(0); x++)
            {
                for (int y = 0; y < EscalarMatriz.GetLength(1); y++)
                {
                    EscalarMatriz[x, y] = matriz[x, y] * r;
                }
            }
            return EscalarMatriz;
        }

    }
}
