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
        public bool Cadastrar(string descricao)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Inserir(descricao);
            return resposta;
        } 
        public List<NacionalidadeEntity> ObterTodasNacionalidades()
        {
            var repositorio = new NacionalidadeRepository();
            var reposta = repositorio.ObterTodos();
            return (List<NacionalidadeEntity>)reposta; 
        }
        public bool Remover(string descricao)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Remover(descricao);
            return resposta; 
        }
        public bool Atualizar(int id, string descricao)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Atualizar(id, descricao);
            return resposta;
        }
        
    }
}
