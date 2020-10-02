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
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

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

        public void Excluir(int id)
        {
            try
            {
                ProfessorTurma prof = BuscarPorID(id);

                _ctx.ProfessorTurma.Remove(prof);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

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
