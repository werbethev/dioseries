using System;

namespace dioseries.Classes.Menu
{
    public static class MenuConsole
    {
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
    }
}
