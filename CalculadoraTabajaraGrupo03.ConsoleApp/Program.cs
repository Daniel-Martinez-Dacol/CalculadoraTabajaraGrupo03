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
                Console.WriteLine("Calculadora Tabajara do Grupo 03...\n");
                Console.WriteLine("Tela principal\n");
                Console.WriteLine("Digite S para sair\n");
                Console.WriteLine("Opção: ");
                opcao = Console.ReadLine();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    break;

                #endregion

                #region Realizar Calculo

                Console.WriteLine("Calculadora Tabajara");
                string operacao = "";
                
                switch (opcao)
                {
                    default:
                        break;
                }

                string subtitulo = $"Novo calculo de {operacao}";

                Console.WriteLine(subtitulo + '\n');

                Console.WriteLine($"Digite o primeiro número: ");
                double primeiroNumero = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Digite o primeiro número: ");
                double segundoNumero = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                switch (opcao)
                {
                    default:
                        break;
                }
                #endregion

                #region Mostrar Resultado
                
                Console.Clear();

                Console.WriteLine("Calculadora Tabajara\n");

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
