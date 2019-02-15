using System;
using System.Windows.Forms;

namespace CSharp.Cap2.Visual
{
    public partial class VisulForm : Form
    {
        public VisulForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            imgOpenFileDialog.Filter = "Arquivos de imagens| *.jpg;*.bmp;*.png|Arquivos jpg|*.jpg";
            imgOpenFileDialog.ShowDialog();
            imgPictureBox.ImageLocation = imgOpenFileDialog.FileName;
        }

        private void VisulForm_Load(object sender, EventArgs e)
        {

        }
    }
}
