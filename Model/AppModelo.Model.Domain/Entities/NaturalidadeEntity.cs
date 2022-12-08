using System;

namespace AppModelo.Model.Domain.Entities
{
    public class NaturalidadeEntity
    {
        /// <summary>
        /// Instancia todas as propriedades da classe NaturalidadeEntity.
        /// </summary>
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public bool Ativo { get; set; } 
    }
} 
