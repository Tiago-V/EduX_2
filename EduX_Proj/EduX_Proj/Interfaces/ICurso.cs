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
        Curso BuscarPorID(int id);
        void Adicionar(Curso curso);
        void Alterar(int id, Curso curso);
        void Remover(int id);
    }
}
