using EduX_Proj.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Interfaces
{
    interface IAlunoTurma
    {
        List<AlunoTurma> ListarTodos();
        AlunoTurma BuscarPorID(Guid id);
        void Adicionar(AlunoTurma a);
        void Alterar(Guid id, AlunoTurma a);
        void Remover(Guid id);
    }
}
