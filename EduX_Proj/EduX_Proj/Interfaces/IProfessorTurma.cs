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
<<<<<<< HEAD
        void Adicionar(ProfessorTurma ProfessorT);
        void Alterar(int id, ProfessorTurma ProfessorT);
=======
        void Cadastrar(ProfessorTurma professorT);
        void Alterar(int id, ProfessorTurma professorT);
>>>>>>> 213c00a4013a247c38589b09c467e6577a44f4c4
        void Excluir(int id);
    }
}