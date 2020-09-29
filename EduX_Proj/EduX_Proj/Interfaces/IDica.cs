using EduX_Proj.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Interface
{
    interface IDica
    {
        List<Dica> ListarTodos();
        Dica BuscarPorID(int id);
        void Cadastrar(Dica dica);
        void Alterar(int id, Dica dica);
        void Excluir(int id);

    }
}
