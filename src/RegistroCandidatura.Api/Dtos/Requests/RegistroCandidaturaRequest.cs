using System;

namespace RegistroCandidatura.Dtos.Requests
{
    public class RegistroCandidaturaRequest
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Vaga { get; set; }
        public decimal PretensaoSalarial { get; set; }
    }
}