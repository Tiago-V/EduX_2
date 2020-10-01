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
        public void Adicionar(Curso curso)
        {
            _ctx.Curso.Add(curso);
            _ctx.SaveChanges();
        }

        public void Alterar(Guid id, Curso curso)
        {
            try
            {
                Curso cso = BuscarPorId(id);
                cso.Titulo = curso.Titulo;

                _ctx.Curso.Update(curso);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Curso BuscarPorId(Guid id)
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

        public void Remover(Guid id)
        {
            try
            {
                Curso cso = BuscarPorId(id);
                _ctx.Curso.Remove(cso);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
