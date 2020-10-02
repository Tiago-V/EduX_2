using EduX_Proj.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Interface
{
    interface IProfessorTurma
    {
        List<IProfessorTurma> Listar();
        ProfessorTurma BuscarPorNome(string nome);
        void Adicionar(ProfessorTurma ProfessorT);
        void Alterar(ProfessorTurma ProfessorT);
        void Excluir(Guid id);
    }
}