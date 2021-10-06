using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_Matrices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private TextBox[,] MatrizA;
        private TextBox[,] MatrizB;
        private TextBox[,] MatrizResultante;  
        
        int filaA, columnaA;
        int filaB, columnaB;               
     
        
        //Boton para suma entre matrices
        private void btnsum_Click(object sender, EventArgs e)
        {
            if (MatrizA == null || MatrizB == null)
            {
                MessageBox.Show("Error!");
                return;
            }

            float[,] tempMatriza = new float[MatrizA.GetLength(0), MatrizA.GetLength(1)];
            float[,] tempMatrizb = new float[MatrizB.GetLength(0), MatrizB.GetLength(1)];

            if (tempMatriza.GetLength(0) != tempMatrizb.GetLength(0) || tempMatriza.GetLength(1) != tempMatrizb.GetLength(1))
            {
                MessageBox.Show("Sólo es posible la suma de matrices del mismo orden!");
                return;
            }

            for (int x = 0; x < MatrizA.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizA.GetLength(1); y++)
                {
                    float n;
                    float.TryParse(MatrizA[x, y].Text, out n);
                    tempMatriza[x, y] = n;
                }
            }
            for (int x = 0; x < MatrizB.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizB.GetLength(1); y++)
                {
                    float n;
                    float.TryParse(MatrizB[x, y].Text, out n);
                    tempMatrizb[x, y] = n;              
                }
            }

            float[,] tempMatrizResultante = CalculadoraMatrizes.Sumar(tempMatriza, tempMatrizb);
            MatrizResultante = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
            int TamanhoText = groupBoxMatrizResultante.Width / MatrizResultante.GetLength(1);
            groupBoxMatrizResultante.Controls.Clear();
            for (int x = 0; x < MatrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                {
                    MatrizResultante[x, y] = new TextBox();
                    MatrizResultante[x, y].Text = tempMatrizResultante[x, y].ToString();
                    MatrizResultante[x, y].Top = (x * MatrizResultante[x, y].Height) + 20;
                    MatrizResultante[x, y].Left = y * TamanhoText + 6;
                    MatrizResultante[x, y].Width = TamanhoText;
                    groupBoxMatrizResultante.Controls.Add(MatrizResultante[x, y]);
                }
            }
        }
        //Boton para resta entre matrices
        private void btnres_Click(object sender, EventArgs e)
        {
            if (MatrizA == null || MatrizB == null)
            {
                MessageBox.Show("Error!");
                return;
            }
            float[,] tempMatrizA = new float[MatrizA.GetLength(0), MatrizA.GetLength(1)];
            float[,] tempMatrizB = new float[MatrizB.GetLength(0), MatrizB.GetLength(1)];
            if (tempMatrizA.GetLength(0) != tempMatrizB.GetLength(0) || tempMatrizA.GetLength(1) != tempMatrizB.GetLength(1))
            {
                MessageBox.Show("Sólo es posible la resta de matrices del mismo orden");
                return;
            }

            for (int x = 0; x < MatrizA.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizA.GetLength(1); y++)
                {
                    float n;
                    float.TryParse(MatrizA[x, y].Text, out n);
                    tempMatrizA[x, y] = n;
                }
            }
            for (int x = 0; x < MatrizB.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizB.GetLength(1); y++)
                {
                    float n;
                    float.TryParse(MatrizB[x, y].Text, out n);
                    tempMatrizB[x, y] = n;
                }
            }

            float[,] tempMatrizResultante = CalculadoraMatrizes.Resta(tempMatrizA, tempMatrizB);
            MatrizResultante = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
            int TamañoText = groupBoxMatrizResultante.Width / MatrizResultante.GetLength(1);
            groupBoxMatrizResultante.Controls.Clear();
            for (int x = 0; x < MatrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                {
                    MatrizResultante[x, y] = new TextBox();
                    MatrizResultante[x, y].Text = tempMatrizResultante[x, y].ToString();
                    MatrizResultante[x, y].Top = (x * MatrizResultante[x, y].Height) + 20;
                    MatrizResultante[x, y].Left = y * TamañoText + 6;
                    MatrizResultante[x, y].Width = TamañoText;
                    groupBoxMatrizResultante.Controls.Add(MatrizResultante[x, y]);
                }
            }
        }
        //Boton para multiplicacion entre matrices
        private void btnmult_Click(object sender, EventArgs e)
        {
            if (MatrizA == null || MatrizB == null)
            {
                MessageBox.Show("Error!");
                return;
            }
            float[,] tempMatrizA = new float[MatrizA.GetLength(0), MatrizA.GetLength(1)];
            float[,] tempMatrizB = new float[MatrizB.GetLength(0), MatrizB.GetLength(1)];
            if (tempMatrizA.GetLength(1) != tempMatrizB.GetLength(0))
            {
                MessageBox.Show("¡Solo es posible multiplicar matrices donde la columna de la matriz A es igual a la fila de la matriz B!");
                return;
            }

            for (int x = 0; x < MatrizA.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizA.GetLength(1); y++)
                {
                    float n ;
                    float.TryParse(MatrizA[x, y].Text, out n);
                    tempMatrizA[x, y] = n;
                }
            }

            for (int x = 0; x < MatrizB.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizB.GetLength(1); y++)
                {
                    float n;
                    float.TryParse(MatrizB[x, y].Text, out n);
                    tempMatrizB[x, y] = n;
                }
            }

            float[,] tempMatrizResultante = CalculadoraMatrizes.Multiplicacion(tempMatrizA, tempMatrizB);
            MatrizResultante = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
            int TamañoText = groupBoxMatrizResultante.Width / MatrizResultante.GetLength(1);
            groupBoxMatrizResultante.Controls.Clear();
            for (int x = 0; x < MatrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                {
                    MatrizResultante[x, y] = new TextBox();
                    MatrizResultante[x, y].Text = tempMatrizResultante[x, y].ToString();
                    MatrizResultante[x, y].Top = (x * MatrizResultante[x, y].Height) + 20;
                    MatrizResultante[x, y].Left = y * TamañoText + 6;
                    MatrizResultante[x, y].Width = TamañoText;
                    groupBoxMatrizResultante.Controls.Add(MatrizResultante[x, y]);
                }
            }
        }

      
        //Opuesta de Matriz A
        private void btnopuestaA_Click(object sender, EventArgs e)
        {
            if (MatrizA == null)
            {
                MessageBox.Show("Error!");
                return;
            }
            float[,] tempResultante = new float[MatrizA.GetLength(0), MatrizA.GetLength(1)];

            for (int x = 0; x < MatrizA.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizA.GetLength(1); y++)
                {
                    float n;
                    float.TryParse(MatrizA[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            float[,] tempMatrizResultante = CalculadoraMatrizes.Opuesta(tempResultante);
            
            for (int x = 0; x < MatrizA.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizA.GetLength(1); y++)
                {
                    MatrizA[x, y].Text = tempMatrizResultante[x, y].ToString();
                }
            }
        }
        //Traspuesta Matriz A
        private void btnTraspuestaA_Click(object sender, EventArgs e)
        {
            if (MatrizA == null)
            {
                MessageBox.Show("Error!");
                return;
            }
            float[,] tempResultante = new float[MatrizA.GetLength(0), MatrizA.GetLength(1)];

            for (int x = 0; x < MatrizA.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizA.GetLength(1); y++)
                {
                    float n;
                    float.TryParse(MatrizA[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            float[,] tempMatrizResultante = CalculadoraMatrizes.Traspuesta(tempResultante);

            int TamañoText = groupBoxMatriz1.Width / MatrizA.GetLength(0);

            MatrizA = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];

            groupBoxMatriz1.Controls.Clear();
            for (int x = 0; x < MatrizA.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizA.GetLength(1); y++)
                {
                    MatrizA[x, y] = new TextBox();
                    MatrizA[x, y].Text = tempMatrizResultante[x, y].ToString();
                    MatrizA[x, y].Top = (x * MatrizA[x, y].Height) + 20;
                    MatrizA[x, y].Left = y * TamañoText + 6;
                    MatrizA[x, y].Width = TamañoText ;
                    groupBoxMatriz1.Controls.Add(MatrizA[x, y]);
                }
            }
        }
        //Opuesta B
        private void btnOpuestaB_Click(object sender, EventArgs e)
        {
            if (MatrizB == null)
            {
                MessageBox.Show("Error!");
                return;
            }
            float[,] tempResultante = new float[MatrizB.GetLength(0), MatrizB.GetLength(1)];

            for (int x = 0; x < MatrizB.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizB.GetLength(1); y++)
                {
                    float n;
                    float.TryParse(MatrizB[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            float[,] tempMatrizResultante = CalculadoraMatrizes.Opuesta(tempResultante);
            
            for (int x = 0; x < MatrizB.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizB.GetLength(1); y++)
                {
                    MatrizB[x, y].Text = tempMatrizResultante[x, y].ToString();
                }
            }
        }
        //Traspuesta B
        private void btnTraspuestaB_Click(object sender, EventArgs e)
        {
            if (MatrizB == null)
            {
                MessageBox.Show("Error!");
                return;
            }
            float[,] tempResultante = new float[MatrizB.GetLength(0), MatrizB.GetLength(1)];

            for (int x = 0; x < MatrizB.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizB.GetLength(1); y++)
                {
                    float n;
                    float.TryParse(MatrizB[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            float[,] tempMatrizResultante = CalculadoraMatrizes.Traspuesta(tempResultante);
            int TamañoText = groupBoxMatriz2.Width / MatrizB.GetLength(0);
            MatrizB = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
            groupBoxMatriz2.Controls.Clear();
            for (int x = 0; x < MatrizB.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizB.GetLength(1); y++)
                {
                    MatrizB[x, y] = new TextBox();
                    MatrizB[x, y].Text = tempMatrizResultante[x, y].ToString();
                    MatrizB[x, y].Top = (x * MatrizB[x, y].Height) + 20;
                    MatrizB[x, y].Left = y * TamañoText + 6;
                    MatrizB[x, y].Width = TamañoText;
                    groupBoxMatriz2.Controls.Add(MatrizB[x, y]);
                }
            }
        }
        //Opuesta Resultado
        private void btnOpuestaRes_Click(object sender, EventArgs e)
        {
            if (MatrizResultante == null)
            {
                MessageBox.Show("Error!");
                return;
            }
            float[,] tempResultante = new float[MatrizResultante.GetLength(0), MatrizResultante.GetLength(1)];

            for (int x = 0; x < MatrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                {
                    float n ;
                    float.TryParse(MatrizResultante[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            float[,] tempMatrizResultante = CalculadoraMatrizes.Opuesta(tempResultante);
            
            for (int x = 0; x < MatrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                {
                    MatrizResultante[x, y].Text = tempMatrizResultante[x, y].ToString();
                }
            }
        }
        //Traspuesta Resultado
        private void btnTraspuestaRes_Click(object sender, EventArgs e)
        {
            if (MatrizResultante == null)
            {
                MessageBox.Show("Error!");
                return;
            }
            float[,] tempResultante = new float[MatrizResultante.GetLength(0), MatrizResultante.GetLength(1)];

            for (int x = 0; x < MatrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                {
                    float n ;
                    float.TryParse(MatrizResultante[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            float[,] tempMatrizResultante = CalculadoraMatrizes.Traspuesta(tempResultante);
            int TamañoText = groupBoxMatrizResultante.Width / MatrizResultante.GetLength(0);
            MatrizResultante = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
            groupBoxMatrizResultante.Controls.Clear();
            for (int x = 0; x < MatrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                {
                    MatrizResultante[x, y] = new TextBox();
                    MatrizResultante[x, y].Text = tempMatrizResultante[x, y].ToString();
                    MatrizResultante[x, y].Top = (x * MatrizResultante[x, y].Height) + 20;
                    MatrizResultante[x, y].Left = y * TamañoText + 6;
                    MatrizResultante[x, y].Width = TamañoText;
                    groupBoxMatrizResultante.Controls.Add(MatrizResultante[x, y]);
                }
            }
        }
        //Escalar
        private void btnEscalarA_Click(object sender, EventArgs e)
        {
            if (MatrizA == null)
            {
                MessageBox.Show("Error!");
                return;
            }
            float[,] tempResultante = new float[MatrizA.GetLength(0), MatrizA.GetLength(1)];

            for (int x = 0; x < MatrizA.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizA.GetLength(1); y++)
                {
                    float n ;
                    float.TryParse(MatrizA[x, y].Text, out n);
                    tempResultante[x, y] = n;                    
                }
            }
            int r = System.Convert.ToInt32(escalarA.Text);
            float[,] escMatrizResultante = CalculadoraMatrizes.EscalarPorMatriz(tempResultante,r);

            MatrizResultante = new TextBox[filaA, columnaA];
            groupBoxMatrizResultante.Controls.Clear();
            int TamañoText = groupBoxMatriz1.Width / columnaA;

            for (int x = 0; x < MatrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                {
                    MatrizResultante[x, y] = new TextBox();
                    MatrizResultante[x, y].Text = "";
                    MatrizResultante[x, y].Top = (x * MatrizResultante[x, y].Height) + 20;
                    MatrizResultante[x, y].Left = y * TamañoText + 6;
                    MatrizResultante[x, y].Width = TamañoText;
                    groupBoxMatrizResultante.Controls.Add(MatrizResultante[x, y]);
                }
            }

            for (int x = 0; x < MatrizA.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizA.GetLength(1); y++)
                {

                    MatrizResultante[x, y].Text = escMatrizResultante[x, y].ToString();
                }
            }
        }

        private void btnEscalarB_Click(object sender, EventArgs e)
        {
            if (MatrizB == null)
            {
                MessageBox.Show("Error!");
                return;
            }
            float[,] tempResultante = new float[MatrizB.GetLength(0), MatrizB.GetLength(1)];

            for (int x = 0; x < MatrizB.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizB.GetLength(1); y++)
                {
                    float n;
                    float.TryParse(MatrizB[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }
            int r = System.Convert.ToInt32(escalarB.Text);
            float[,] escMatrizResultante = CalculadoraMatrizes.EscalarPorMatriz(tempResultante, r);

            MatrizResultante = new TextBox[filaB, columnaB];
            groupBoxMatrizResultante.Controls.Clear();
            int TamañoText = groupBoxMatriz1.Width / columnaB;

            for (int x = 0; x < MatrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                {
                    MatrizResultante[x, y] = new TextBox();
                    MatrizResultante[x, y].Text = "";
                    MatrizResultante[x, y].Top = (x * MatrizResultante[x, y].Height) + 20;
                    MatrizResultante[x, y].Left = y * TamañoText + 6;
                    MatrizResultante[x, y].Width = TamañoText;
                    groupBoxMatrizResultante.Controls.Add(MatrizResultante[x, y]);
                }
            }

            for (int x = 0; x < MatrizB.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizB.GetLength(1); y++)
                {
                    MatrizResultante[x, y].Text = escMatrizResultante[x, y].ToString();
                }
            }
        }


        //Creacion de dimensiones de matriz A
        private void btnCrearmA_Click_1(object sender, EventArgs e)
        {
            groupBoxMatriz1.Controls.Clear();

            if (!int.TryParse(textBox1.Text, out filaA))
            {
                MessageBox.Show("La fila de matriz A es nula");
                return;
            }
            if (!int.TryParse(textBox3.Text, out columnaA))
            {
                MessageBox.Show("La columna de la matriz A es nula");
                return;
            }

            MatrizA = new TextBox[filaA, columnaA];
            int TamañoText = groupBoxMatriz1.Width / columnaA;
            for (int x = 0; x < MatrizA.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizA.GetLength(1); y++)
                {
                    MatrizA[x, y] = new TextBox();
                    MatrizA[x, y].Text = "";
                    MatrizA[x, y].Top = (x * MatrizA[x, y].Height) + 20;
                    MatrizA[x, y].Left = y * TamañoText + 6;
                    MatrizA[x, y].Width = TamañoText;
                    groupBoxMatriz1.Controls.Add(MatrizA[x, y]);
                }
            }
        }
        //Creacion de dimensiones de matriz B
        private void btnCrearmB_Click_1(object sender, EventArgs e)
        {
            groupBoxMatriz2.Controls.Clear();
            
            if (!int.TryParse(textBox2.Text, out filaB))
            {
                MessageBox.Show("La fila de la matriz B es nula");
                return;
            }
            if (!int.TryParse(textBox4.Text, out columnaB))
            {
                MessageBox.Show("La columna de la matriz B es nula.");
                return;
            }
            
            MatrizB = new TextBox[filaB, columnaB];
            int TamañoText = groupBoxMatriz2.Width / columnaB;
            for (int x = 0; x < MatrizB.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizB.GetLength(1); y++)
                {
                    MatrizB[x, y] = new TextBox();
                    MatrizB[x, y].Text = "";
                    MatrizB[x, y].Top = (x * MatrizB[x, y].Height) + 20;
                    MatrizB[x, y].Left = y * TamañoText + 6;
                    MatrizB[x, y].Width = TamañoText;
                    groupBoxMatriz2.Controls.Add(MatrizB[x, y]);
                }
            }
        }         
        
    }
}
