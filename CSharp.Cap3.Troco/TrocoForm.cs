using System;
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
            {
                trocoTextBox.Text = troco.ToString("C");

                var moedas = new decimal[6] {1, 0.5m, 0.25m, 0.10m, 0.05m, 0.01m };

                for (int i = 0; i < 6; i++)
                {
                    var qtd = (int)(troco / moedas[i]);
                    troco %= moedas[i];
                    coinsListView.Items[i].Text = qtd.ToString();
                }






            //    //toDo: trocar para estrutura de repetição

            //    var moeda1 = (int)troco;
            //    troco %= 1;

            //    var moeda050 = (int)(troco / 0.5m);
            //    troco %= 0.5m;

            //    var moeda025 = (int)(troco / 0.25m);
            //    troco %= 0.25m;

            //    var moeda010 = (int)(troco / 0.10m);
            //    troco %= 0.10m;

            //    var moeda005 = (int)(troco / 0.05m);
            //    troco %= 0.05m;

            //    var moeda001 = (int)(troco / 0.01m);
            //    troco %= 0.01m;

            //    coinsListView.Items[0].Text = moeda1.ToString();
            //    coinsListView.Items[1].Text = moeda050.ToString();
            //    coinsListView.Items[2].Text = moeda025.ToString();
            //    coinsListView.Items[3].Text = moeda010.ToString();
            //    coinsListView.Items[4].Text = moeda005.ToString();
            //    coinsListView.Items[5].Text = moeda001.ToString();

            }
            else if (troco < 0)
            {
                trocoTextBox.Text = "Você não tem valores a receber!";
                
            }
            else
                trocoTextBox.Text = "Não tem troco!";

        }

        private void cleanField_Click(object sender, EventArgs e)
        {
            trocoTextBox.ResetText();
            valorCompraTextBox.ResetText();
            valorPagoTextBox.ResetText();
        }
    }
}
