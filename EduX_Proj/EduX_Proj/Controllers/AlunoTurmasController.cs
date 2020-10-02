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
    public class AlunoTurmasController : ControllerBase
    {
        private readonly IAlunoTurma _alunoTurma;

        public AlunoTurmasController()
        {
            _alunoTurma = new AlunoTurmaRepository();
        }

        /// <summary>
        /// Listar todos os alunos
        /// </summary>
        /// <returns> Lista de alunos </returns>
        //GET: api/AlunoTurma
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var alunos = _alunoTurma.ListarTodos();

                if (alunos.Count == 0)
                    return NoContent();

                return Ok(alunos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Buscar aluno pelo seu id
        /// </summary>
        /// <param name="id"> Id do Aluno </param>
        /// <returns> Aluno </returns>
        // GET: api/AlunoTurma/1
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                AlunoTurma aluno = _alunoTurma.BuscarPorID(id);

                if (aluno == null)
                    return NotFound();

                return Ok(aluno);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        /// <summary>
        /// Adicionar um aluno
        /// </summary>
        /// <param name="a"> Aluno </param>
        /// <returns> Status Ok e Aluno </returns>
        // POST: api/AlunoTurma
        [HttpPost]
        public IActionResult Post(AlunoTurma a)
        {
            try
            {
                _alunoTurma.Adicionar(a);

                return Ok(a);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Alterar os atributos de aluno
        /// </summary>
        /// <param name="id"> Id do aluno que terá seus atributos alterados </param>
        /// <param name="a"> Aluno </param>
        /// <returns> Status Ok e Aluno </returns>
        // PUT: api/AlunoTurma/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, AlunoTurma a)
        {
            try
            {
                _alunoTurma.Alterar(id, a);

                return Ok(a);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Remover aluno
        /// </summary>
        /// <param name="id"> Id do Aluno que sera removido </param>
        /// <returns> Status Ok </returns>
        // DELETE: api/AlunoTurma/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var aluno = _alunoTurma.BuscarPorID(id);

                if (aluno == null)
                    return NotFound();

                _alunoTurma.Remover(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
