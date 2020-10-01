using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EduX_Proj.Contexts;
using EduX_Proj.Domains;
using EduX_Proj.Repositories;

namespace EduX_Proj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurtidaController : ControllerBase
    {
        private readonly CurtidaRepository _curtidaRepository;

        public CurtidaController()
        {
            _curtidaRepository = new CurtidaRepository();
        }

        /// <summary>
        /// Método que lista todas as curtidas - controller
        /// </summary>
        /// <returns>Curtidas</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {

                var curtidas = _curtidaRepository.ListarTodos();

                if (curtidas.Count == 0)
                    return NoContent();

                return Ok(curtidas);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Método que busca uma curtida a partir do seu id - controller
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Curtida buscada</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Curtida curtida = _curtidaRepository.BuscarPorID(id);

                if (curtida == null)
                    return NotFound();

                return Ok(curtida);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


        /// <summary>
        /// Método que altera uma curtida já cadastrada - controller
        /// </summary>
        /// <param name="id"></param>
        /// <param name="curtida"></param>
        /// <returns>Curtida alterada</returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, Curtida curtida)
        {
            try
            {
                //Edita a instituicao
                _curtidaRepository.Alterar(id, curtida);

                //Retorna Ok com os dados da instituicao
                return Ok(curtida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Método que cadastra uma nova curtida no banco - controller
        /// </summary>
        /// <param name="curtida"></param>
        /// <returns>Curtida cadastrada</returns>
        [HttpPost]
        public IActionResult Post(Curtida curtida)
        {
            try
            {
                _curtidaRepository.Cadastrar(curtida);


                return Ok(curtida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Remove uma curtida já cadastrada no banco - controller
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Curtida excluída</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {

                var curtida = _curtidaRepository.BuscarPorID(id);


                if (curtida == null)
                    return NotFound();


                _curtidaRepository.Excluir(id);

                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
