using System;

namespace dioseries.Classes.Menu
{
    public static class MenuConsole
    {
        public const string CaracterSair = "X";
        public const string CaracterLimparTela = "C";

        public static int PerguntarId(string nomeEntidade) 
        {
            Console.WriteLine($"Digite o id da {nomeEntidade}: ");
            return int.Parse(Console.ReadLine());
        }

        public static void MostrarOpcaoIncorreta()
        {
            Console.Clear();
            Console.WriteLine("Opção Incorreta!");
            Console.WriteLine("Tente Novamente!");
        }

        public static void OpcoesPadroesParaMenu() 
        {
            Console.WriteLine($"{CaracterLimparTela} - Limpar Tela");
            Console.WriteLine($"{CaracterSair} - Sair");
            Console.WriteLine();
        }

        public static void ExecutarOpcoesPadroesParaMenu(string opcaoSelecionada)
        {
            switch (opcaoSelecionada)
            {
                case CaracterLimparTela:
                    Console.Clear();
                    break;

                case CaracterSair:
                    break;

                default:
                    MenuConsole.MostrarOpcaoIncorreta();
                    break;
            }
        }
    }
}
