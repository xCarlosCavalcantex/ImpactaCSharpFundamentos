using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp.Cap3.Troco
{
    public partial class TrocoForm : Form
    {
    
        public TrocoForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            decimal valorPago = Convert.ToDecimal(valorPagoTextBox.Text);
            decimal valorCompra = Convert.ToDecimal(valorCompraTextBox.Text);

            decimal troco = valorPago - valorCompra;

            if (troco > 0)
                trocoTextBox.Text = troco.ToString("C2");
            else if (troco < 0)
                trocoTextBox.Text = "Você não tem valores a receber!";
            else
                trocoTextBox.Text = "Não tem troco!";

        }

    }
}
