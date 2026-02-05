using System.Globalization;

namespace Calculadora.Operacoes
{
    class OperacaoSoma
    {
        public static void Soma()
        {

            List<double> numeros = new List<double>();

            Console.WriteLine("Digite números para somar.");
            Console.WriteLine("Pressione ENTER vazio para finalizar.\n");

            while (true) // Loop infinito, será interrompido quando o usuário pressionar ENTER sem digitar nada, Adicionalmente, valida se o valor digitado é numérico
            {
                Console.Write("Digite um número: ");
                string entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada))
                {
                    break;
                }
                else if (double.TryParse(entrada,CultureInfo.InvariantCulture, out double valor))
                {
                    numeros.Add(valor); // Adiciona o número à lista
                }
                else
                {
                    Console.WriteLine("Valor inválido, tente novamente.");
                }
            }

            double resultado = 0;

            // Realiza a soma dos números armazenados na lista
            foreach (double n in numeros)
            {
                resultado += n;
            }
            Console.WriteLine();
            Console.WriteLine($"Resultado da soma: {resultado.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine("Pressione ENTER para voltar ao menu");
            Console.ReadLine();
        }
    }
}
