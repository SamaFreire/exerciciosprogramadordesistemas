﻿
namespace calculadora
{
    partial class frmCalculadora
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(10, 24);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(194, 20);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.White;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.ForeColor = System.Drawing.Color.Black;
            this.btnZero.Location = new System.Drawing.Point(57, 249);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(42, 40);
            this.btnZero.TabIndex = 1;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnUm
            // 
            this.btnUm.BackColor = System.Drawing.Color.White;
            this.btnUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUm.ForeColor = System.Drawing.Color.Black;
            this.btnUm.Location = new System.Drawing.Point(10, 203);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(40, 40);
            this.btnUm.TabIndex = 2;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = false;
            this.btnUm.Click += new System.EventHandler(this.btnUm_Click);
            // 
            // btnDois
            // 
            this.btnDois.BackColor = System.Drawing.Color.White;
            this.btnDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDois.ForeColor = System.Drawing.Color.Black;
            this.btnDois.Location = new System.Drawing.Point(57, 203);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(42, 40);
            this.btnDois.TabIndex = 3;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = false;
            this.btnDois.Click += new System.EventHandler(this.btnDois_Click);
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.Color.White;
            this.btnTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.ForeColor = System.Drawing.Color.Black;
            this.btnTres.Location = new System.Drawing.Point(102, 203);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(42, 40);
            this.btnTres.TabIndex = 4;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.BackColor = System.Drawing.Color.White;
            this.btnQuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuatro.ForeColor = System.Drawing.Color.Black;
            this.btnQuatro.Location = new System.Drawing.Point(10, 157);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(40, 40);
            this.btnQuatro.TabIndex = 5;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = false;
            this.btnQuatro.Click += new System.EventHandler(this.btnQuatro_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.Color.White;
            this.btnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.ForeColor = System.Drawing.Color.Black;
            this.btnCinco.Location = new System.Drawing.Point(57, 157);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(42, 40);
            this.btnCinco.TabIndex = 6;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.BackColor = System.Drawing.Color.White;
            this.btnSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.ForeColor = System.Drawing.Color.Black;
            this.btnSeis.Location = new System.Drawing.Point(102, 157);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(42, 40);
            this.btnSeis.TabIndex = 7;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnSete
            // 
            this.btnSete.BackColor = System.Drawing.Color.White;
            this.btnSete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSete.ForeColor = System.Drawing.Color.Black;
            this.btnSete.Location = new System.Drawing.Point(10, 111);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(40, 40);
            this.btnSete.TabIndex = 8;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = false;
            this.btnSete.Click += new System.EventHandler(this.btnSete_Click);
            // 
            // btnOito
            // 
            this.btnOito.BackColor = System.Drawing.Color.White;
            this.btnOito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOito.ForeColor = System.Drawing.Color.Black;
            this.btnOito.Location = new System.Drawing.Point(56, 111);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(42, 40);
            this.btnOito.TabIndex = 9;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = false;
            this.btnOito.Click += new System.EventHandler(this.btnOito_Click);
            // 
            // btnNove
            // 
            this.btnNove.BackColor = System.Drawing.Color.White;
            this.btnNove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNove.ForeColor = System.Drawing.Color.Black;
            this.btnNove.Location = new System.Drawing.Point(102, 111);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(42, 40);
            this.btnNove.TabIndex = 10;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = false;
            this.btnNove.Click += new System.EventHandler(this.btnNove_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.BackColor = System.Drawing.Color.White;
            this.btnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.ForeColor = System.Drawing.Color.Black;
            this.btnVirgula.Location = new System.Drawing.Point(10, 249);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(40, 40);
            this.btnVirgula.TabIndex = 11;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = false;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.White;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.Color.Black;
            this.btnIgual.Location = new System.Drawing.Point(102, 249);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(42, 40);
            this.btnIgual.TabIndex = 12;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.BackColor = System.Drawing.Color.White;
            this.btnDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.ForeColor = System.Drawing.Color.Black;
            this.btnDivisao.Location = new System.Drawing.Point(158, 111);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(46, 40);
            this.btnDivisao.TabIndex = 13;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.BackColor = System.Drawing.Color.White;
            this.btnMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacao.ForeColor = System.Drawing.Color.Black;
            this.btnMultiplicacao.Location = new System.Drawing.Point(158, 157);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(46, 40);
            this.btnMultiplicacao.TabIndex = 14;
            this.btnMultiplicacao.Text = "X";
            this.btnMultiplicacao.UseVisualStyleBackColor = false;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.BackColor = System.Drawing.Color.White;
            this.btnSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtracao.ForeColor = System.Drawing.Color.Black;
            this.btnSubtracao.Location = new System.Drawing.Point(158, 203);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(46, 40);
            this.btnSubtracao.TabIndex = 15;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = false;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnAdicao
            // 
            this.btnAdicao.BackColor = System.Drawing.Color.White;
            this.btnAdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicao.ForeColor = System.Drawing.Color.Black;
            this.btnAdicao.Location = new System.Drawing.Point(158, 250);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(46, 39);
            this.btnAdicao.TabIndex = 16;
            this.btnAdicao.Text = "+";
            this.btnAdicao.UseVisualStyleBackColor = false;
            this.btnAdicao.Click += new System.EventHandler(this.btnAdicao_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(158, 68);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(46, 37);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.BackColor = System.Drawing.Color.White;
            this.lblOperacao.Location = new System.Drawing.Point(12, 27);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(0, 13);
            this.lblOperacao.TabIndex = 18;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(216, 297);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.txtResultado);
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblOperacao;
    }
}

