using System;
using EduX_Proj.Domains;
using EduX_Proj.Interfaces;
using EduX_Proj.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace EduX_Proj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoria _categoria;

        public CategoriaController()
        {
            _categoria = new CategoriaRepository();
        }

        /// <summary>
        /// Lista das Categorias
        /// </summary>
        /// <returns>Lista as Categorias</returns>
        // GET api/Categoria
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var categorias = _categoria.ListarTodos();

                if (categorias.Count == 0)
                    return NoContent();

                return Ok(categorias);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Busca uma Categoria por seu ID
        /// </summary>
        /// <param name="id">Id Categoria</param>
        /// <returns>Categoria</returns>

        // GET api/Categoria/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Categoria categoria = _categoria.BuscarPorId(id);

                if (categoria == null)
                    return NotFound();

                return Ok(categoria);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Adiciona uma categoria
        /// </summary>
        /// <param name="cat">Categoria</param>
        /// <returns>Status: Ok</returns>

        // POST api/Categoria
        [HttpPost]
        public IActionResult Post(Categoria cat)
        {
            try
            {
                _categoria.Cadastrar(cat);

                return Ok(cat);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Altera elementos de Categoria
        /// </summary>
        /// <param name="id">Id da Categoria que será alterada</param>
        /// <param name="cat">Categoria</param>
        /// <returns>Status: Ok</returns>

        // PUT api/Categoria/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Categoria cat)
        {
            try
            {
                _categoria.Alterar(id, cat);

                return Ok(cat);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Remove uma Categoria
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status: Ok</returns>

        // DELETE api/Categoria/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var categoria = _categoria.BuscarPorId(id);

                if (categoria == null)
                    return NotFound();
                _categoria.Excluir(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
