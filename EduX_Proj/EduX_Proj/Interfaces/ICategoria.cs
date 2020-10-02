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
        Categoria BuscarPorId(Guid id);
        void Adicionar(Categoria cat);
        void Alterar(Guid id, Categoria cat);
        void Remover(Guid id);
        Categoria BuscarPorId(int id);
        void Alterar(int id, Categoria cat);
        void Remover(int id); 
    }
}
