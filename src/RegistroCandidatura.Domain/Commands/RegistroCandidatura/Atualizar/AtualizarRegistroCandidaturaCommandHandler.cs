using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RegistroCandidatura.Domain.Interfaces.Repositories;

namespace RegistroCandidatura.Domain.Commands.RegistroCandidatura.Atualizar
{
    public class AtualizarRegistroCandidaturaCommandHandler : IRequestHandler<Atualizar.AtualizarRegistroCandidaturaCommand>
    {
        private readonly IRegistroCandidaturaRepository _repository;

        public AtualizarRegistroCandidaturaCommandHandler(IRegistroCandidaturaRepository repository)
        {
            _repository = repository;
        }
        
        public async Task<Unit> Handle(Atualizar.AtualizarRegistroCandidaturaCommand request, CancellationToken cancellationToken)
        {
            var registroCandidatura = new Entities.RegistroCandidatura(Guid.Parse(request.Id), request.Nome, request.Sobrenome,
                request.DataNascimento, request.Vaga, request.PretensaoSalarial);
            
            await _repository.AtualizarRegistroCandidaturasAsync(registroCandidatura, cancellationToken);
            
            return Unit.Value;
        }
    }
}