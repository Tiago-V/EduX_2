using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EduX_Proj.Utils;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EduX_Proj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {

        /// <summary>
        /// Método que cadastra uma nova imagem no banco - controller
        /// </summary>
        /// <param name="arquivo"></param>
        /// <returns>Imagem cadastrada</returns>
        [HttpPost]
        public IActionResult Post([FromForm] IFormFile arquivo)
        {

            try
            {

                if (arquivo != null)
                {
                    var urlImagem = Upload.Local(arquivo);

                    return Ok(new { url = urlImagem });
                }

                return BadRequest(new
                {
                    mensagem = "Arquivo nao informado"
                });

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
