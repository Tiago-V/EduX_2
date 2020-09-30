using EduX_Proj.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Interfaces
{
    interface IUsuario
    {
        List<Usuario> ListarTodos();
        Usuario BuscarPorID(int id);
        void Adicionar(Usuario u);
        void Alterar(int id, Usuario u);
        void Remover(int id);
    }
}
