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

        private readonly EduXContext _ctx;

        public ObjetivoRepository()
        {
            _ctx = new EduXContext();
        }

        /// <summary>
        /// Adiciona um objetivo
        /// </summary>
        /// <param name="objetivo">Objeto a ser adicionado</param>
        public void Adicionar(Objetivo objetivo)
        {
            try
            {
                _ctx.Objetivo.Add(objetivo);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Altera um objetivo ja instanciado
        /// </summary>
        /// <param name="id">Id do objetivo</param>
        /// <param name="objetivo">O objetivo</param>
        public void Alterar(int id, Objetivo objetivo)
        {
            try
            {
                Objetivo objetivoTemp = BuscarPorID(id);

                objetivoTemp.Descricao = objetivo.Descricao;
                objetivoTemp.ObjetivoAluno = objetivo.ObjetivoAluno;

                _ctx.Objetivo.Update(objetivoTemp);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Busca um objetivo pelo id na lista
        /// </summary>
        /// <param name="id">id do objetivo</param>
        /// <returns>Retorna o objetivo caso exista</returns>
        public Objetivo BuscarPorID(int id)
        {
            try
            {
                return _ctx.Objetivo.Find(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Remove um objetivo da lista
        /// </summary>
        /// <param name="id">id do objetivo a ser removido</param>
        public void Excluir(int id)
        {
            try
            {
                Objetivo objetivo = BuscarPorID(id);

                if (objetivo == null)
                    throw new Exception("Produto não encontrado.");

                _ctx.Objetivo.Remove(objetivo);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Lista os objetivo intanciados
        /// </summary>
        /// <returns>Retorna a lista de objetivo</returns>
        public List<Objetivo> Listar()
        {
            try
            {
                return _ctx.Objetivo.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
