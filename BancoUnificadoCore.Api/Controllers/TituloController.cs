using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoUnificadoCore.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BancoUnificadoCore.Api.Controllers
{
    public class TituloController : Controller
    {
        private readonly ITituloRepositoryDapper _repositoryDapper;

        public TituloController(ITituloRepositoryDapper repositoryDapper)
        {
            _repositoryDapper = repositoryDapper;
        }

        //[HttpGet]
        //[Route("v1/apresentantes/{codigoApresentante}")]
        //public GetApresentanteResult GetByCodigoApresentante(string codigo)
        //{
        //    return _repositoryDapper.GetByCodigoApresentante(codigo);
        //}

        //[HttpGet]
        //[Route("v1/apresentante")]
        //public IEnumerable<GetApresentanteResult> Get()
        //{
        //    return _repositoryDapper.GetAll();
        //}

        //[HttpPost]
        //[Route("v1/apresentante")]
        //public ICommandResult Post([FromBody]CommandCreateApresentante command)
        //{
        //    var result = (CommandCreateApresentanteResult)_handler.Handle(command);
        //    return result;
        //}
    }
}