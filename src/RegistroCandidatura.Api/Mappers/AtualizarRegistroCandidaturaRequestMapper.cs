using RegistroCandidatura.Domain.Commands.RegistroCandidatura.Atualizar;
using RegistroCandidatura.Dtos.Requests;

namespace RegistroCandidatura.Mappers
{
    public static class AtualizarRegistroCandidaturaRequestMapper
    {
        public static AtualizarRegistroCandidaturaCommand Map(RegistroCandidaturaRequest request)
        {
            return new AtualizarRegistroCandidaturaCommand()
            {
                Id = request.Id,
                Nome = request.Nome,
                Sobrenome = request.Sobrenome,
                Vaga = request.Vaga,
                DataNascimento = request.DataNascimento,
                PretensaoSalarial = request.PretensaoSalarial
            };
        }
    }
}