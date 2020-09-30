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
    public class TurmasController : ControllerBase
    {
        private readonly ITurma _turma;

        public TurmasController()
        {
            _turma = new TurmaRepository();
        }

        /// <summary>
        /// Listar todas as turmas
        /// </summary>
        /// <returns> Lista de turmas </returns>
        //GET: api/Turma
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var turmas = _turma.ListarTodos();

                if (turmas.Count == 0)
                    return NoContent();

                return Ok(turmas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Buscar turma pelo seu id
        /// </summary>
        /// <param name="id"> Id da turma </param>
        /// <returns> Turma </returns>
        // GET: api/Turma/1
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Turma turma = _turma.BuscarPorID(id);

                if (turma == null)
                    return NotFound();

                return Ok(turma);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        /// <summary>
        /// Adicionar uma Turma
        /// </summary>
        /// <param name="t"> Turma </param>
        /// <returns> Status e Turma </returns>
        // POST: api/Turma/1
        [HttpGet]
        public IActionResult Post(Turma t)
        {
            try
            {
                _turma.Adicionar(t);

                return Ok(t);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Alterar os atributos da Turma
        /// </summary>
        /// <param name="id"> Id da turma que terá seus atributos alterados </param>
        /// <param name="t"> Turma </param>
        /// <returns> Status e Turma </returns>
        // PUT: api/Turma/1
        [HttpGet("{id}")]
        public IActionResult Put(int id, Turma t)
        {
            try
            {
                _turma.Alterar(id, t);

                return Ok(t);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Remover turma
        /// </summary>
        /// <param name="id"> Id da turma que sera removido </param>
        /// <returns> Status </returns>
        // DELETE: api/Turma/1
        [HttpGet("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var turma = _turma.BuscarPorID(id);

                if (turma == null)
                    return NotFound();

                _turma.Remover(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
