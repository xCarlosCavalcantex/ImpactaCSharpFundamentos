using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp.Cap3.Variaveis
{


    public partial class VariaveisForm : Form
    {
        int x = 32;
        int w = 45;
        int y = 16;
        int z = 32;

        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void aritmeticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    string nome = "Nesk";
        //    var bim1 = 7.1;
        //    bool aprov = true;

        //    string @class = "3a B"; //Class é uma palavra reservada, colocando @ deixa de ser

            DateTime dataNasc = new DateTime(1970, 12, 25);
            var dataEmbarque = Convert.ToDateTime("14/02/2019");

            var a = 2;
            int b = 6, c = 10, d = 13;

            object meuObjeto = new object();
            meuObjeto = "Meu Objeto";
            meuObjeto = 12;
            meuObjeto = 3.5;

            resultListBox.Items.Add("a = " + a);
            resultListBox.Items.Add(string.Concat("b = ", b));
            resultListBox.Items.Add(string.Format("c = {0}", c));
            resultListBox.Items.Add($"d = {d}");

            resultListBox.Items.Add($"c * d = {c * d}");
            resultListBox.Items.Add($"d / a = {d / a}");
            resultListBox.Items.Add($"b % a = {b % a}");
        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 5;

            resultListBox.Items.Add($"x = {x}");

            x = x - 3;
            x -= 3;
            resultListBox.Items.Add($"x = {x}");
        }

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a;
            a = 5;

            resultListBox.Items.Add("Exemplo de Pré-Incremental");

            resultListBox.Items.Add($"a = {a}");
            resultListBox.Items.Add($"2 + ++a = {2 + ++a}");
            resultListBox.Items.Add($"a = {a}");

            a = 5;
            resultListBox.Items.Add("Exemplo de Pós-Incremental");

            resultListBox.Items.Add($"a = {a}");
            resultListBox.Items.Add($"2 + ++a = {2 + a++}");
            resultListBox.Items.Add($"a = {a}");

        }

        private void booleanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirVariaveis();

            resultListBox.Items.Add($"w <= x = {w <= x}");
            resultListBox.Items.Add($"x = z = {x == z}");
            resultListBox.Items.Add($"x != z = {x != z}");
        }

        private void ExibirVariaveis()
        {
            resultListBox.Items.Add($"x = {x}");
            resultListBox.Items.Add($"w = {w}");
            resultListBox.Items.Add($"y = {y}");
            resultListBox.Items.Add($"z = {z}");

            resultListBox.Items.Add("--------------------------------");
        }

        private void logicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirVariaveis();

            resultListBox.Items.Add($"w < x || y == 16 = {w < x || y == 16}");
            resultListBox.Items.Add($"x == z && z != x = {x == z && z != x}");
            resultListBox.Items.Add($"!(y > w) = {!(y > w)}");


        }

        private void ternariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ano;

            ano = 2014;
            resultListBox.Items.Add(
                $"O ano {ano} é bissexto?{(ano % 4 == 0 ? " Sim" : " Não")}");

            ano = 2016;
            resultListBox.Items.Add(
                $"O ano {ano} é bissexto?{(DateTime.IsLeapYear(ano) ? " Sim" : " Não")}");

            string resposta;
            if (DateTime.IsLeapYear(ano))
            {
                resposta = " Sim";
                resultListBox.Items.Add(resposta);
            }
            else
            {
                resposta = " Não";
                resultListBox.Items.Add(resposta);
            }

        }
    }
}
