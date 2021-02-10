using dioseries.Classes.Menu;
using System;

namespace dioseries
{
    class Program
    {
        private static SerieMenu serieMenu = new SerieMenu();
        private static FilmeMenu filmeMenu = new FilmeMenu();

        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.WriteLine("Digite a opção que deseja cadastrar:");
                Console.WriteLine("1 - Serie");
                Console.WriteLine("2 - Filme");
                MenuConsole.OpcoesPadroesParaMenu();
                opcao = Console.ReadLine().ToUpper();

                switch (opcao)
                {
                    case "1":
                        serieMenu.MostrarMenuPrincipal();
                        break;

                    case "2":
                        filmeMenu.MostrarMenuPrincipal();
                        break;

                    default:
                        MenuConsole.ExecutarOpcoesPadroesParaMenu(opcao);
                        break;
                }

            } while (opcao != MenuConsole.CaracterSair);

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }
    }
}
