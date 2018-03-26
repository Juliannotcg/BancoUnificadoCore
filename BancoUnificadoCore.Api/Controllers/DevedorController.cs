using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoUnificadoCore.Domain.Commands;
using BancoUnificadoCore.Domain.Handlers;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Domain.Queries;
using BancoUnificadoCore.Shared.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BancoUnificadoCore.Api.Controllers
{
    public class DevedorController : Controller
    {
        private readonly IDevedorRepositoryDapper _repositoryDapper;
        private readonly IDevedorRepositoryEntity _repositoryEntity;
        private readonly DevedorHandler _handler;

        public DevedorController(IDevedorRepositoryDapper repositoryDapper, IDevedorRepositoryEntity repositoryEntity, DevedorHandler handler)
        {
            _repositoryDapper = repositoryDapper;
            _repositoryEntity = repositoryEntity;
            _handler = handler;
        }

        [HttpGet]
        [Route("v1/devedor/{documento}")]
        public GetDevedorResult GetByCodigoApresentante(string documento)
        {
            return _repositoryDapper.GetByDocumentoDevedor(documento);
        }


        [HttpPost]
        [Route("v1/devedor")]
        public ICommandResult Post([FromBody]CommandCreateDevedor command)
        {
            var result = (CommandCreateApresentanteResult)_handler.Handle(command);
            return result;
        }
    }
}
