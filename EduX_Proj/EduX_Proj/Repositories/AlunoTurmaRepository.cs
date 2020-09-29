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

        public void Adicionar(AlunoTurma a)
        {
            _ctx.AlunoTurma.Add(a);
            _ctx.SaveChanges();
        }

        public void Alterar(Guid id, AlunoTurma a)
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

        public AlunoTurma BuscarPorID(Guid id)
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

        public void Remover(Guid id)
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
