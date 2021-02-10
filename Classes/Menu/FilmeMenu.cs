using dioseries.Classes.Repositorios;
using System;

namespace dioseries.Classes.Menu
{
    public class FilmeMenu : EntidadeMenuBase<Filme>
    {
        public FilmeMenu() : base(new FilmeRepositorio(), "Filme") { }

        protected override Filme Criar(int id)
        {
            foreach (int i in Enum.GetValues(typeof(EGenero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(EGenero), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int generoSelecionado = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o Título do Filme: ");
            var entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano de Inicio Filme: ");
            var entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição do Filme: ");
            var entradaDescricao = Console.ReadLine();

            Console.WriteLine("Digite a Duração do Filme: ");
            var entradaDuracao = Convert.ToInt32(Console.ReadLine());

            return new Filme(id, (EGenero)generoSelecionado, entradaDescricao, entradaDuracao, entradaTitulo, entradaAno);
        }

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

        private string ObterOpcaoSelecionada()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Cadastro Filmes a seu dispor!!!");
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
