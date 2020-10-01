using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduX_Proj.Domains;
using EduX_Proj.Interfaces;
using EduX_Proj.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduX_Proj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstituicaosController : ControllerBase
    {
        private readonly IInstituicao _instituicao;

        public InstituicaosController()
        {
            _instituicao = new InstituicaoRepository();
        }

        /// <summary>
        /// Listar todos as instituicoes
        /// </summary>
        /// <returns> Lista de intituicoes </returns>
        //GET: api/Instituicao
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var instituicoes = _instituicao.ListarTodos();

                if (instituicoes.Count == 0)
                    return NoContent();

                return Ok(instituicoes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Buscar Insituicao pelo seu id
        /// </summary>
        /// <param name="id"> Id da Instituicao </param>
        /// <returns> Instituicao </returns>
        // GET: api/Instituicao/1
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Instituicao instituicao = _instituicao.BuscarPorID(id);

                if (instituicao == null)
                    return NotFound();

                return Ok(instituicao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        /// <summary>
        /// Adicionar uma instituicao
        /// </summary>
        /// <param name="i"> Insituicao </param>
        /// <returns> Status e Insituicao </returns>
        // POST: api/Instituicao/1
        [HttpPost]
        public IActionResult Post(Instituicao i)
        {
            try
            {
                _instituicao.Adicionar(i);

                return Ok(i);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Alterar os atributos de insituicao
        /// </summary>
        /// <param name="id"> Id da instituicao que terá seus atributos alterados </param>
        /// <param name="i"> Instituicao </param>
        /// <returns> Status e Intituicao </returns>
        // PUT: api/Instituicao/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, Instituicao i)
        {
            try
            {
                _instituicao.Alterar(id, i);

                return Ok(i);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Remover intituicao
        /// </summary>
        /// <param name="id"> Id da Instituicao que sera removido </param>
        /// <returns> Status </returns>
        // DELETE: api/Instituicao/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var instituicao = _instituicao.BuscarPorID(id);

                if (instituicao == null)
                    return NotFound();

                _instituicao.Remover(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
