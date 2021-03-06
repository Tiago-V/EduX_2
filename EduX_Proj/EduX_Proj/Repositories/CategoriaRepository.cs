﻿using EduX_Proj.Contexts;
using EduX_Proj.Domains;
using EduX_Proj.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EduX_Proj.Repositories
{
    public class CategoriaRepository : ICategoria
    {
        private readonly EduXContext _ctx;

        public CategoriaRepository()
        {
            _ctx = new EduXContext();
        }

        /// <summary>
        /// Cadastra uma nova Categoria.
        /// </summary>
        /// <param name="cat"></param>
        public void Cadastrar(Categoria cat)
        {
            _ctx.Categoria.Add(cat);
            _ctx.SaveChanges();
        }

        /// <summary>
        /// Altera uma categoria já criada no banco a partir do seu id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cat"></param>
        public void Alterar(int id, Categoria cat)
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

        /// <summary>
        /// Busca uma categoria a partir do seu id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Categoria buscada.</returns>
        public Categoria BuscarPorId(int id)
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

        /// <summary>
        /// Lista todas as categorias já cadastradas no banco.
        /// </summary>
        /// <returns>Todas as categorias cadastradas</returns>
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

        /// <summary>
        /// Remove uma categoria do banco a partir do seu id
        /// </summary>
        /// <param name="id"></param>
        public void Excluir(int id)
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
