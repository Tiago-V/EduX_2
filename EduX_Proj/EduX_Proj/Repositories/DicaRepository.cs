using EduX_Proj.Contexts;
using EduX_Proj.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_Proj.Repositories
{
    public class DicaRepository
    {

        private readonly EduXContext _ctx;

        public DicaRepository()
        {
            _ctx = new EduXContext();
        }

        /// <summary>
        /// Altera uma dica já criada apartir do seu id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dica"></param>
        public void Alterar(int id, Dica dica)
        {
            try
            {
                Dica dicaTemp = BuscarPorID(id);

                dicaTemp.Curtida = dica.Curtida;
                dicaTemp.Imagem = dica.Imagem;
                dicaTemp.Texto = dica.Texto;

                _ctx.Dica.Update(dicaTemp);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Busca um produto pelo id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna o produto buscado</returns>
        public Dica BuscarPorID(int id)
        {
            try
            {
                return _ctx.Dica.Find(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Cadastra um produto no banco.
        /// </summary>
        /// <param name="dica"></param>
        public void Cadastrar(Dica dica)
        {
            try
            {
                _ctx.Dica.Add(dica);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Exclui um produto do banco.
        /// </summary>
        /// <param name="id"></param>
        public void Excluir(int id)
        {
            try
            {
                Dica dica = BuscarPorID(id);

                if (dica == null)
                    throw new Exception("Produto não encontrado.");

                _ctx.Dica.Remove(dica);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Lista todos os produtos cadastrados.
        /// </summary>
        /// <returns></returns>
        public List<Dica> ListarTodos()
        {
            try
            {
                return _ctx.Dica.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
