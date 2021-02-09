using dioseries.Classes;
using dioseries.Classes.Menu;
using System;

namespace dioseries
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string opcaoSelecionada;
            do
            {
                opcaoSelecionada = SerieMenu.ObterOpcaoSelecionada();

                Console.WriteLine();
                switch (opcaoSelecionada)
                {
                    case "1":
                        SerieMenu.ListarSeries();
                        break;
                    case "2":
                        SerieMenu.InserirSerie();
                        break;
                    case "3":
                        SerieMenu.AtualizarSerie();
                        break;
                    case "4":
                        SerieMenu.ExcluirSerie();
                        break;
                    case "5":
                        SerieMenu.VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção Incorreta!");
                        Console.WriteLine("Tente Novamente!");
                        break;
                }


            } while (opcaoSelecionada != "X");

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }
    }
}
