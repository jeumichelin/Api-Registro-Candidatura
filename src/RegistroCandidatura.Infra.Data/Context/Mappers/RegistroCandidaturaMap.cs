using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RegistroCandidatura.Infra.Data.Context.Mappers
{
    public class RegistroCandidaturaMap : IEntityTypeConfiguration<Domain.Entities.RegistroCandidatura>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.RegistroCandidatura> builder)
        {
            builder.ToTable("RegistroCandidatura");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("ID");
            builder.Property(c => c.Nome).HasColumnName("NOME");
            builder.Property(c => c.Sobrenome).HasColumnName("SOBRENOME");
            builder.Property(c => c.Vaga).HasColumnName("VAGA");
            builder.Property(c => c.DataNascimento).HasColumnName("DATA_NASCIMENTO");
            builder.Property(c => c.PretensaoSalarial).HasColumnName("PRETENSAO_SALARIAL");
        }
    }
}