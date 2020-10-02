using EduX_Proj.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Interfaces
{
    interface ICategoria
    {
        List<Categoria> ListarTodos();
        Categoria BuscarPorID(int id);
        void Cadastrar(Categoria categoria);
        void Alterar(int id, Categoria categoria);
        void Excluir(int id);
    }
}
