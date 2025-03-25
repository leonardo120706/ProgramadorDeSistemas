using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrayunidimencional_vetor
{
    public partial class FrmVetor : Form
    {
        public FrmVetor()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            //matriz de uma dimensão, tambem chamanda de vetor
            string[] pecasComputador = { "Mouse", "Teclado", "Monitor", "Gabinete", "Camera" };

            //MessageBox.Show(pecasComputador[2]);

            foreach (string peca in pecasComputador)
                MessageBox.Show(peca);
        }
    }
}
