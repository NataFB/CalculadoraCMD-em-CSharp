using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Calculadora.Operacoes
{
    internal class OperacaoRaiz
    {
        public static void Raiz()
        {
            // Implementação da operação de raiz quadrada
            Console.WriteLine("Operação de Raiz Quadrada");
            Console.Write("Digite o número da base da raiz: ");
            string baseNum = Console.ReadLine();
            Console.Write("Digite o número da ordem da raiz: ");
            string Ordem = Console.ReadLine();

            //Validação de entrada vazia, utilizando IsNullOrWhiteSpace para verificar se o usuário não digitou nada ou apenas espaços em branco
            if (string.IsNullOrWhiteSpace(baseNum) || string.IsNullOrWhiteSpace(Ordem))
            {
                Console.WriteLine("Entrada vazia. Operação cancelada.");
            }
            //Validação de entrada numérica, utilizando TryParse para verificar se a entrada é um número válido
            else if (!double.TryParse(baseNum, out double basenum) || !double.TryParse(Ordem, CultureInfo.InvariantCulture, out double ordem))
            {
                Console.WriteLine("Entrada inválida. Operação cancelada.");
            }
            else // Se as entradas forem válidas, realiza a expressão e exibe o resultado
            {
                double.TryParse(baseNum, CultureInfo.InvariantCulture, out basenum);
                double.TryParse(Ordem, CultureInfo.InvariantCulture, out ordem);
                if (basenum < 0) // Verifica se a base é negativa, pois isso gera um número NaN (not a number). A raiz de um número negativo não é um número real.
                {
                    Console.WriteLine("Erro: E A raiz de um número negativo não é um número real.");
                }
                else // Realiza a raiz e exibe o resultado formatado com 2 casas decimais
                {
                    // Para calcular a raiz de ordem n de um número, podemos usar a fórmula: raiz_n(x) = x^(1/n).
                    // Utilizamos Math.Pow para elevar a base à potência de 1 dividido pela ordem da raiz.
                    double resultado = Math.Pow(basenum, 1.0/ ordem);
                    Console.WriteLine($"Resultado da Raiz {ordem} de {basenum} é : {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
                }
            }
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
    }
}
