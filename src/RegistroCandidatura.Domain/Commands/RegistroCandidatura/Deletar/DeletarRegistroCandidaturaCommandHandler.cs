using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RegistroCandidatura.Domain.Interfaces.Repositories;

namespace RegistroCandidatura.Domain.Commands.RegistroCandidatura.Deletar
{
    public class DeletarRegistroCandidaturaCommandHandler : IRequestHandler<Deletar.DeletarRegistroCandidaturaCommand>
    {
        private readonly IRegistroCandidaturaRepository _repository;

        public DeletarRegistroCandidaturaCommandHandler(IRegistroCandidaturaRepository repository)
        {
            _repository = repository;
        }
        
        public async Task<Unit> Handle(Deletar.DeletarRegistroCandidaturaCommand request, CancellationToken cancellationToken)
        {
            
            await _repository.DeletarRegistroCandidaturasAsync(request.Id, cancellationToken);
            return Unit.Value;
        }
    }
}