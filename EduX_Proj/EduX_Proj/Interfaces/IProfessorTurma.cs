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
        void Cadastrar(ProfessorTurma professorT);
        void Alterar(int id, ProfessorTurma professorT);
        void Excluir(int id);
    }
}
