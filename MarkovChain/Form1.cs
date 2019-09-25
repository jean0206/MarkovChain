using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace MarkovChain
{
    public partial class Form1 : Form
    {
        private Matriz ma;
        public Form1()
        {
            InitializeComponent();
            ma = new Matriz();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double[,] matriz = new double[2,2 ] {
                {1,2},{3,4}
            };

            double[,] temporal=ma.multiplyMatrix(matriz, 4);
            
            String x = "";
            
            for (int i = 0; i< temporal.GetLength(0); i++) {
                for (int j = 0; j < temporal.GetLength(1); j++) {
                    x += temporal[i, j]+" ";
                }
                x += "\n";
            }
            MessageBox.Show(x);
        }
    }
}
