using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemadedesconto
{
    public partial class frmSistemadeDesconto : Form
    {
        public frmSistemadeDesconto()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valorCompra = double.Parse(txtValor.Text);
            double desconto = double.Parse(txtDesconto.Text);

            double valorDesconto = valorCompra * (desconto / 100);

            double valorFinal = valorCompra - valorDesconto;

            lblTotal.Text = valorFinal.ToString("0.00");
        }
    }
}
