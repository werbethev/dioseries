﻿using System;

namespace dioseries
{
    class Program
    {
        static void Main(string[] args)
        {
            var opcaoSelecionada = ObterOpcaoSelecionada();

            while (opcaoSelecionada != "X")
            {
                switch (opcaoSelecionada)
                {
                    case "1":
                        //Listar();
                        break;
                    case "2":
                        //Inserir();
                        break;
                    case "3":
                        //Atualizar
                        break;
                    case "4":
                        //Excluir
                        break;
                    case "5":
                        //Visualizar
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
                opcaoSelecionada = ObterOpcaoSelecionada();
            }
        }

        private static string ObterOpcaoSelecionada()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            return Console.ReadLine().ToUpper();
        }
    }
}
