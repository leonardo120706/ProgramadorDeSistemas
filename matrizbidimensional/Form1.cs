using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marizbidimensionl
{
    public partial class Form1 : Form
    {
        double[,] matriz = new double[3, 3];
        int i = 0;
        int j = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                matriz[i, j] = Double.Parse(textBox1.Text);
                j++;
                if (j == 3)
                {
                    i++;
                    j = 0;
                }
                textBox1.Text = "";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (i = 0; i <= 2; i++) //percorre a linha
            {
                for (j = 0; j <= 2; j++)
                {
                    textBox2.Text += matriz[i, j].ToString() + " ";
                }
                textBox2.Text += Environment.NewLine;
            }
        }

        private void btnMaiorValor_Click_1(object sender, EventArgs e)
        {

            double maiorValor = int.MinValue;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] > maiorValor)
                    {
                        maiorValor = matriz[i, j];
                    }
                }
            }
            MessageBox.Show("O maior valor na matriz é: " + maiorValor, "Maior Valor");
        }
    }
}