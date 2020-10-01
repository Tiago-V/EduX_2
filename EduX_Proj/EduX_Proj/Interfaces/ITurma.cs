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
        Turma BuscarPorID(int id);
        void Adicionar(Turma t);
        void Alterar(int id, Turma t);
        void Remover(int id);
    }
}
