using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduX_Proj.Domains;
using EduX_Proj.Interface;
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
<<<<<<< HEAD
        private readonly IProfessorTurma _professorTRepository;
=======
        private readonly ProfessorTurmaRepository professorTRepository;
>>>>>>> 213c00a4013a247c38589b09c467e6577a44f4c4

        public ProfessorTurmaContoller()
        {
            _professorTRepository = new ProfessorTurmaRepository();
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
<<<<<<< HEAD
                var prof = _professorTRepository.ListarTodos();
=======
                var prof = professorTRepository.ListarTodos();
>>>>>>> 213c00a4013a247c38589b09c467e6577a44f4c4

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
<<<<<<< HEAD
                ProfessorTurma prof = _professorTRepository.BuscarPorID(id);
=======
                ProfessorTurma prof = professorTRepository.BuscarPorID(id);
>>>>>>> 213c00a4013a247c38589b09c467e6577a44f4c4

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
<<<<<<< HEAD
                _professorTRepository.Adicionar(professorT);
=======
                professorTRepository.Cadastrar(professorT);
>>>>>>> 213c00a4013a247c38589b09c467e6577a44f4c4

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
<<<<<<< HEAD
                _professorTRepository.Alterar(id, professorT);
=======
                professorTRepository.Alterar(id, professorT);
>>>>>>> 213c00a4013a247c38589b09c467e6577a44f4c4

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
<<<<<<< HEAD
                var prof = _professorTRepository.BuscarPorID(id);
=======
                var prof = professorTRepository.BuscarPorID(id);
>>>>>>> 213c00a4013a247c38589b09c467e6577a44f4c4

                //verifica se professor existe
                //caso não exista retorna NotFound
                if (prof == null)
                    return NotFound();

                //caso exista remove o professor
<<<<<<< HEAD
                _professorTRepository.Excluir(id);
=======
                professorTRepository.Excluir(id);
>>>>>>> 213c00a4013a247c38589b09c467e6577a44f4c4
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