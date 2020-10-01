using EduX_Proj.Contexts;
using EduX_Proj.Domains;
using EduX_Proj.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Repositories
{
    public class InstituicaoRepository : IInstituicao
    {
        private readonly EduXContext _ctx;

        public InstituicaoRepository()
        {
            _ctx = new EduXContext();
        }

        /// <summary>
        /// Adiciona uma nova instituição
        /// </summary>
        /// <param name="i"></param>
        public void Adicionar(Instituicao i)
        {
            _ctx.Instituicao.Add(i);
            _ctx.SaveChanges();
        }

        /// <summary>
        /// Altera uma instituição já cadastrada no banco a partir do seu id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="i"></param>
        public void Alterar(int id, Instituicao i)
        {
            try
            {
                Instituicao instituicao = BuscarPorID(id);

                instituicao.Nome        = i.Nome;
                instituicao.Logradouro  = i.Logradouro;
                instituicao.Numero      = i.Numero;
                instituicao.Complemento = i.Complemento;
                instituicao.Bairro      = i.Bairro;
                instituicao.Cidade      = i.Cidade;
                instituicao.Uf          = i.Uf;
                instituicao.Cep         = i.Cep;

                _ctx.Instituicao.Update(instituicao);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Busca uma instituição já cadastrada no banco a partir do seu id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Instituição buscada.</returns>
        public Instituicao BuscarPorID(int id)
        {
            try
            {
                return _ctx.Instituicao.Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Busca todas as instituições cadastradas no banco.
        /// </summary>
        /// <returns>Todas as instituições</returns>
        public List<Instituicao> ListarTodos()
        {
            try
            {
                return _ctx.Instituicao.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Remove uma instituição a partir do seu id.
        /// </summary>
        /// <param name="id"></param>
        public void Remover(int id)
        {
            try
            {
                Instituicao instituicao = BuscarPorID(id);

                _ctx.Instituicao.Remove(instituicao);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
