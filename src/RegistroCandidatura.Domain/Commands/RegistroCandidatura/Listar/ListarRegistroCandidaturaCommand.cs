using System;
using System.Collections.Generic;
using MediatR;

namespace RegistroCandidatura.Domain.Commands.RegistroCandidatura.Listar
{
    public class ListarRegistroCandidaturaCommand : IRequest<IEnumerable<Entities.RegistroCandidatura>>
    {
    }
}