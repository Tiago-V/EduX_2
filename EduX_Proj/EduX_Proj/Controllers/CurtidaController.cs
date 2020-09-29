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

        // GET: api/Dica
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

        // GET: api/Dica/5
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

        // PUT: api/Dica/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
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

        // POST: api/Dica
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
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

        // DELETE: api/Dica/5
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
