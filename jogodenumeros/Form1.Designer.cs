
namespace jogodenumeros
{
    partial class frmJogodeNumeros
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblsuTitulo = new System.Windows.Forms.Label();
            this.txtNumeroInserido = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnTentativas = new System.Windows.Forms.Button();
            this.lblAbaixoBotao = new System.Windows.Forms.Label();
            this.lblNumeroTentativas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(135, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(518, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Boas Vindas Ao meu Jogo de Números";
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Location = new System.Drawing.Point(91, 130);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(0, 13);
            this.lblSubTitulo.TabIndex = 2;
            // 
            // lblsuTitulo
            // 
            this.lblsuTitulo.AutoSize = true;
            this.lblsuTitulo.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsuTitulo.Location = new System.Drawing.Point(183, 130);
            this.lblsuTitulo.Name = "lblsuTitulo";
            this.lblsuTitulo.Size = new System.Drawing.Size(437, 23);
            this.lblsuTitulo.TabIndex = 3;
            this.lblsuTitulo.Text = "10 Tentativas! Insira um número de 1 ate 100.";
            // 
            // txtNumeroInserido
            // 
            this.txtNumeroInserido.Location = new System.Drawing.Point(339, 173);
            this.txtNumeroInserido.Name = "txtNumeroInserido";
            this.txtNumeroInserido.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroInserido.TabIndex = 4;
            this.txtNumeroInserido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(168, 328);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(460, 20);
            this.txtresultado.TabIndex = 5;
            // 
            // btnTentativas
            // 
            this.btnTentativas.BackColor = System.Drawing.Color.DarkRed;
            this.btnTentativas.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTentativas.ForeColor = System.Drawing.Color.White;
            this.btnTentativas.Location = new System.Drawing.Point(284, 206);
            this.btnTentativas.Name = "btnTentativas";
            this.btnTentativas.Size = new System.Drawing.Size(203, 68);
            this.btnTentativas.TabIndex = 6;
            this.btnTentativas.Text = "Tentativas";
            this.btnTentativas.UseVisualStyleBackColor = false;
            this.btnTentativas.Click += new System.EventHandler(this.btnTentativas_Click);
            // 
            // lblAbaixoBotao
            // 
            this.lblAbaixoBotao.AutoSize = true;
            this.lblAbaixoBotao.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbaixoBotao.Location = new System.Drawing.Point(164, 286);
            this.lblAbaixoBotao.Name = "lblAbaixoBotao";
            this.lblAbaixoBotao.Size = new System.Drawing.Size(340, 23);
            this.lblAbaixoBotao.TabIndex = 7;
            this.lblAbaixoBotao.Text = "Veja quantantas tentativas restam:";
            // 
            // lblNumeroTentativas
            // 
            this.lblNumeroTentativas.AutoSize = true;
            this.lblNumeroTentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTentativas.Location = new System.Drawing.Point(501, 285);
            this.lblNumeroTentativas.Name = "lblNumeroTentativas";
            this.lblNumeroTentativas.Size = new System.Drawing.Size(30, 24);
            this.lblNumeroTentativas.TabIndex = 8;
            this.lblNumeroTentativas.Text = "10";
            // 
            // frmJogodeNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumeroTentativas);
            this.Controls.Add(this.lblAbaixoBotao);
            this.Controls.Add(this.btnTentativas);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtNumeroInserido);
            this.Controls.Add(this.lblsuTitulo);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.panel1);
            this.Name = "frmJogodeNumeros";
            this.Text = "Jogo de Números";
            this.Load += new System.EventHandler(this.frmJogodeNumeros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblsuTitulo;
        private System.Windows.Forms.TextBox txtNumeroInserido;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnTentativas;
        private System.Windows.Forms.Label lblAbaixoBotao;
        private System.Windows.Forms.Label lblNumeroTentativas;
    }
}

