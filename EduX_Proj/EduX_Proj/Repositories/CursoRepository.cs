using EduX_Proj.Contexts;
using EduX_Proj.Domains;
using EduX_Proj.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Repositories
{
    public class CursoRepository : ICurso
    {
        private readonly EduXContext _ctx;

        public CursoRepository()
        {
            _ctx = new EduXContext();
        }
        
    }
}
