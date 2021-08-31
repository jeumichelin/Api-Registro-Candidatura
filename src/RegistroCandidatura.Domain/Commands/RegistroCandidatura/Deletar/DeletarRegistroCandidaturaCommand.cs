using System;
using MediatR;

namespace RegistroCandidatura.Domain.Commands.RegistroCandidatura.Deletar
{
    public class DeletarRegistroCandidaturaCommand : IRequest
    {
        public string Id { get; set; }
    }
}