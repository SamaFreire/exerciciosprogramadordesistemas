
namespace maioroumenorquedez
{
    partial class frmMaiorMenorqueDez
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblMenorMaiorqueDez = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificar.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.Location = new System.Drawing.Point(58, 119);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(129, 37);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblMenorMaiorqueDez
            // 
            this.lblMenorMaiorqueDez.AutoSize = true;
            this.lblMenorMaiorqueDez.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenorMaiorqueDez.Location = new System.Drawing.Point(23, 18);
            this.lblMenorMaiorqueDez.Name = "lblMenorMaiorqueDez";
            this.lblMenorMaiorqueDez.Size = new System.Drawing.Size(213, 28);
            this.lblMenorMaiorqueDez.TabIndex = 2;
            this.lblMenorMaiorqueDez.Text = "Digite Um Número";
            // 
            // frmMaiorMenorqueDez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 223);
            this.Controls.Add(this.lblMenorMaiorqueDez);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.textBox1);
            this.Name = "frmMaiorMenorqueDez";
            this.Text = "Maior Menor Que Dez";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblMenorMaiorqueDez;
    }
}

