using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp.Cap4.Frete
{
    public partial class freteForm : Form
    {
        public freteForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            var erros = ValidarFormulario();

            if (erros.Count == 0)
            { 

                var frete = new Frete (new UF { Sigla = ufComboBox.Text }, Convert.ToDecimal(valorTextBox.Text));

                frete.Cliente = new Cliente();
                frete.Cliente.Nome = clienteTextBox.Text;

                frete.UF = new UF {Sigla = ufComboBox.Text };
                frete.Valor = Convert.ToDecimal(valorTextBox.Text);

                //frete.Calcular();

                freteTextBox.Text = frete.Percentual.ToString("P1");
                totalLabel.Text = frete.Total.ToString("C");

            }
        
            else
        {
                MessageBox.Show(string.Join(Environment.NewLine, erros),
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private List<string> ValidarFormulario()
        {
            var erros = new List<string>();

            if (clienteTextBox.Text == "")
                erros.Add("O campo Cliente é obrigatório!");

            if (valorTextBox.Text == string.Empty)
                erros.Add("O campo Valor é obrigatório!");
            else {
                decimal valor = 0;

                if (!decimal.TryParse(valorTextBox.Text,out valor))
                {
                    erros.Add("O campo Valor está com o formato inválido.");
                }
            }

            if (ufComboBox.SelectedIndex == -1)
                erros.Add("Selecione uma UF!");
            return erros;
        }

        private void limpaButton_Click(object sender, EventArgs e)
        {
            clienteTextBox.Clear();
            valorTextBox.ResetText();
            freteTextBox.Text = null;
            totalLabel.Text = string.Empty;
            ufComboBox.SelectedIndex = -1;
        }
    }
}
