﻿using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Controller.Cadastros
{
    public class NaturalidadeController
    {
        public bool Cadastrar(string descricao)
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.Inserir(descricao);
            return resposta;
        }

        public List<NaturalidadeEntity> ObterTodasNaturalidades()
        {
            var repositorio = new NaturalidadeRepository();
            var reposta = repositorio.ObterTodos();
            return (List<NaturalidadeEntity>)reposta;
        }
    }
}