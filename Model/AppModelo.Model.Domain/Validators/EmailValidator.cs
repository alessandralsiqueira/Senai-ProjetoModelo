using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

namespace AppModelo.Model.Domain.Validators
{
    public static partial class Validadores
    {
        /// <summary>
        /// Método que valida o endereço de email inserido
        /// </summary>
        /// <param name="inputEmail"></param>
        /// <returns>Retorna dizendo se o email é válido ou não</returns>
        public static bool EmailEValido(string inputEmail)
        {
            var strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                           @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                           @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            var re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
    }
}
