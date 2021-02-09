using System;

namespace dioseries.Classes
{
    public static class MenuConsole
    {
        public static int PerguntarId(string nomeEntidade) 
        {
            Console.WriteLine($"Digite o id da {nomeEntidade}: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
