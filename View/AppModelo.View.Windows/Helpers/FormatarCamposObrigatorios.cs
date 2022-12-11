using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Helpers
{
    /// <summary>
    /// Método criado para "obrigar" o usuário a preencher os campos obrigatórios.
    /// </summary>
    internal static partial class Componentes
    {
        internal static void FormatarCamposObrigatorios(Form frm)
        {
            Action<Control.ControlCollection> func = null;
            // func é uma funcao  anônima que recebe todods os controles do formulário
            // e de acordo com o switch aplica as formatações
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    switch (control)
                    {
                        case TextBox box:
                            {
                                if (box.Tag == "Obrigatorio")
                                {
                                    box.BackColor = Color.LightGoldenrodYellow;
                                }
                                break;
                            }
                        case MaskedTextBox box:
                            {
                                if (box.Tag == "Obrigatorio")
                                {
                                    box.BackColor = Color.LightGoldenrodYellow;
                                }
                                break;
                            }
                        case ComboBox box:
                            {
                                if (box.Tag == "Obrigatorio")
                                {
                                    box.BackColor = Color.LightGoldenrodYellow;
                                }
                                break;
                            }
                        default:
                            func(control.Controls);
                            break;
                    }

                }
            }; 
            func(frm.Controls);
        }
    }
}
