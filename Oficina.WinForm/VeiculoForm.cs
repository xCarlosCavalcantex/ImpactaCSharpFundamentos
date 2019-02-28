using Impacta.Valida;
using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            //var formulario = new Formulario();

            if (Formulario.Validar(this, veiculoErrorProvider))
            {
                try
                {

                    GravarVeiculo();

                    MessageBox.Show("Veiculo gravado com sucesso !");

                    Formulario.Limpar(this);

                    placaMaskedTextBox.Focus();
                }

                catch (DirectoryNotFoundException)
                {

                    MessageBox.Show("Uma parte do caminho do arquivo de Veiculo não foi encontrada. A gravação não foi realizada");
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("O arquivo de Veiculo não foi encontrada. A gravação não foi realizada");
                }

                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("O arquivo .xml não tem permissão de gravação.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("500");
                    log4net.LogManager.GetLogger(nameof(veiculoForm)).Error(ex.Message, ex);
                }
            }

        }

        private void GravarVeiculo()
        {
            
                var veiculo = new VeiculoPasseio();

                veiculo.Ano = Convert.ToInt32(anoMaskedTextBox.Text);
                veiculo.Cambio = (Cambio)cambioComboBox.SelectedItem;
                veiculo.Carroceria = Carroceria.Hatch;
                veiculo.Combustivel = (Combustivel)combustivelComboBox.SelectedItem;
                veiculo.Cor = (Cor)corComboBox.SelectedItem;
                veiculo.Modelo = (Modelo)modeloComboBox.SelectedItem;
                veiculo.Observacao = obsTextBox.Text;
                veiculo.Placa = placaMaskedTextBox.Text;

                new VeiculoRepositorio().Inserir(veiculo);
            
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

        private void obsTextBox_TextChanged(object sender, EventArgs e)
        {
            obsGroupBox.Text = $"Observação ({obsTextBox.MaxLength - obsTextBox.Text.Length})";
        }
    }
}
