using BancoUnificadoCore.Domain.Commands;
using BancoUnificadoCore.Domain.Handlers;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Shared.Commands;
using Microsoft.AspNetCore.Mvc;

namespace BancoUnificadoCore.Api.Controllers
{
    public class CargaDiariaController : Controller
    {
        
        private readonly CargaDiariaHandler _handler;

        public CargaDiariaController(CargaDiariaHandler handler)
        {
            _handler = handler;
        }

        [HttpPost]
        [Route("v1/cargaDiaria")]
        public ICommandResult Post([FromBody]CommandCreateCargaDiaria command)
        {
            var result = (CommandCreateCargaDiariaResult)_handler.Handle(command);
            return result;
        }
    }
}