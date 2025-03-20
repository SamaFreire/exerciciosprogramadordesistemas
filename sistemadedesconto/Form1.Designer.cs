
namespace sistemadedesconto
{
    partial class frmSistemadeDesconto
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(91, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(479, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema de Cálculo de Desconto";
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCompra.ForeColor = System.Drawing.Color.White;
            this.lblValorCompra.Location = new System.Drawing.Point(12, 107);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(251, 23);
            this.lblValorCompra.TabIndex = 1;
            this.lblValorCompra.Text = "Insira o valor da compra:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(287, 110);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(123, 20);
            this.txtValor.TabIndex = 2;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.ForeColor = System.Drawing.Color.White;
            this.lblDesconto.Location = new System.Drawing.Point(12, 165);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(518, 23);
            this.lblDesconto.TabIndex = 3;
            this.lblDesconto.Text = "Insira o desconto (considerar que 10 significa 10%):";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(529, 168);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(108, 20);
            this.txtDesconto.TabIndex = 4;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(16, 251);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(383, 23);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado da compra com desconto R$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(405, 255);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 19);
            this.lblTotal.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.LightCoral;
            this.btnCalcular.Location = new System.Drawing.Point(529, 204);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(108, 43);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmSistemadeDesconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(670, 412);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValorCompra);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmSistemadeDesconto";
            this.Text = "Sistema de Cálculo de Desconto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblValorCompra;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalcular;
    }
}

