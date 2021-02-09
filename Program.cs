using dioseries.Classes.Menu;
using System;

namespace dioseries
{
    class Program
    {
        private static SerieMenu serieMenu = new SerieMenu();
        
        static void Main(string[] args)
        {
            serieMenu.MostrarMenuPrincipal();

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }
    }
}
