using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace RegistroCandidatura.Domain.Interfaces.Repositories
{
    public interface IRegistroCandidaturaRepository
    {
        Task<IEnumerable<Entities.RegistroCandidatura>> ListarCandidaturasAsync(CancellationToken cancellationToken = default);
        Task<string> InserirRegistroCandidaturasAsync(Entities.RegistroCandidatura registroCandidatura, CancellationToken cancellationToken = default);
        Task DeletarRegistroCandidaturasAsync(string id, CancellationToken cancellationToken = default);
        Task AtualizarRegistroCandidaturasAsync(Entities.RegistroCandidatura registroCandidatura, CancellationToken cancellationToken = default);
        Task<Entities.RegistroCandidatura> ObterRegistroCandidaturaAsync(string id, CancellationToken cancellationToken = default);
    }
}