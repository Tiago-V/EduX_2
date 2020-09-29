using System;
using System.Collections.Generic;

namespace EduX_Proj.Domains
{
    public partial class Curso
    {
        public int IdCurso { get; set; }
        public string Titulo { get; set; }
        public int IdInstituicao { get; set; }

        public virtual Instituicao IdInstituicaoNavigation { get; set; }
    }
}
