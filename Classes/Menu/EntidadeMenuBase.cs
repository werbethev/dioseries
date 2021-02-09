using dioseries.Interfaces;
using System;

namespace dioseries.Classes.Menu
{
    public abstract class EntidadeMenuBase<T> where T: EntidadeBase
    {
        protected readonly IRepositorio<T> repositorio;
        protected readonly string nomeDaEntidadeNoMenu;

        public EntidadeMenuBase(IRepositorio<T> repositorio, string nomeEntidadeMenu)
        {
            this.repositorio = repositorio;
            this.nomeDaEntidadeNoMenu = nomeEntidadeMenu;
        }

        protected void Atualizar()
        {
            int id = MenuConsole.PerguntarId(nomeDaEntidadeNoMenu);
            T entidade = Criar(id);
            repositorio.Atualizar(entidade);
        }

        protected abstract T Criar(int id);

        protected void Excluir()
        {
            int id = MenuConsole.PerguntarId(nomeDaEntidadeNoMenu);
            repositorio.Excluir(id);
        }

        protected void Inserir()
        {
            Console.WriteLine($"Inserir nova {nomeDaEntidadeNoMenu}");
            var novaEntidade = Criar(repositorio.ProximoId());
            repositorio.Inserir(novaEntidade);
        }

        protected void Listar()
        {
            Console.WriteLine($"Listar {nomeDaEntidadeNoMenu}s");

            var lista = repositorio.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine($"Nenhuma {nomeDaEntidadeNoMenu} cadastrada.");
                return;
            }

            lista.ForEach(entidade => 
                    Console.WriteLine($"ID {entidade.Id}: - {entidade.RetornaDescricaoMenu()} {(entidade.RetornaExcluido() ? " - *Excluido*" : "")}"));
        }

        public abstract void MostrarMenuPrincipal();

        protected void Visualizar()
        {
            int id = MenuConsole.PerguntarId(nomeDaEntidadeNoMenu);
            Console.WriteLine(repositorio.RetornaPorId(id));
        }
    }
}
