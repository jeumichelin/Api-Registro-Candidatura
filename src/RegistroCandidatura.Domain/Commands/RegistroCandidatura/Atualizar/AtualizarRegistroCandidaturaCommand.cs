using System;
using MediatR;

namespace RegistroCandidatura.Domain.Commands.RegistroCandidatura.Atualizar
{
    public class AtualizarRegistroCandidaturaCommand : IRequest
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Vaga { get; set; }
        public decimal PretensaoSalarial { get; set; }
    }
}