﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_case
{
    public partial class FrmSwitch : Form
    {
        public FrmSwitch()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                var codigo = Convert.ToInt16(txtCodigoInserido.Text);
                lblDescricao.Text = GetTipoCombustivel(codigo);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
            }
        }
        private string GetTipoCombustivel(int codigo)
        {
            var result = "";
            

            switch (codigo)
            {
                case 1:
                    result = "Galsolina";
                    break;
                case 2:
                    result = "Álcool";
                    break;
                case 3:
                    result = "Flex";
                    break;
                case 4:
                    result = "Gás GNV";
                    break;
                case 5:
                    result = "Diesel";
                    break;
                case 6:
                    result = "Eletrecidade";
                    break;
                default:
                    result = "Invalido";
                    break;

            }
            return result;
        }
    }
}
