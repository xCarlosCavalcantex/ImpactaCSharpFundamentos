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
                Calcular();
            else
                MessageBox.Show(string.Join(Environment.NewLine,erros),
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void Calcular()
        {
            var percentual = 0m;
            var valor = Convert.ToDecimal(valorTextBox.Text);

            switch (ufComboBox.Text.ToUpper())
            {
                case "SP":
                    percentual = 0.2m;
                    break;
                case "RJ":
                    percentual = 0.3m;
                    break;
                case "MG":
                    percentual = 0.35m;
                    break;
                case "AM":
                    percentual = 0.6m;
                    break;
                default:
                    percentual = 0.75m;
                    break;
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
    }
}
