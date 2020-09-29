using EduX_Proj.Contexts;
using EduX_Proj.Domains;
using EduX_Proj.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Repositories
{
    public class ObjetivoRepository : IObjetivo
    {

        private readonly EduXContext ctx;

        public void Adicionar(Objetivo objetivo)
        {
            throw new NotImplementedException();
        }

        public void Alterar(int id, Objetivo objetivo)
        {
            throw new NotImplementedException();
        }

        public Objetivo BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public List<Objetivo> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
