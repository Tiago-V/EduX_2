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

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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

        // GET api/<CategoriaController>/5
        [HttpGet]
        public IActionResult Get(int id)
        {
            try
            {
                Categoria categoria = _categoria.BuscarPorID(id);
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

        // POST api/<CategoriaController>
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

        // PUT api/<CategoriaController>/5
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

        // DELETE api/<CategoriaController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var categoria = _categoria.BuscarPorID(id);

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