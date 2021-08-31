using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RegistroCandidatura.Domain.Interfaces.Repositories;

namespace RegistroCandidatura.Domain.Commands.RegistroCandidatura.Obter
{
    public class ObterRegistroCandidaturaCommandHandler : IRequestHandler<Obter.ObterRegistroCandidaturaCommand, Entities.RegistroCandidatura>
    {
        private readonly IRegistroCandidaturaRepository _repository;

        public ObterRegistroCandidaturaCommandHandler(IRegistroCandidaturaRepository repository)
        {
            _repository = repository;
        }
        public async Task<Entities.RegistroCandidatura> Handle(Obter.ObterRegistroCandidaturaCommand request, CancellationToken cancellationToken)
        {
            return await _repository.ObterRegistroCandidaturaAsync(request.Id, cancellationToken);
        }
    }
}