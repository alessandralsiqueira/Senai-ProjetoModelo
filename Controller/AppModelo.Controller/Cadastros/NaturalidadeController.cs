using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System.Collections.Generic;

namespace AppModelo.Controller.Cadastros
{
    public class NaturalidadeController
    {
        /// <summary>
        /// Cadastrar - Inserir uma nova Naturalidade no NaturalidadeRepository.
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="status"></param>
        /// <returns>Insere a Naturalidade no banco de dados</returns>
        public bool Cadastrar(string descricao, bool status) 
        {
            var repositorio = new NaturalidadeRepository();
            var naturalidade = repositorio.ObterPorDescricao(descricao);
            if (naturalidade is not null) return false;

            var resposta = repositorio.Inserir(descricao, status);
            return resposta;
        }

        /// <summary>
        /// Atualiza uma Naturalidade no NaturalidadeRepository.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="descricao"></param>
        /// <returns>Atualiza a Naturalidade cadastrada no banco de dados</returns>
        public bool Atualizar(int id, string descricao)
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.Atualizar(id, descricao);
            return resposta;
        }

        /// <summary>
        /// Remove uma Naturalidade no NaturalidadeRepository.
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns>Deleta a Naturalidade cadastrada no banco de dados</returns>
        public bool Remover(string descricao)
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.Remover(descricao);
            return resposta;
        }

        /// <summary>
        /// Método público que retorna uma lista do tipo NaturalidadeEntity
        /// </summary>
        /// <returns>Este método preenche uma lista advinda do NaturalidadeRepository</returns>
        public List<NaturalidadeEntity> ObterTodasNaturalidades()
        {
            var repositorio = new NaturalidadeRepository();
            var reposta = repositorio.ObterTodos();
            return (List<NaturalidadeEntity>)reposta;
        }
    }
}
