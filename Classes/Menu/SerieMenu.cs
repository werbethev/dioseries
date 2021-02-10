using dioseries.Classes.Repositorios;
using System;

namespace dioseries.Classes.Menu
{
    public class SerieMenu : EntidadeMenuBase<Serie>
    {
        public SerieMenu(): base(new SerieRepositorio(), "Série") { }

        protected override Serie Criar(int id)
        {
            foreach (int i in Enum.GetValues(typeof(EGenero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(EGenero), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int generoSelecionado = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o Título da Série: ");
            var entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano de Inicio Série: ");
            var entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição da Série: ");
            var entradaDescricao = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de temporadas da Série: ");
            var entradaQuantTemporada = Convert.ToInt32(Console.ReadLine());

            return new Serie(id, (EGenero)generoSelecionado, entradaTitulo,
                                    entradaDescricao, entradaAno, entradaQuantTemporada);
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
