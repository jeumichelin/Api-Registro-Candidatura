using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RegistroCandidatura.Domain.Interfaces.Repositories;

namespace RegistroCandidatura.Domain.Commands.RegistroCandidatura.Listar
{
    public class ListarRegistroCandidaturaCommandHandler : IRequestHandler<Listar.ListarRegistroCandidaturaCommand, IEnumerable<Entities.RegistroCandidatura>>
    {
        private readonly IRegistroCandidaturaRepository _repository;

        public ListarRegistroCandidaturaCommandHandler(IRegistroCandidaturaRepository repository)
        {
            _repository = repository;
        }
        
        public async Task<IEnumerable<Entities.RegistroCandidatura>> Handle(Listar.ListarRegistroCandidaturaCommand request, CancellationToken cancellationToken)
        {
            return await _repository.ListarCandidaturasAsync();
        }
    }
}