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
    public class ObjetivoController : ControllerBase
    {
        private readonly ObjetivoRepository _objetivoRepository;

        public ObjetivoController()
        {
            _objetivoRepository = new ObjetivoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {

                var objetivo = _objetivoRepository.Listar();

                if (objetivo.Count == 0)
                    return NoContent();

                return Ok(objetivo);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Objetivo objetivo = _objetivoRepository.BuscarPorID(id);

                if (objetivo == null)
                    return NotFound();

                return Ok(objetivo);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, Objetivo objetivo)
        {
            try
            {

                _objetivoRepository.Alterar(id, objetivo);


                return Ok(objetivo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromForm] Objetivo objetivo)
        {
            try
            {
                _objetivoRepository.Adicionar(objetivo);


                return Ok(objetivo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {

                var dica = _objetivoRepository.BuscarPorID(id);


                if (dica == null)
                    return NotFound();


                _objetivoRepository.Excluir(id);

                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
