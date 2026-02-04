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

            while (true)
            {
                Console.Write("Digite um número: ");
                string entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada))
                {
                    break;
                }
                else if (double.TryParse(entrada,CultureInfo.InvariantCulture, out double valor))
                {
                    numeros.Add(valor);
                }
                else
                {
                    Console.WriteLine("Valor inválido, tente novamente.");
                }
            }

            double resultado = 0;

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
