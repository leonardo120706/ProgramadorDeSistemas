using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogodenumeros
{
    public partial class frmJogodeNumeros : Form
    {
        int randomNumber;
        int numeroTentativas = 10;
        int palpitedoJogador;
        bool jogoGanho = false;
        string dica;

        public frmJogodeNumeros()
        {
            InitializeComponent();
        }

        private void frmJogodeNumeros_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            randomNumber = random.Next(1, 101); 
        }

        private void btnTentativas_Click(object sender, EventArgs e)
        {
            //verfifica se o numero de tentativas chegou  0
            if(numeroTentativas == 0)
            {
                txtresultado.Text = "Voce nao tem mais tentativas. O jogo acabou";
                    return;
            }

            if (!int.TryParse(txtNumeroInserido.Text,out palpitedoJogador) || palpitedoJogador < 1 || palpitedoJogador > 100){
                txtresultado.Text = "Por favor, insira um numero entre 1 a 100.";
                return;
            }

            numeroTentativas--;
            lblNumeroTentativas.Text = numeroTentativas.ToString();


            if (palpitedoJogador == randomNumber)
            {
                jogoGanho = true;
                dica = "Parabéns, voce acertou!";
            }
            else if(palpitedoJogador < randomNumber)
            {
                dica = "o número do seu palpite e menor";
            }
            else
            {
                dica = "o número do seu palpite e maior";
            }

            txtresultado.Text = dica;
        }
    }
}
