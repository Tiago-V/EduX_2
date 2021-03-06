using EduX_Proj.Contexts;
using EduX_Proj.Domains;
using EduX_Proj.Interface;
using EduX_Proj.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Repositories
{
    public class PerfilRepository : IPerfil
    {
        private readonly EduXContext _ctx;

        public PerfilRepository()
        {
            _ctx = new EduXContext();
        }

        /// <summary>
        /// Adiciona um tipo perfil
        /// </summary>
        /// <param name="perfil">Perfil para ser adicionado</param>
        public void Adicionar(Perfil perfil)
        {
            try
            {
                _ctx.Perfil.Add(perfil);

                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Busca um tipo perfil por ID
        /// </summary>
        /// <param name="id">ID para pesquisa</param>
        /// <returns>Perfil pesquisado</returns>
        public Perfil BuscarPorID(int id)
        {
            try
            {
                return _ctx.Perfil.Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); ;
            }
        }

        /// <summary>
        /// Edita um tipo de perfil
        /// </summary>
        /// <param name="perfil">Perfil a ser editado</param>
        public void Alterar(int id, Perfil perfil)
        {
            try
            {
                Perfil p = BuscarPorID(id);

                p.Permissao = perfil.Permissao;

                _ctx.Perfil.Update(p);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Exclui um perfil
        /// </summary>
        /// <param name="id">ID do perfil</param>
        public void Excluir(int id)
        {
            try
            {
                Perfil perfil = BuscarPorID(id);

                if (perfil == null)
                    throw new Exception("Tipo de Perfil n�o encontrado.");

                _ctx.Perfil.Remove(perfil);

                _ctx.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); ;
            }
        }

        /// <summary>
        /// Lista todos os perf�s
        /// </summary>
        /// <returns>Lista dos perf�s</returns>
        public List<Perfil> ListarTodos()
        {
            try
            {
                List<Perfil> perfis = _ctx.Perfil.ToList();
                return perfis;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); ;
            }
        }
    }
}