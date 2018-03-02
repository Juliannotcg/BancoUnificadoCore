using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Domain.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BancoUnificadoCore.Api.Controllers
{
    public class ApresentanteController : Controller
    {
        private readonly IApresentanteRepository _repository;

        public ApresentanteController(IApresentanteRepository repository)
        {
            _repository = repository;
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
        public ICommandResult Post([FromBody]CreateCustomerCommand command)
        {
            var result = (CreateCustomerCommandResult)_handler.Handle(command);
            return result;
        }
    }
}
