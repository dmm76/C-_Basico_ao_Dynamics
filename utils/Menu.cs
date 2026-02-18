using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto01.utils
{
    public class Menu
    {
        public static void Exibir()
        {
            string? opcao;
            bool exibirMenu = true;

            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a opcão desejada:");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Buscar Cliente por CPF");
                Console.WriteLine("3 - Apagar Cliente");
                Console.WriteLine("4 - Listar Clientes");
                Console.WriteLine("5 - Sair");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Cadastrar Cliente");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Buscar Cliente por CPF");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Apagar Cliente");
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Listar Clientes");
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Sair");
                        // Environment.Exit(0); //encerra o programa sem continuar a execução
                        exibirMenu = false; //altera a variável para sair do loop e encerrar o programa
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        Console.ReadKey();
                        break;
                }
            }
            Console.WriteLine("Programa encerrado.");
        }
    }
}
