using BancoUnificadoCore.Shared.Entities;

namespace BancoUnificadoCore.Domain.Entities
{
    public class CargaDiaria : Entity
    {
        public CargaDiaria(Titulo titulo)
        {
            this.titulo = titulo;
        }

        public Titulo titulo { get; private set; }
    }
}
