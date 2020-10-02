using EduX_Proj.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Interface
{
    interface IPerfil
    {
        List<Perfil> ListarTodos();
        Perfil BuscarPorID(int id);
        void Adicionar(Perfil perfil);
        void Alterar(int id, Perfil perfil);
        void Excluir(int id);
    }
}