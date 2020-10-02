using EduX_Proj.Contexts;
using EduX_Proj.Domains;
using EduX_Proj.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EduX_Proj.Repositories
{
    public class ProfessorTurmaRepository : IProfessorTurma
    {

        private readonly EduXContext _ctx;
        public ProfessorTurmaRepository()
        {
            _ctx = new EduXContext();
        }


        /// <summary>
        /// Altera uma curtida.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="curtida"></param>
        public void Alterar(int id, ProfessorTurma professorT)
        {
            try
            {
                ProfessorTurma professorTemp = BuscarPorID(id);

                _ctx.ProfessorTurma.Update(professorTemp);
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
        public ProfessorTurma BuscarPorID(int id)
        {
            try
            {
                return _ctx.ProfessorTurma.Find(id);
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
        public void Cadastrar(ProfessorTurma professorT)
        {
            try
            {
                _ctx.ProfessorTurma.Add(professorT);
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
        public void Excluir(int id)
        {
            try
            {
                ProfessorTurma professorT = BuscarPorID(id);

                if (professorT == null)
                    throw new Exception("Produto não encontrado.");

                _ctx.ProfessorTurma.Remove(professorT);
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
        public List<ProfessorTurma> ListarTodos()
        {
            try
            {
                return _ctx.ProfessorTurma.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

       
    }
    }