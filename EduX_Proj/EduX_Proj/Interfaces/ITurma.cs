using EduX_Proj.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Interfaces
{
    interface ITurma
    {
        List<Turma> ListarTodos();
        Turma BuscarPorID(Guid id);
        void Adicionar(Turma t);
        void Alterar(Guid id, Turma t);
        void Remover(Guid id);
    }
}
