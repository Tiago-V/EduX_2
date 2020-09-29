using EduX_Proj.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Interface
{
    interface ICurtida
    {

        List<Curtida> ListarTodos();
        Curtida BuscarPorID(int id);
        void Cadastrar(Curtida curtida);
        void Alterar(int id, Curtida curtida);
        void Excluir(int id);

    }
}
