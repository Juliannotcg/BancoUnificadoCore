using BancoUnificadoCore.Domain.Commands;
using BancoUnificadoCore.Domain.Handlers;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Domain.Queries;
using BancoUnificadoCore.Shared.Commands;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BancoUnificadoCore.Api.Controllers
{
    public class ApresentanteController : Controller
    {
        private readonly IApresentanteRepository _repository;
        private readonly ApresentanteHandler _handler;

        public ApresentanteController(IApresentanteRepository repository, ApresentanteHandler handler)
        {
            _repository = repository;
            _handler = handler;
        }
        
        [HttpGet]
        [Route("v1/apresentantes/{id}")]
        [ResponseCache(Duration = 15)]
        public GetApresentanteResult GetById(Guid id)
        {
            return _repository.Get(id);
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
