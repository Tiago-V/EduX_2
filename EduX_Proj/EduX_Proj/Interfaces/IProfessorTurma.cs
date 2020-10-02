using EduX_Proj.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Interface
{
    interface IProfessorTurma
    {
        List<ProfessorTurma> ListarTodos();
        ProfessorTurma BuscarPorID(int id);
        void Adicionar(ProfessorTurma ProfessorT);
        void Alterar(int id, ProfessorTurma ProfessorT);
        void Excluir(int id);
    }
}