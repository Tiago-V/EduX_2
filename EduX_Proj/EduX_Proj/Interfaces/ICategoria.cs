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
        Categoria BuscarPorId(int id);
        void Cadastrar(Categoria cat);
        void Alterar(int id, Categoria cat);
        void Excluir(int id);
    }
}
