using System.Collections.Generic;
using System.Linq;
using RegistroCandidatura.Dtos.Responses;

namespace RegistroCandidatura.Mappers
{
    public static class ListarRegistrosCandidaturaResponseMapper
    {
        public static IEnumerable<RegistroCandidaturaResponse> Map(IEnumerable<Domain.Entities.RegistroCandidatura> registrosCandidaturas)
        {
            return registrosCandidaturas.Select(c => new RegistroCandidaturaResponse()
            {
                Id = c.Id.ToString(),
                Nome = c.Nome,
                Sobrenome = c.Sobrenome,
                Vaga = c.Vaga,
                DataNascimento = c.DataNascimento,
                PretensaoSalarial = c.PretensaoSalarial
            });
        }
    }
}