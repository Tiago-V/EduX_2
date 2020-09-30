using EduX_Proj.Contexts;
using EduX_Proj.Domains;
using EduX_Proj.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Repositories
{
    public class TurmaRepository : ITurma
    {
        private readonly EduXContext _ctx;

        public TurmaRepository()
        {
            _ctx = new EduXContext();
        }

        /// <summary>
        /// Adiciona uma turma no banco.
        /// </summary>
        /// <param name="t"></param>
        public void Adicionar(Turma t)
        {
            _ctx.Turma.Add(t);
            _ctx.SaveChanges();
        }

        /// <summary>
        /// Altera uma turma já cadastrada no banco.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="t"></param>
        public void Alterar(int id, Turma t)
        {
            try
            {
                Turma turma = BuscarPorID(id);

                turma.Descricao = t.Descricao;

                _ctx.Turma.Update(turma);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Busca uma turma já cadastrada no banco de acordo com seu id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Turma buscada</returns>
        public Turma BuscarPorID(int id)
        {
            try
            {
                return _ctx.Turma.Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Lista todas as turmas cadastradas no banco.
        /// </summary>
        /// <returns>Turmas cadastradas</returns>
        public List<Turma> ListarTodos()
        {
            try
            {
                return _ctx.Turma.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Remove uma turma já cadastrada no banco a partir do seu id
        /// </summary>
        /// <param name="id"></param>
        public void Remover(int id)
        {
            try
            {
                Turma turma = BuscarPorID(id);

                _ctx.Turma.Remove(turma);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
