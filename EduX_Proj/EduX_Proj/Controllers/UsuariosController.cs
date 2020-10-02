using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduX_Proj.Contexts;
using EduX_Proj.Domains;
using EduX_Proj.Interfaces;
using EduX_Proj.Repositories;
using EduX_Proj.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduX_Proj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private EduXContext _context = new EduXContext();

        private readonly UsuarioRepository _usuario;

        public UsuariosController()
        {
            _usuario = new UsuarioRepository();
        }

        /// <summary>
        /// Listar todos os usuarios
        /// </summary>
        /// <returns> Lista de usuarios </returns>
        //GET: api/Usuario
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var usuarios = _usuario.ListarTodos();

                if (usuarios.Count == 0)
                    return NoContent();

                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Buscar usuario pelo seu id
        /// </summary>
        /// <param name="id"> Id dao usuario </param>
        /// <returns> Usuario </returns>
        // GET: api/Usuario/1
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Usuario usuario = _usuario.BuscarPorID(id);

                if (usuario == null)
                    return NotFound();

                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        /// <summary>
        /// Adicionar um Usuario
        /// </summary>
        /// <param name="u"> Usuario </param>
        /// <returns> Status e Usuario </returns>
        // POST: api/Usuario
        [HttpPost]
        public IActionResult Post(Usuario u)
        {
            try
            {
                // SALT = 3 primeiras letras do email
                u.Senha = Crypto.Criptografar(u.Senha,  u.Email.Substring(0,3));

                _usuario.Adicionar(u);

                return Ok(u);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Alterar os atributos de um usuario
        /// </summary>
        /// <param name="id"> Id do usuario que terá seus atributos alterados </param>
        /// <param name="u"> Usuario </param>
        /// <returns> Status e Usuario </returns>
        // PUT: api/Usuario/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, Usuario u)
        {
            try
            {
                // SALT = 3 primeiras letras do email
                u.Senha = Crypto.Criptografar(u.Senha, u.Email.Substring(0, 3));

                _usuario.Alterar(id, u);

                return Ok(u);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Remover usuario
        /// </summary>
        /// <param name="id"> Id do usuario que sera removido </param>
        /// <returns> Status </returns>
        // DELETE: api/Usuario/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var usuario = _usuario.BuscarPorID(id);

                if (usuario == null)
                    return NotFound();

                _usuario.Remover(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
