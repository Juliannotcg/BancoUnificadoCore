using BancoUnificadoCore.Domain.Commands;
using BancoUnificadoCore.Domain.Handlers;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Domain.Queries;
using BancoUnificadoCore.Shared.Commands;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BancoUnificadoCore.Api.Controllers
{
    public class ApresentanteController : Controller
    {
        private readonly IApresentanteRepository _repository;
        private readonly IApresentanteRepositoryDapper _repositoryDapper;
        private readonly ApresentanteHandler _handler;

        public ApresentanteController(IApresentanteRepository repository, IApresentanteRepositoryDapper repositoryDapper, ApresentanteHandler handler)
        {
            _repository = repository;
            _repositoryDapper = repositoryDapper;
            _handler = handler;
        }
        
        [HttpGet]
        [Route("v1/apresentantes/{id}")]
        [ResponseCache(Duration = 15)]
        public GetApresentanteResult GetById(Guid id)
        {
            return _repository.Get(id);
        }

        [HttpGet]
        [Route("v1/apresentantes/{codigoApresentante}")]
        public GetApresentanteResult GetByCodigoApresentante(string codigo)
        {
            return _repositoryDapper.GetByCodigoApresentante(codigo);
        }

        [HttpGet]
        [Route("v1/apresentante")]
        public IEnumerable<GetApresentanteResult> Get()
        {
            return _repositoryDapper.GetAll();
        }

        [HttpPost]
        [Route("v1/apresentante")]
        public ICommandResult Post([FromBody]CommandCreateApresentante command)
        {
            var result = (CommandCreateApresentanteResult)_handler.Handle(command);
            return result;
        }
    }
}
