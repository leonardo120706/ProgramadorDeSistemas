using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabuadacomloop
{
    public partial class frmTabudaLoop : Form
    {
        public frmTabudaLoop()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //Limpar a lista antes de adicionar novos resultados
            lstTabuada.Items.Clear();

            int numeroInserido = Convert.ToInt32(txtNumero.Text);
            //Adicionar a tabuada para número inserido
            for (int i = 1; i < 11; i++)
            {
                lstTabuada.Items.Add(numeroInserido + "x" + i + "=" + (numeroInserido * i));
            }
            
        }
    }
}
