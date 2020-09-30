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
        AlunoTurma BuscarPorID(int id);
        void Adicionar(AlunoTurma a);
        void Alterar(int id, AlunoTurma a);
        void Remover(int id);
    }
}
