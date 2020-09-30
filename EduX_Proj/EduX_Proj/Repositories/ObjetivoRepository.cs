using EduX_Proj.Contexts;
using EduX_Proj.Domains;
using EduX_Proj.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Repositories
{
    public class ObjetivoRepository : IObjetivo
    {

        private readonly EduXContext ctx;

        /// <summary>
        /// Cadastra um novo objetivo no banco.
        /// </summary>
        /// <param name="objetivo"></param>
        public void Adicionar(Objetivo objetivo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Altera um objetivo já cadastrado no banco.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objetivo"></param>
        public void Alterar(int id, Objetivo objetivo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Busca um objetivo cadastrado no banco a partir do seu id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Objetivo buscado</returns>
        public Objetivo BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Exclui um objetivo já cadastrado no banco.
        /// </summary>
        /// <param name="id"></param>
        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lista todos os objetvos já cadastrados no banco.
        /// </summary>
        /// <returns>Objetivos cadastrados</returns>
        public List<Objetivo> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
