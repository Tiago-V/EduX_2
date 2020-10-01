using EduX_Proj.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Interface
{
    interface IObjetivo
    {
        List<Objetivo> Listar();
        Objetivo BuscarPorID(int id);
        void Adicionar(Objetivo objetivo);
        void Alterar(int id, Objetivo objetivo);
        void Excluir(int id);
    }
}
