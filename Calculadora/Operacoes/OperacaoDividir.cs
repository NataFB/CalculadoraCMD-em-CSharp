using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Calculadora.Operacoes
{
    class OperacaoDividir 
    {
        public static void Dividir()
        {
            // Implementação da operação de divisão
            Console.WriteLine("Operação de Divisão");
            Console.Write("Digite o número a dividir (Dividendo): ");
            string Dividendo = Console.ReadLine();
            Console.Write("Digite o número pelo qual dividir (Divisor): ");
            string Divisor = Console.ReadLine();

            //Validação de entrada vazia, utilizando IsNullOrWhiteSpace para verificar se o usuário não digitou nada ou apenas espaços em branco
            if (string.IsNullOrWhiteSpace(Dividendo) || string.IsNullOrWhiteSpace(Divisor))
            {
                Console.WriteLine("Entrada vazia. Operação cancelada.");
            } //Validação de entrada numérica, utilizando TryParse para verificar se as entradas são números válidos
            else if (!double.TryParse(Dividendo, CultureInfo.InvariantCulture, out double dividendo) || !double.TryParse(Divisor, CultureInfo.InvariantCulture, out double divisor))
            {
                Console.WriteLine("Entrada inválida. Operação cancelada.");
            }
            else // Se as entradas forem válidas, realiza a divisão e exibe o resultado
            {
                double.TryParse(Dividendo, CultureInfo.InvariantCulture, out dividendo);
                double.TryParse(Divisor, CultureInfo.InvariantCulture, out divisor);
                if (divisor == 0) // Verifica se o divisor é zero para evitar divisão por zero
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                }
                else // Realiza a divisão e exibe o resultado formatado com 2 casas decimais
                {
                    double resultado = dividendo / divisor;
                    Console.WriteLine($"Resultado da divisão: {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
                }
            }

            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
    }
}
