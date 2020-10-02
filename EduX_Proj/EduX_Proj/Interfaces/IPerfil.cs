using EduX_Proj.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Interface
{
    interface IPerfil
    {
        void Adicionar(Perfil perfil);
        void Excluir(int id);
        void Editar(Perfil perfil);
        List<Perfil> Listar();
        Perfil BuscarID(int id);
    }
}