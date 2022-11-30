using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Controller.Cadastros
{
    public class NacionalidadeController
    {
        /// <summary>
        /// Cadastrar - Inserir uma nova Nacionalidade no NacionalidadeRepository.
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns>Insere a Nacionalidade no banco de dados</returns>
        public bool Cadastrar(string descricao) 
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Inserir(descricao);
            return resposta;
        }

        /// <summary>
        /// Método público que retorna uma lista do tipo NacionalidadeEntity
        /// </summary>
        /// <returns>Este método preenche uma lista advinda do NacionalidadeRepository</returns>
        public List<NacionalidadeEntity> ObterTodasNacionalidades()
        {
            var repositorio = new NacionalidadeRepository();
            var reposta = repositorio.ObterTodos();
            return (List<NacionalidadeEntity>)reposta; 
        }

        /// <summary>
        /// Remove uma Nacionalidade no NacionalidadeRepository.
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns>Deleta a Nacionalidade cadastrada no banco de dados</returns>
        public bool Remover(string descricao)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Remover(descricao);
            return resposta; 
        }

        /// <summary>
        /// Atualiza uma Nacionalidade no NacionalidadeRepository.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="descricao"></param>
        /// <returns>Atualiza a Nacionalidade cadastrada no banco de dados</returns>
        public bool Atualizar(int id, string descricao)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Atualizar(id, descricao);
            return resposta;
        }
        
    }
}
