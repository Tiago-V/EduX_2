using EduX_Proj.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Interfaces
{
    interface IInstituicao
    {
        List<Instituicao> ListarTodos();
        Instituicao BuscarPorID(int id);
        void Adicionar(Instituicao i);
        void Alterar(int id, Instituicao i);
        void Remover(int id);
    }
}
