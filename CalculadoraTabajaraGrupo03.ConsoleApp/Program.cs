using System;

namespace CalculadoraTabajaraGrupo03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            while (true)
            {
                #region Menu Principal
                Console.Clear();
                Console.WriteLine("Calculadora Tabajara do Grupo 03 1.0...\n");
                Console.WriteLine("Tela principal\n");
                Console.WriteLine("Digite 1 para realizar operações de Adição\n");
                Console.WriteLine("Digite 2 para realizar operações de Adição\n");
                Console.WriteLine("Digite 3 para realizar operações de Multiplicação\n");  
                Console.WriteLine("Digite 4 para realizar operações de Divisão\n");
                Console.WriteLine("Digite 5 para visualizar histórico\n");
                Console.WriteLine("Digite S para sair\n");
                Console.WriteLine("Opção: ");
                opcao = Console.ReadLine();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    break;

                if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Por favor, insira uma opção válida!");
                    Console.ResetColor();
                    Console.ReadLine();
                    continue;
                }

                #endregion

                #region Realizar Calculo

                Console.WriteLine("Calculadora Tabajara do Grupo 03 1.0");
                string operacao = "";
                
                switch (opcao)
                {
                    case "1": operacao = "Adição"; break;
                    case "2": operacao = "Subtração"; break;
                    case "3": operacao = "Multiplicação"; break;
                    case "4": operacao = "Divisão"; break;
                    
                    default:
                        break;
                }

                string subtitulo = $"Novo calculo de {operacao}";

                Console.WriteLine(subtitulo + '\n');

                Console.WriteLine($"Digite o primeiro número: ");
                double primeiroNumero = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Digite o segundo número: ");
                double segundoNumero = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                switch (opcao)
                {
                    case "1": resultado = primeiroNumero + segundoNumero; break;
                    case "2": resultado = primeiroNumero - segundoNumero; break;
                    case "3": resultado = primeiroNumero * segundoNumero; break;
                    case "4": resultado = primeiroNumero / segundoNumero; break;

                    default:
                        break;
                }
                #endregion

                #region Mostrar Resultado
                
                Console.Clear();

                Console.WriteLine("Calculadora Tabajara do Grupo 03 1.0\n");

                Console.WriteLine("Tela de Resultados\n");

                Console.Write($"O resultado da operação de {operacao} é: {resultado}");

                Console.WriteLine();

                Console.ReadLine();

                Console.Clear();

                #endregion
            }
        }
    }
}
