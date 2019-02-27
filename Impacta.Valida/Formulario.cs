using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impacta.Valida
{
    public static class Formulario
    {
        public static bool Validar(Form formulario, ErrorProvider provedorErro)
        {

            foreach (Control controle in formulario.Controls)
            {
                if (controle.Tag == null)
                {
                    continue;
                }

                provedorErro.SetError(controle, "");


                if (controle.Tag.ToString().Contains("*") && controle.Text == string.Empty)
                {
                    DefinirError(provedorErro, controle, "Campo obrigatório.");
                }
                else
                {
                    ValidarTipoDado(controle, provedorErro);
                }
            }


            //return FormularioEstaSemErros(formulario, provedorErro);
            return !provedorErro.PossuiErro(formulario);
        }


        /// <summary>
        /// Metado usado para limpar o formulário.
        /// </summary>
        /// <param name="controle">Formulario a ser limpo</param>

        public static void Limpar(Control controle)
        {
            foreach (Control ctrl in controle.Controls)
            {
                if (ctrl is TextBox || ctrl is MaskedTextBox)
                {
                    ctrl.ResetText();
                }
                else if(ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;
                }

                Limpar(ctrl);
            }
        }

        private static bool PossuiErro(this ErrorProvider provedorErro, Form formulario)
        {
            foreach (Control controle in formulario.Controls)
            {
                if (provedorErro.GetError(controle) != string.Empty)
                {
                    return true;
                }
            }

            return false;
        }

        private static void DefinirError(ErrorProvider provedorErro, Control controle, string mensagem)
        {
            provedorErro.SetError(controle, mensagem);
            controle.Focus();
        }

        private static void ValidarTipoDado(Control controle, ErrorProvider provedorErro)
        {
            var controleTag = controle.Tag.ToString().ToUpper();

            if (controleTag.Contains("PLACA"))
            {
                // +: 1 - muitos
                // *:0 - muitos
                //?: 0 ou 1
                if (!Regex.IsMatch(controle.Text, @"^[A-Z]{1,3}[0-9]{4}$"))
                {
                    DefinirError(provedorErro, controle, "Digite a Placa no formato AAA-0000");
                }
            }
            else if (controleTag.Contains("ANO"))
            {
                if (!Regex.IsMatch(controle.Text, @"[0-9]{4}"))
                {
                    DefinirError(provedorErro, controle, "Digite o ano no formato YYYY");
                }
            }
        }
       
    }
}
