using EduX_Proj.Contexts;
using EduX_Proj.Domains;
using EduX_Proj.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Repositories
{
    public class AlunoTurmaRepository : IAlunoTurma
    {
        private readonly EduXContext _ctx;

        public AlunoTurmaRepository()
        {
            _ctx = new EduXContext();
        }

        /// <summary>
        /// Adiciona um AlunoTurma.
        /// </summary>
        /// <param name="a"></param>
        public void Adicionar(AlunoTurma a)
        {
            _ctx.AlunoTurma.Add(a);
            _ctx.SaveChanges();
        }

        /// <summary>
        /// Altera um AlunoTurma a partir do seu id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="a"></param>
        public void Alterar(int id, AlunoTurma a)
        {
            try
            {
                AlunoTurma aluno = BuscarPorID(id);

                aluno.Matricula = a.Matricula;

                _ctx.AlunoTurma.Update(aluno);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
         
        }

        /// <summary>
        /// Busca um AlunoTurma por seu id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public AlunoTurma BuscarPorID(int id)
        {
            try
            {
                return _ctx.AlunoTurma.Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Lista todos os AlunoTurmas cadastrados no banco.
        /// </summary>
        /// <returns>AlunoTurmas Cadastrados</returns>
        public List<AlunoTurma> ListarTodos()
        {
            try
            {
                return _ctx.AlunoTurma.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Remove um aluno a partir do seu id.
        /// </summary>
        /// <param name="id"></param>
        public void Remover(int id)
        {
            try
            {
                AlunoTurma aluno = BuscarPorID(id);

                _ctx.AlunoTurma.Remove(aluno);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
