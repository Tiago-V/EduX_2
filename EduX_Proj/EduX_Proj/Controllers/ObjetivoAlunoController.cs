using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduX_Proj.Domains;
using EduX_Proj.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduX_Proj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjetivoAlunoController : ControllerBase
    {
        private readonly ObjetivoAlunoRepository _objetivoAlunoRepository;

        public ObjetivoAlunoController()
        {
            _objetivoAlunoRepository = new ObjetivoAlunoRepository();
        }

        /// <summary>
        /// Lista todos os objetivos de um aluno.
        /// </summary>
        /// <returns>Objetivos.</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {

                var objetivoA = _objetivoAlunoRepository.Listar();

                if (objetivoA.Count == 0)
                    return NoContent();

                return Ok(objetivoA);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Busca um objetivo de um aluno a partir do seu id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Objetivo buscado.</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                ObjetivoAluno objetivoA = _objetivoAlunoRepository.BuscarPorID(id);

                if (objetivoA == null)
                    return NotFound();

                return Ok(objetivoA);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Altera um objetivo de um aluno a partir do seu id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objetivoA"></param>
        /// <returns>Objetivo alterado.</returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, ObjetivoAluno objetivoA)
        {
            try
            {

                _objetivoAlunoRepository.Alterar(id, objetivoA);


                return Ok(objetivoA);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Cadastra um objetivo de um aluno no banco de dados.
        /// </summary>
        /// <param name="objetivoA"></param>
        /// <returns>Objetivo cadastrado</returns>
        [HttpPost]
        public IActionResult Post([FromForm] ObjetivoAluno objetivoA)
        {
            try
            {
                _objetivoAlunoRepository.Adicionar(objetivoA);


                return Ok(objetivoA);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Excluí um objetivo de um aluno já cadastrado no banco a partir do seu id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Objetivo excluído</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {

                var dica = _objetivoAlunoRepository.BuscarPorID(id);


                if (dica == null)
                    return NotFound();


                _objetivoAlunoRepository.Excluir(id);

                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
