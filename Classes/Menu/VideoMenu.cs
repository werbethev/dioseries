using dioseries.Interfaces;
using System;

namespace dioseries.Classes.Menu
{
    public abstract class VideoMenu<T> : EntidadeMenuBase<T> where T : Video
    {
        public VideoMenu(IRepositorio<T> repositorio, string nomeEntidadeMenu)
            : base(repositorio, nomeEntidadeMenu) { }

        //Todo: buscar forma de reaproveitar o criar da serie e do filme
        protected override abstract T Criar(int id);

        public override void MostrarMenuPrincipal()
        {
            string opcaoSelecionada;
            do
            {
                opcaoSelecionada = ObterOpcaoSelecionada();

                Console.WriteLine();
                switch (opcaoSelecionada)
                {
                    case "1":
                        Listar();
                        break;
                    case "2":
                        Inserir();
                        break;
                    case "3":
                        Atualizar();
                        break;
                    case "4":
                        Excluir();
                        break;
                    case "5":
                        Visualizar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    case "X":
                        break;

                    default:
                        MenuConsole.MostrarOpcaoIncorreta();
                        break;
                }


            } while (opcaoSelecionada != "X");
        }

        private static string ObterOpcaoSelecionada()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Cadastro Séries a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1 - Listar");
            Console.WriteLine("2 - Inserir");
            Console.WriteLine("3 - Atualizar");
            Console.WriteLine("4 - Excluir");
            Console.WriteLine("5 - Visualizar");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            return Console.ReadLine().ToUpper();
        }
    }
}
