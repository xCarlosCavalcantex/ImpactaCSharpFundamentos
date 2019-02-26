using Impacta.Valida;
using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oficina.WinForm
{
    public partial class veiculoForm : Form
    {
        public veiculoForm()
        {
            InitializeComponent();
            PopularControles();
        }

        private void PopularControles()
        {
            marcaComboBox.DataSource = new MarcaRepositorio().Selecionar(); // DataSource localiza onde está 
            marcaComboBox.DisplayMember = "Nome";
            marcaComboBox.ValueMember = "Id";
            marcaComboBox.SelectedIndex = -1;

            corComboBox.DataSource = new CorRepositorio().Selecionar();
            corComboBox.DisplayMember = "Nome";
            corComboBox.ValueMember = "Id";
            corComboBox.SelectedIndex = -1;

            combustivelComboBox.DataSource = Enum.GetValues(typeof(Combustivel));
            combustivelComboBox.SelectedIndex = -1;

            cambioComboBox.DataSource = Enum.GetValues(typeof(Cambio));
            cambioComboBox.SelectedIndex = -1;

        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            var formulario = new Formulario();

            if (formulario.Validar(this, veiculoErrorProvider))
            {

            }

        }

        private void marcaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (marcaComboBox.SelectedIndex == -1)
            {
                modeloComboBox.DataSource = null;
                return;
            }


            var marca = (Marca)marcaComboBox.SelectedItem;

            modeloComboBox.DataSource = new ModeloRepositorio().SelecionarPorMarca(marca.Id);
            modeloComboBox.DisplayMember = "Nome";
            modeloComboBox.ValueMember = "Id";
            modeloComboBox.SelectedIndex = -1;
        }
    }
}
