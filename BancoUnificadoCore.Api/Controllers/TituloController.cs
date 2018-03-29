using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Domain.Queries.Titulo;
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
 
        [HttpGet]
        [Route("v1/titulo/{protocolo}")]
        public GetTituloResult GetTituloProtocolo(string protocolo)
        {
            return _repositoryDapper.GetTituloProtocolo(protocolo);
        }
    }
}