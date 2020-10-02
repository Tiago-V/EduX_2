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
        private readonly ProfessorTurmaRepository professorTRepository;

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
                var prof = professorTRepository.ListarTodos();

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
        /// Mostra um único professor
        /// </summary>
        /// <param name="id">ID do professor</param>
        /// <returns>Um professor</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                //busca um professor por id
                ProfessorTurma prof = professorTRepository.BuscarPorID(id);

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
                professorTRepository.Cadastrar(professorT);

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
        /// <param name="profesorT">Objeto professor com as alterações</param>
        /// <returns>Info do professor alterado</returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, ProfessorTurma professorT)
        {
            try
            {
                //edita professor
                professorTRepository.Alterar(id, professorT);

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
        /// <returns>ID excluído</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                //busca professor pelo Id
                var prof = professorTRepository.BuscarPorID(id);

                //verifica se professor existe
                //caso não exista retorna NotFound
                if (prof == null)
                    return NotFound();

                //caso exista remove o professor
                professorTRepository.Excluir(id);
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