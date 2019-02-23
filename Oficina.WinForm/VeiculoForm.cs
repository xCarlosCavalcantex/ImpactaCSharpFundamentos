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
            marcaComboBox.DataSource = new MarcaRepositorio().Selecionar();
            marcaComboBox.DisplayMember = "Nome";
            marcaComboBox.ValueMember = "Id";
            marcaComboBox.SelectedIndex = -1;
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
