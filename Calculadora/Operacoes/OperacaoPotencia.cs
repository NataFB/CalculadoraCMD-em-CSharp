using System.Globalization;

namespace Calculadora.Operacoes
{
    class OperacaoPotencia
    {
        public static void Potencia()
        {
            // Implementação da operação de Potencia
            Console.WriteLine("Operação de Potência");
            Console.Write("Digite o número da Base: ");
            string baseNum = Console.ReadLine();
            Console.Write("Digite o número do Expoente: ");
            string Expoente = Console.ReadLine();

            //Validação de entrada vazia, utilizando IsNullOrWhiteSpace para verificar se o usuário não digitou nada ou apenas espaços em branco
            if (string.IsNullOrWhiteSpace(baseNum) || string.IsNullOrWhiteSpace(Expoente))
            {
                Console.WriteLine("Entrada vazia. Operação cancelada.");
            }
            //Validação de entrada numérica, utilizando TryParse para verificar se as entradas são números válidos
            else if (!double.TryParse(baseNum, CultureInfo.InvariantCulture, out double basenum) || !double.TryParse(Expoente, CultureInfo.InvariantCulture, out double expoente))
            {
                Console.WriteLine("Entrada inválida. Operação cancelada.");
            }
            else // Se as entradas forem válidas, realiza a divisão e exibe o resultado
            {
                double.TryParse(baseNum, CultureInfo.InvariantCulture, out basenum);
                double.TryParse(Expoente, CultureInfo.InvariantCulture, out expoente);
                if ( basenum == 0 && expoente == 0) // Verifica se a base e o expoente são ambos zero, pois 0 elevado a 0 é uma expressão indeterminada
                {
                    Console.WriteLine("Erro: Expressão 0 elevado a 0 é indeterminada.");
                }
                else // Realiza a potência utilizando Math.Pow e exibe o resultado formatado com 2 casas decimais
                {
                    double resultado = Math.Pow(basenum, expoente);
                    Console.WriteLine($"Resultado da divisão: {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
                }
            }

            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
    }
}
