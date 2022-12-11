using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.View.Windows.Helpers
{
    internal static partial class Componentes 
    {
        /// <summary>
        /// Método criado para verificar se há números onde só pode ter texto.
        /// </summary>
        /// <param name="texto"></param>
        /// <returns>Faz a verificação de números</returns>
        internal static bool ExisteNumeroNoTexto(string texto)
        {
            foreach (var letra in texto)
            {
                if (char.IsNumber(letra))
                {
                    return true;
                }
            }
            return false; 
        }
    }
}
