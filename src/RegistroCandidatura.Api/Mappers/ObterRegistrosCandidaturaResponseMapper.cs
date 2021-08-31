using RegistroCandidatura.Dtos.Responses;

namespace RegistroCandidatura.Mappers
{
    public static class ObterRegistrosCandidaturaResponseMapper
    {
        public static RegistroCandidaturaResponse Map(Domain.Entities.RegistroCandidatura registroCandidatura)
        {
            return new RegistroCandidaturaResponse()
            {
                Id = registroCandidatura.Id.ToString(),
                Nome = registroCandidatura.Nome,
                Sobrenome = registroCandidatura.Sobrenome,
                Vaga = registroCandidatura.Vaga,
                DataNascimento = registroCandidatura.DataNascimento,
                PretensaoSalarial = registroCandidatura.PretensaoSalarial
            };
        }
    }
}