using Calculadora.Operacoes;

namespace Calculadora
{
    class Program
    {
        // Definição do enum Menu para representar as opções do menu
        enum Menu
        {
            Soma = 1,
            Subtracao,
            Divisao,
            Multiplicacao,
            Potencia,
            Raiz,
            Sair
        }
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair) // Enquanto o usuário não(!) escolher sair exiba o menu
            {
                Console.WriteLine("Menu da calculadora, Selecione uma das opções:");
                Console.WriteLine(
                    "1-Soma\n" +
                    "2-Subtração\n" +
                    "3-Divisão\n" +
                    "4-Multiplicação\n" +
                    "5-Potencia\n" +
                    "6-Raiz\n" +
                    "7-Sair");
                Menu opcao = (Menu)int.Parse(Console.ReadLine()); //Aplicando casting para o enum Menu

                //Lógica para chamar a operação escolhida
                switch (opcao)
                {
                    case Menu.Soma:
                        OperacaoSoma.Soma();
                        break;
                    case Menu.Subtracao: 
                        OperacaoSubtrair.Subtrair();
                        break;
                    case Menu.Divisao:
                        OperacaoDividir.Dividir();
                        break;
                    case Menu.Multiplicacao:
                        OperacaoMultiplicar.Multiplicar();
                        break;
                    case Menu.Potencia:
                        OperacaoPotencia.Potencia();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;

                }
                Console.Clear(); // Limpa o console para melhor visualização
            }
        }
    }
}