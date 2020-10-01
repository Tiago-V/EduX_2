using Amazon.DynamoDBv2.Model;
using EduX_Proj.Domains;
using EduX_Proj.Interfaces;
using EduX_Proj.Repositories;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly ICurso _curso;

        public CursoController()
        {
            _curso = new CursoRepository();
        }

        /// <summary>
        /// Lista dos Cursos
        /// </summary>
        /// <returns>Lista os Cursos</returns>

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var cursos = _curso.ListarTodos();

                if (cursos.Count == 0)
                    return NoContent();
                return Ok(cursos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Busca um Curso por seu ID
        /// </summary>
        /// <param name="id">Id Curso</param>
        /// <returns>Curso</returns>

        [HttpGet]
        public IActionResult Get(int id)
        {
            try
            {
                Curso curso = (Curso)_curso.BuscarPorId(id);
                if (curso == null)
                    return NotFound();
                return Ok(curso);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Adiciona um Curso
        /// </summary>
        /// <param name="curso">Curso</param>
        /// <returns>Status: Ok</returns>

        [HttpPost]
        public IActionResult Post(Curso curso)
        {
            try
            {
                _curso.Adicionar(curso);

                return Ok(curso);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Altera elementos do Curso
        /// </summary>
        /// <param name="id">Id do Curso que será alterado</param>
        /// <param name="curso">Curso</param>
        /// <returns>Status: Ok</returns>

        [HttpPut("{id}")]
        public IActionResult Put(int id, Curso curso)
        {
            try
            {
                _curso.Alterar(id, curso);

                return Ok(curso);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Remove um Curso
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status: Ok</returns>

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var curso = _curso.BuscarPorId(id);

                if (curso == null)
                    return NotFound();
                _curso.Remover(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
