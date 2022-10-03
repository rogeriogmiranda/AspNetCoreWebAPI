namespace SmartSchool.WebAPI.Models
{
    public class Disciplina
    {
        public Disciplina(){ }
        public Disciplina(int id, string nome, int proferssorId)
        {
            this.Id = id;
            this.Nome = nome;
            this.ProferssorId = proferssorId;

        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public int ProferssorId { get; set; }
        public Professor Professor { get; set; }

        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }
    }
}