using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RegistroCandidatura.Domain.Interfaces.Repositories;
using RegistroCandidatura.Infra.Data.Context;

namespace RegistroCandidatura.Infra.Data.Repositories.RegistroCandidatura
{
    public class RegistroCandidaturaRepository : IRegistroCandidaturaRepository
    {
        private readonly RegistroCandidaturaContext _context;

        public RegistroCandidaturaRepository(RegistroCandidaturaContext context)
        {
            _context = context;
        }
        
        public async Task<IEnumerable<Domain.Entities.RegistroCandidatura>> ListarCandidaturasAsync(CancellationToken cancellationToken = default)
        {
            return await _context.RegistrosCandidaturas.ToListAsync(cancellationToken);
        }

        public async Task<string> InserirRegistroCandidaturasAsync(Domain.Entities.RegistroCandidatura registroCandidatura, CancellationToken cancellationToken = default)
        {
            await _context.RegistrosCandidaturas.AddAsync(registroCandidatura, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return registroCandidatura.Id.ToString();
        }

        public async Task DeletarRegistroCandidaturasAsync(string id, CancellationToken cancellationToken = default)
        {
            _context.RegistrosCandidaturas.Remove(await ObterRegistroCandidaturaAsync(id));
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task AtualizarRegistroCandidaturasAsync(Domain.Entities.RegistroCandidatura registroCandidatura, CancellationToken cancellationToken = default)
        {
            _context.RegistrosCandidaturas.Update(registroCandidatura);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<Domain.Entities.RegistroCandidatura> ObterRegistroCandidaturaAsync(string id, CancellationToken cancellationToken = default)
        {
            return await _context.RegistrosCandidaturas.FirstOrDefaultAsync(c => c.Id.ToString() == id, cancellationToken: cancellationToken);
        }
    }
}