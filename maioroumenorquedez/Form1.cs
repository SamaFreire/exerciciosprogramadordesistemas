using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maioroumenorquedez
{
    public partial class frmMaiorMenorqueDez : Form
    {
        public frmMaiorMenorqueDez()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int numero))

            if (numero > 10)
            {
                MessageBox.Show("O valor é maior que 10");
            }
            else if (numero < 10)
            {
                MessageBox.Show("O valor é menor que 10");
            }
          
           
        }
    }
}
