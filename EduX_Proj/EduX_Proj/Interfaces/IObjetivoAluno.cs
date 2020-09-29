using EduX_Proj.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Interface
{
    interface IObjetivoAluno
    {
        List<ObjetivoAluno> Listar();
        ObjetivoAluno BuscarPorID(int id);
        void Adicionar(ObjetivoAluno ObjetivoA);
        void Alterar(int id, ObjetivoAluno ObjetivoA);
        void Excluir(int id);
    }
}
