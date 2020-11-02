using EduX_Proj.Contexts;
using EduX_Proj.Domains;
using EduX_Proj.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Repositories
{
    public class UsuarioRepository : IUsuario
    {
        private readonly EduXContext _ctx;

        public UsuarioRepository()
        {
            _ctx = new EduXContext();
        }

        /// <summary>
        /// Adiciona um novo usuário no banco.
        /// </summary>
        /// <param name="u"></param>
        public void Adicionar(Usuario u)
        {
            _ctx.Usuario.Add(u);
            _ctx.SaveChanges();
        }

        /// <summary>
        /// Altera um usuário já cadastrado no banco.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="u"></param>
        public void Alterar(int id, Usuario u)
        {
            try
            {
                Usuario usuario = BuscarPorID(id);

                usuario.Nome             = u.Nome;
                usuario.Email            = u.Email;
                usuario.Senha            = u.Senha;


                _ctx.Usuario.Update(usuario);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Busca um usuário já cadastrado no banco a partir do seu id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Usuário buscado.</returns>
        public Usuario BuscarPorID(int id)
        {
            try
            {
                return _ctx.Usuario.Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Lista todos os usuários cadastrados no banco.
        /// </summary>
        /// <returns>Usuários cadastrados</returns>
        public List<Usuario> ListarTodos()
        {
            try
            {
                return _ctx.Usuario.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Remove um usuário a partir do seu id.
        /// </summary>
        /// <param name="id"></param>
        public void Remover(int id)
        {
            try
            {
                Usuario usuario = BuscarPorID(id);

                _ctx.Usuario.Remove(usuario);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
