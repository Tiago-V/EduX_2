using EduX_Proj.Contexts;
using EduX_Proj.Domains;
using EduX_Proj.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Repositories
{
    public class ObjetivoAlunoRepository : IObjetivoAluno
    {
        private readonly EduXContext _ctx;

        public ObjetivoAlunoRepository()
        {
            _ctx = new EduXContext();
        }

        public void Adicionar(ObjetivoAluno ObjetivoA)
        {
            try
            {
                _ctx.ObjetivoAluno.Add(ObjetivoA);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Alterar(int id, ObjetivoAluno ObjetivoA)
        {
            try
            {
                ObjetivoAluno objetivoATemp = BuscarPorID(id);

                objetivoATemp.Nota = ObjetivoA.Nota;
                objetivoATemp.DataAlcancado = ObjetivoA.DataAlcancado;

                _ctx.ObjetivoAluno.Update(objetivoATemp);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public ObjetivoAluno BuscarPorID(int id)
        {
            try
            {
                return _ctx.ObjetivoAluno.Find(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Excluir(int id)
        {
            try
            {
                ObjetivoAluno objetivoA = BuscarPorID(id);

                if (objetivoA == null)
                    throw new Exception("Produto não encontrado.");

                _ctx.ObjetivoAluno.Remove(objetivoA);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<ObjetivoAluno> Listar()
        {
            try
            {
                return _ctx.ObjetivoAluno.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
