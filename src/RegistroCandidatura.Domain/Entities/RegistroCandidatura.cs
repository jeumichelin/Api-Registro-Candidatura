using System;

namespace RegistroCandidatura.Domain.Entities
{
    public class RegistroCandidatura
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Vaga { get; set; }
        public decimal PretensaoSalarial { get; set; }

        private RegistroCandidatura()
        {
            
        }

        public RegistroCandidatura(Guid id, string nome, string sobrenome, DateTime dataNascimento, string vaga, decimal pretensaoSalarial)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            Vaga = vaga;
            PretensaoSalarial = pretensaoSalarial;
        }
    }
}