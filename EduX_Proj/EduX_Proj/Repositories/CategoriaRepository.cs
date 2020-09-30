using EduX_Proj.Contexts;
using EduX_Proj.Domains;
using EduX_Proj.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Repositories
{
    public class CategoriaRepository : ICategoria
    {
        private readonly EduXContext _ctx;

        public CategoriaRepository()
        {
            _ctx = new EduXContext();
        }
        public void Adicionar(Categoria cat)
        {
            _ctx.Categoria.Add(cat);
            _ctx.SaveChanges();
        }

        public void Alterar(Guid id, Categoria cat)
        {
            try
            {
                Categoria categoria = BuscarPorId(id);
                categoria.Tipo = cat.Tipo;

                _ctx.Categoria.Update(cat);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Categoria BuscarPorId(Guid id)
        {
            try
            {
                return _ctx.Categoria.Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Categoria> ListarTodos()
        {
            try
            {
                return _ctx.Categoria.ToList();
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
                Categoria categoria = BuscarPorId(id);
                _ctx.Categoria.Remove(categoria);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
