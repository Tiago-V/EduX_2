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
