using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Domain.Entities
{
    public class UsuarioEntity
    {
        /// <summary>
        /// Instancia todas as propriedades da classe UsuarioEntity.
        /// </summary>
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime UltimoLogin { get; set; }  
    }
}
