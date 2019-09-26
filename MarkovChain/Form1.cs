using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using System.Collections;



namespace MarkovChain
{
    public partial class Form1 : Form
    {
        private Matriz2 ma;
        private int indexLastState;
        private int indexNextState;
        double[,] z;
        string[,] s;
        public Form1()
        {
            InitializeComponent();
            ma = new Matriz2();
            loadStates();
           s = ma.matrixCombinatory();
        }

        private void Button1_Click(object sender, EventArgs e)
        {            
            String x = "";
            
            
            z = ma.ReadArchive();
            MessageBox.Show("Los datos se cargaron correctamente");
          
        }

        private void lastState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void loadStates() {
            for(int i = 0; i < 9; i++) { 
            lastState.Items.Add("Estado "+i);
            NextState.Items.Add("Estado " + i);
            probLimits.Items.Add("Estado " + i);
            stateProm.Items.Add("Estado " + i);
            returnTimeSelect.Items.Add("Estado " + i);
            }
            lastState.SelectedItem=0;
            NextState.SelectedItem = 0;
        }

        private void getResult_Click(object sender, EventArgs e)
        {
            indexLastState=lastState.SelectedIndex;
            indexNextState = NextState.SelectedIndex;
            string y = "";
             try {
                 int x = Convert.ToInt32(dayAnalyze.Text);
                 z=ma.multiply(z, z, x);
                 for (int i = 0; i < z.GetLength(0); i++)
                 {
                     for (int j = 0; j < z.GetLength(1); j++)
                     {
                         y += z[i, j] + " ";
                     }
                     y += "|"+"\n";
                 }
                 Result.Text = "La probabilidad es: " +
                     z[indexLastState, indexNextState];
                 //MessageBox.Show(y);
             }
             catch (Exception)
             {
                 MessageBox.Show("Digite un valor numerico");
             }
           // MessageBox.Show(y);

        }

        public void saveDates() {
           
            string y = "";
            
            for (int i = 0; i < z.GetLength(0); i++)
            {
                for (int j = 0; j < z.GetLength(1); j++)
                {
                    y += z[i, j] + ";";
                }
                y += "" + "\n";              
               
            }            
            //MessageBox.Show(y);
            string docPath = "";
            File.WriteAllText(Path.Combine(docPath,"Dates.csv"),y);
            MessageBox.Show("Se guardaron exitosamente los datos");
        }

        private void SaveDates_Click(object sender, EventArgs e)
        {
            saveDates();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void getProbLimit_Click(object sender, EventArgs e)
        {
            double[] probability = new Double[9];
            StreamReader reader = new StreamReader("ProbLimites.txt");
            string line;
            int i = 0;
            while ((line = reader.ReadLine()) != null && i < probability.Length)
            {
                probability[i] = Convert.ToDouble(line);
                i++;
            }

            int num = probLimits.SelectedIndex;
            ProbabilityLimits.Text ="Probabildad: "+ probability[num];
        }

        private void returnTime_Click(object sender, EventArgs e)
        {
            int[] probability = new int[9];
            StreamReader reader = new StreamReader("TiempoRetorno.txt");
            string line;
            int i = 0;
            while ((line = reader.ReadLine()) != null && i < probability.Length)
            {
                probability[i] =Convert.ToInt32( Convert.ToDouble(""+line));
                i++;
            }

            int num = returnTimeSelect.SelectedIndex;
            returnSelectTime.Text = "Tiempo de retorno " + probability[num]+" dias";
        }

        private void returnSelectTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void Probabilities_Click(object sender, EventArgs e)
        {
            double[,] x = ma.matrizValues();
            string y = "";

            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    y += x[i, j] + ";";
                }
                y += "|" + "\n";

            }
            //MessageBox.Show(y);
            int se = stateProm.SelectedIndex;
            int de = combinatoryItems.SelectedIndex;
            resultProm.Text = "" + x[de, se];

        }

        private void StateProm_SelectedIndexChanged(object sender, EventArgs e)
        {
            combinatoryItems.Items.Clear();
            int x = stateProm.SelectedIndex;
            
            for (int i = 0; i < s.GetLength(0)-1; i++) {
                combinatoryItems.Items.Add(s[i, x]);
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
    }

