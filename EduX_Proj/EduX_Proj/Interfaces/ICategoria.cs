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
        void Adicionar(Categoria cat);
        void Alterar(int id, Categoria cat);
        void Remover(int id); 
    }
}
