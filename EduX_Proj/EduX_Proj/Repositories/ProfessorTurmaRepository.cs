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

<<<<<<< HEAD
        public void Adicionar(ProfessorTurma ProfessorT)
        {
            _ctx.ProfessorTurma.Add(ProfessorT);
            _ctx.SaveChanges();
        }

        public void Alterar(int id, ProfessorTurma ProfessorT)
        {
            try
            {
                ProfessorTurma prof = BuscarPorID(id);

                prof.Descricao = ProfessorT.Descricao;

                _ctx.ProfessorTurma.Update(prof);
                _ctx.SaveChanges();
=======

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
>>>>>>> 213c00a4013a247c38589b09c467e6577a44f4c4
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

<<<<<<< HEAD
        public ProfessorTurma BuscarPorID(int id)
        {
            try
            {
                return _ctx.ProfessorTurma.Find(id);
=======
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
>>>>>>> 213c00a4013a247c38589b09c467e6577a44f4c4
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

<<<<<<< HEAD
=======
        /// <summary>
        /// Exclui uma curtida do banco.
        /// </summary>
        /// <param name="id"></param>
>>>>>>> 213c00a4013a247c38589b09c467e6577a44f4c4
        public void Excluir(int id)
        {
            try
            {
<<<<<<< HEAD
                ProfessorTurma prof = BuscarPorID(id);

                _ctx.ProfessorTurma.Remove(prof);
=======
                ProfessorTurma professorT = BuscarPorID(id);

                if (professorT == null)
                    throw new Exception("Produto não encontrado.");

                _ctx.ProfessorTurma.Remove(professorT);
>>>>>>> 213c00a4013a247c38589b09c467e6577a44f4c4
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

<<<<<<< HEAD
=======
        /// <summary>
        /// Listar todas as curtidas cadastradas.
        /// </summary>
        /// <returns></returns>
>>>>>>> 213c00a4013a247c38589b09c467e6577a44f4c4
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

<<<<<<< HEAD
}
=======
       
    }
    }
>>>>>>> 213c00a4013a247c38589b09c467e6577a44f4c4
