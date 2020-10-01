using EduX_Proj.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Interfaces
{
    interface ICurso
    {
        List<Curso> ListarTodos();
        Curso BuscarPorId(Guid id);
        void Adicionar(Curso curso);
        void Alterar(Guid id, Curso curso);
        void Remover(Guid id);
    }
}
