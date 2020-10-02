using System;
using System.Collections.Generic;
using System.Linq;

namespace EduX_Proj.Repositories
{
    public class ProfessorTurmaRepository : IProfessorTurma
    {

        private readonly EduxContext ctx;
        public ProfessorTurmaRepository()
        {
            ctx = new EduxContext();
        }

        //adicionar o professor 
        public void Adicionar(ProfessorTurma ProfessorT)
        {
            try
            {
                ctx.ProfessorTurma.add(ProfessorT);
                //salvar as alterações
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //buscar um professor
        public ProfessorTurma BuscarPorNome(string nome)
        {
            try
            {
                return ctx.ProfessorTurma.Where(p => p.Descricap.Contains(nome)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //editar o professor
        public void Editar(ProfessorTurma ProfessorT)
        {
            try
            {
                //buscar o professor pelo id
                ProfessorTurma professorTemp = BuscarPorNome(ProfessorT.IdProfessorTurma);
                //verifica se esta tudo certo e o professor está no sistema, caso falhe, um exeption é gerado 
                if (professorTemp == null)
                    throw new Exception("O Professor não existe no sistema, por favor envie um nome valido.")

                //caso exista o professor, altera suas propriedades
                professorTemp.Descricao = professorTemp.Descricao;

                //altera o professor
                ctx.ProfessorTurma.Update(professorTemp);
                //salvar alterações
                ctx.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ProfessorTurma> Listar()
        {
            try
            {
                return ctx.ProfessorTurma.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //deleta um professor do sistema 
        public void Remover(Guid Id)
        {
            try
            {
                //buscar o professor pelo id
                ProfessorTurma professorTemp = BuscarPorId(Id);
                //verifica se esta tudo certo e o professor está no sistema, caso falhe, um exeption é gerado 
                if (professorTemp == null)
                    throw new Exception("O Professor não existe no sistema, por favor envie um nome valido.")


                //remove o professor 
                ctx.ProfessorTurma.Remove(professorTemp);
                //salvar alterações
                ctx.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

}
}