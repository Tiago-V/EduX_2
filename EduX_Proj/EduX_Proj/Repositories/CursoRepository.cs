using EduX_Proj.Contexts;
using EduX_Proj.Domains;
using EduX_Proj.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Repositories
{
    public class CursoRepository : ICurso
    {
        private readonly EduXContext _ctx;

        public CursoRepository()
        {
            _ctx = new EduXContext();
        }
<<<<<<< HEAD
        
=======

        /// <summary>
        /// Altera uma curtida.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="curso"></param>
        public void Alterar(int id, Curso curso)
        {
            try
            {
                Curso cursoTemp = BuscarPorID(id);

                _ctx.Curso.Update(cursoTemp);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Busca uma curtida pelo id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Curso BuscarPorID(int id)
        {
            try
            {
                return _ctx.Curso.Find(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Cadastra uma curtida do banco.
        /// </summary>
        /// <param name="curtida"></param>
        public void Adicionar(Curso curso)
        {
            try
            {
                _ctx.Curso.Add(curso);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Exclui uma curtida do banco.
        /// </summary>
        /// <param name="id"></param>
        public void Remover(int id)
        {
            try
            {
                Curso curso = BuscarPorID(id);

                if (curso == null)
                    throw new Exception("Produto não encontrado.");

                _ctx.Curso.Remove(curso);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Listar todas as curtidas cadastradas.
        /// </summary>
        /// <returns></returns>
        public List<Curso> ListarTodos()
        {
            try
            {
                return _ctx.Curso.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
>>>>>>> 5682cf44d1a7b3b5b56ae3395f63a504a55792b9
    }
}

