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
    public class ProfessorTurmaContoller : ControllerBase
    {
        private readonly IProfessorTurmaRepository professorTRepository;

        public ProfessorTurmaContoller()
        {
            professorTRepository = new ProfessorTurmaRepository();
        }



        /// <summary>
        /// Mostra todos os professores cadastrados
        /// </summary>
        /// <returns>Lista com todos os professores</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                //lista de professores
                var prof = professorTRepository.Listar();

                //verifica se existe no conxtexto atual
                //caso nao exista ele retorna NoContext
                if (prof.Count == 0)
                    return NoContent();

                //caso exista retorno Ok e o total de professores cadastradss
                return Ok(new
                {
                    totalCount = prof.Count,
                    data = prof
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        // GET api/<ProfessorTurmaController>/5
        /// <summary>
        /// Mostra um �nico professor
        /// </summary>
        /// <param name="id">ID do professor</param>
        /// <returns>Um professor</returns>
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            try
            {
                //busca um professor por id
                ProfessorTurma prof = professorTRepository.BuscarPorId(id);

                //faz a verificacao no contexto para ver se o professor foi encontrado
                //caso nao for encontrado o sistema retornara NotFound 
                if (prof == null)
                    return NotFound();

                //se existir retorno vai passar o Ok e os dados do professor
                return Ok(prof);
            }
            catch (Exception ex)
            {
                //caso ocorra algum erro retorno BadRequest e a mensagem da exception
                return BadRequest(ex.Message);
            }
        }




        // POST api/<ProfessorTurmaController>
        /// <summary>
        /// Cadastra um novo professor
        /// </summary>
        /// <param name="professorT">Objeto completo de professor</param>
        /// <returns>Professor cadastrado</returns>
        [HttpPost]
        public IActionResult Post([FromForm] ProfessorTurma professorT)
        {
            try
            {
                //adiciona um novo professor
                professorTRepository.Adicionar(professorT);

                //retorna Ok se o professor tiver sido cadastrado
                return Ok(professorT);
            }
            catch (Exception ex)
            {
                //caso ocorra algum erro retorno BadRequest e a mensagem da exception
                return BadRequest(ex.Message);
            }
        }






        // PUT api/<ProfessorTurmaController>/5
        /// <summary>
        /// Altera determinado professor
        /// </summary>
        /// <param name="id">ID de professor</param>
        /// <param name="profesorT">Objeto professor com as altera��es</param>
        /// <returns>Info do professor alterado</returns>
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, ProfessorTurma professorT)
        {
            try
            {
                //edita professor
                professorTRepository.Editar(professorT);

                //retorna o Ok com os dados do professor
                return Ok(professorT);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }




        // DELETE api/<ProfessorTurmaController>/5
        /// <summary>
        /// Exclui um professor
        /// </summary>
        /// <param name="id">ID do professor</param>
        /// <returns>ID exclu�do</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                //busca professor pelo Id
                var prof = professorTRepository.BuscarPorId(id);

                //verifica se professor existe
                //caso n�o exista retorna NotFound
                if (prof == null)
                    return NotFound();

                //caso exista remove o professor
                professorTRepository.Remover(id);
                //retorna Ok
                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}