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
<<<<<<< HEAD
        Categoria BuscarPorId(int id);
        void Adicionar(Categoria cat);
=======
        Categoria BuscarPorID(int id);
        void Cadastrar(Categoria cat);
>>>>>>> 213c00a4013a247c38589b09c467e6577a44f4c4
        void Alterar(int id, Categoria cat);
        void Excluir(int id);
    }
}
