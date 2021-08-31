using MediatR;

namespace RegistroCandidatura.Domain.Commands.RegistroCandidatura.Obter
{
    public class ObterRegistroCandidaturaCommand : IRequest<Entities.RegistroCandidatura>
    {
        public string Id { get; set; }
    }
}