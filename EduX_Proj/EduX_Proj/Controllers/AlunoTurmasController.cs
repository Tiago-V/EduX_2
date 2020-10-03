using System;
using EduX_Proj.Domains;
using EduX_Proj.Interfaces;
using EduX_Proj.Repositories;
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

        //GET: api/AlunoTurma
        /// <summary>
        /// Listar todos os alunos
        /// </summary>
        /// <returns> Lista de alunos </returns>
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

        // GET: api/AlunoTurma/1
        /// <summary>
        /// Buscar aluno pelo seu id
        /// </summary>
        /// <param name="id"> Id do Aluno </param>
        /// <returns> Aluno </returns>
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


        // POST: api/AlunoTurma
        /// <summary>
        /// Adicionar um aluno
        /// </summary>
        /// <param name="a"> Aluno </param>
        /// <returns> Status Ok e Aluno </returns>
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

        // PUT: api/AlunoTurma/1
        /// <summary>
        /// Alterar os atributos de aluno
        /// </summary>
        /// <param name="id"> Id do aluno que terá seus atributos alterados </param>
        /// <param name="a"> Aluno </param>
        /// <returns> Status Ok e Aluno </returns>
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

        // DELETE: api/AlunoTurma/1
        /// <summary>
        /// Remover aluno
        /// </summary>
        /// <param name="id"> Id do Aluno que sera removido </param>
        /// <returns> Status Ok </returns>
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
