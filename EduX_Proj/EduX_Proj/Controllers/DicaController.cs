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

        // GET: api/Dica
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

        // GET: api/Dica/5
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

        // PUT: api/Dica/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
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

        // POST: api/Dica
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
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

        // DELETE: api/Dica/5
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
