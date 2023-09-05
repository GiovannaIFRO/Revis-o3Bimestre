

namespace Revisão3Bimestre
{
    public class Paciente
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public DateTime DataNasc { get; set; }

        public Paciente(int id, string nome, string cpf, string email, DateTime dataNasc)
        {
            this.Id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.DataNasc = dataNasc;
        }
    }
}
