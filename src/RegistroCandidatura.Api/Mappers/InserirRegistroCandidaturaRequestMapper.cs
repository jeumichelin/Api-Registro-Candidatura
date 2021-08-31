using RegistroCandidatura.Domain.Commands.RegistroCandidatura.Inserir;
using RegistroCandidatura.Dtos.Requests;

namespace RegistroCandidatura.Mappers
{
    public static class InserirRegistroCandidaturaRequestMapper
    {
        public static InserirRegistroCandidaturaCommand Map(RegistroCandidaturaRequest request)
        {
            return new InserirRegistroCandidaturaCommand()
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