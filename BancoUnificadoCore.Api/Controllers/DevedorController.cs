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
    public class DevedorController : Controller
    {
        private readonly IDevedorRepositoryDapper _repositoryDapper;

        public DevedorController(IDevedorRepositoryDapper repositoryDapper)
        {
            _repositoryDapper = repositoryDapper;
        }

        [HttpGet]
        [Route("v1/devedor/{documento}")]
        public GetDevedorResult GetByCodigoApresentante(string documento)
        {
            return _repositoryDapper.GetByDocumentoDevedor(documento);
        }
    }
}
