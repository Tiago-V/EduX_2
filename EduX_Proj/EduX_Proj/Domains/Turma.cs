using System;
using System.Collections.Generic;

namespace EduX_Proj.Domains
{
    public partial class Turma
    {
        public Turma()
        {
            AlunoTurma = new HashSet<AlunoTurma>();
            ProfessorTurma = new HashSet<ProfessorTurma>();
        }

        public Guid IdTurma { get; set; }
        public string Descricao { get; set; }
        public int IdCurso { get; set; }

        public virtual Instituicao IdCursoNavigation { get; set; }
        public virtual ICollection<AlunoTurma> AlunoTurma { get; set; }
        public virtual ICollection<ProfessorTurma> ProfessorTurma { get; set; }
    }
}
