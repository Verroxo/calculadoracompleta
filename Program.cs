// Feita dia 17/03/2022 por César Rodrigues Ribeiro, ultilizando de proveito conteúdo do Gilmar (Professor) e do livro "C# para iniciantes"

using System;

namespace CalculadoraPraticaCesarRodrigues
{
    class Program
    {

        static void Main(string[] args)
        {

            // Estilização do console:

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;

            //Entrada do programa -->

            Console.WriteLine("Me diga 3 números, vou tentar fazer o máximo de operações com eles! Número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Certo, o segundo então ---->");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O terceiro? ----> ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            // Soma:

            double soma = num1 + num2 + num3;
            Console.WriteLine("A soma dos dois números é: " + soma);

            // Subtração

            double subtracao = num1 - num2 - num3;
            Console.WriteLine("A subtração dos dois números é: " + subtracao);

            // Multiplicação

            double multiplicacao = num1 * num2 * num3;
            Console.WriteLine("A multiplicação dos dois números é: " + multiplicacao);

            // Divisão

            double divisao = num1 / num2 / num3;
            Console.WriteLine("A divisão dos dois números é: " + divisao);

            // Agora, totalmente as instruções:


            // Raiz quadrada
            double raiz = Math.Sqrt(soma);
            Console.WriteLine("Seu resultado em raiz quadrada é de " + raiz);

            // Raiz cúbica

            double cubica = Math.Pow(soma, 1.0 / 3.0);
            Console.WriteLine("Essa é a raiz cúbica da soma: " + cubica);


            // Potência:
            double pot = Math.Pow(soma, 2);
            Console.WriteLine("Seu número em sua potenciação é de " + pot);


            // O maior entre:
            double numeroalto = Math.Max(num1, num2);
            double numeroalto1 = Math.Max(num1, num3);
            Console.WriteLine("Seu maior número entre eles é " + numeroalto1);

            // Porcentagem:

            double porcentagem = (soma + num3 / 100);
            Console.WriteLine("A soma de números dividida pelo numero 3 em porcentagem: " + porcentagem);

            // Valor mais próximo:

            double proximo = Math.Round(soma);
            Console.WriteLine("O número mais aproximado: " + proximo);

            // Retorna o valor como -1, 0 ou 1:

            double ativador = Math.Sign(soma);
            Console.WriteLine("Seu resultado é:... " + ativador);

            // Remover a parte de fração só inteiro:

            double inteira = Math.Truncate(soma);
            Console.WriteLine("O número é " + inteira);

            // Beep na entrada de 0 ou 1:

            Console.WriteLine("Deseja ouvir um beep de 2 segundos? (1-Sim, 2-Não)");
            string resposta = Console.ReadLine() ?? "";

            if (resposta == "1")
            {
                Console.Beep(1000, 2000);
                Console.WriteLine("Beep gerado com sucesso!");
            }
            else
            {
                Console.WriteLine("Beep não gerado.");
            }

            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("Vamos continuar.. rs");

            // Você quer que o programa tenha tais cores?:

            Console.WriteLine("Você quer mudar as cores para o normal? Digite 'sim!'");
            string resetback = Console.ReadLine() ?? "";

            if (resposta == "sim")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {

                Console.WriteLine("Certo então! Como queira.");
            }

            // Agradecimento
            Console.WriteLine("Muito obrigado por me acompanhar nesse programa básico feita em linha de comandos em C#! (csharp)");

        }
    }

}