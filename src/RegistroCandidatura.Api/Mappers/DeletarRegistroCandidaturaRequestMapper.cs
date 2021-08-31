using RegistroCandidatura.Domain.Commands.RegistroCandidatura.Deletar;
using RegistroCandidatura.Dtos.Requests;

namespace RegistroCandidatura.Mappers
{
    public static class DeletarRegistroCandidaturaRequestMapper
    {
        public static DeletarRegistroCandidaturaCommand Map(RegistroCandidaturaRequest request)
        {
            return new DeletarRegistroCandidaturaCommand()
            {
                Id = request.Id,
            };
        }
    }
}