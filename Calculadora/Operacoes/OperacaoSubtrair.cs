using System.Globalization;


namespace Calculadora.Operacoes
{
    class OperacaoSubtrair
    {
        public static void Subtrair()
        {

            List<double> numeros = new List<double>();

            Console.WriteLine("Digite números para subtrair.");
            Console.WriteLine("Pressione ENTER vazio para finalizar.\n");

            while (true) // Loop infinito, será interrompido quando o usuário pressionar ENTER sem digitar nada, Adicionalmente, valida se o valor digitado é numérico
            {
                Console.Write("Digite um número: ");
                string entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada))
                {
                    break;
                }
                else if (double.TryParse(entrada, CultureInfo.InvariantCulture, out double valor))
                {
                    numeros.Add(valor); // Adiciona o número à lista
                }
                else
                {
                    Console.WriteLine("Valor inválido, tente novamente.");
                }
            }

            // Define o resultado inicial como o primeiro número da lista ou 0 se a lista estiver vazia
            ////Expresão Condicional Ternária: ( condição ) ? valor_se_verdadeiro : valor_se_falso
            //numeros.Count > 0  -> Verifica se a lista tem elementos
            double resultado = (numeros.Count > 0) ? numeros[0] : 0;

            // Realiza a subtrair dos números armazenados na lista
            // Começa do segundo elemento (índice 1) para subtrair do primeiro que está armazenada em resultado.
            // Se não seria incorreta a operação de subtração. Pois o resultado inicial subtrairia ele mesmo.
            for (int i = 1; i < numeros.Count; i++)
            {
                resultado -= numeros[i];
            }
            Console.WriteLine();
            Console.WriteLine($"Resultado da subtração: {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("Pressione ENTER para voltar ao menu");
            Console.ReadLine();
        }
    }
}
