using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RegistroCandidatura.Domain.Interfaces.Repositories;

namespace RegistroCandidatura.Domain.Commands.RegistroCandidatura.Inserir
{
    public class InserirRegistroCandidaturaCommandHandler : IRequestHandler<InserirRegistroCandidaturaCommand,string>
    {
        private readonly IRegistroCandidaturaRepository _repository;

        public InserirRegistroCandidaturaCommandHandler(IRegistroCandidaturaRepository repository)
        {
            _repository = repository;
        }
        public async Task<string> Handle(InserirRegistroCandidaturaCommand request, CancellationToken cancellationToken)
        {
            var novoRegistroCandidatura = new Entities.RegistroCandidatura(new Guid(), request.Nome, request.Sobrenome,
                request.DataNascimento, request.Vaga, request.PretensaoSalarial); 
            return await _repository.InserirRegistroCandidaturasAsync(novoRegistroCandidatura, cancellationToken);
        }
    }
}