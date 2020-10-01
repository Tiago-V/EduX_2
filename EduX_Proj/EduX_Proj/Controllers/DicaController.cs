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
using System.IO;
using EduX_Proj.Utils;

namespace EduX_Proj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DicaController : ControllerBase
    {
        private readonly DicaRepository _dicaRepository;

        public DicaController()
        {
            _dicaRepository = new DicaRepository();
        }

        /// <summary>
        /// Método que lista todas as dicas - controller
        /// </summary>
        /// <returns>Dicas</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {

                var dicas = _dicaRepository.ListarTodos();

                if (dicas.Count == 0)
                    return NoContent();

                return Ok(dicas);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Método que busca uma dica a partir do seu id - controller
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Dica buscada</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Dica dica = _dicaRepository.BuscarPorID(id);

                if (dica == null)
                    return NotFound();

                return Ok(dica);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Método que altera uma dica já cadastrada - controller
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dica"></param>
        /// <returns>Dica alterada</returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, Dica dica)
        {
            try
            {
                //Edita a instituicao
                _dicaRepository.Alterar(id, dica);

                //Retorna Ok com os dados da instituicao
                return Ok(dica);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Método que cadastra uma nova dica no banco - controller
        /// </summary>
        /// <param name="dica"></param>
        /// <returns>Dica cadastrada</returns>
        [HttpPost]
        public IActionResult Post([FromForm]Dica dica)
        {
            try
            {

                if(dica.Imagem != null)
                {
                    var urlImagem = Upload.Local(dica.Imagem);

                    dica.UrlImagem = urlImagem;
                }

                _dicaRepository.Cadastrar(dica);


                return Ok(dica);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Remove uma dica já cadastrada no banco - controller
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Dica excluída</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {

                var dica = _dicaRepository.BuscarPorID(id);


                if (dica == null)
                    return NotFound();


                _dicaRepository.Excluir(id);

                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
