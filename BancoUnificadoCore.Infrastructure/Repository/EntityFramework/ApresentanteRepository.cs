using BancoUnificadoCore.Domain.Entities;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Infrastructure.Context;

namespace BancoUnificadoCore.Infrastructure.Repository.EntityFramework
{
    public class ApresentanteRepository : Repository<Apresentante>, IApresentanteRepository
    {
        public ApresentanteRepository(BancoUnificadoCoreContext context) 
            : base(context)
        {
        }

    }
}
