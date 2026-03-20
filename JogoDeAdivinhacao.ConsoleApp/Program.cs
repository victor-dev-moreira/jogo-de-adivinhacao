using System.Security.Cryptography;


/* 

v1

Iremos fazer um jogo onde o usuário terá chances de acertar um número aleatório decidido pelo sistema.

Input (Entrada de Dados)O usuário digita número inteiro

Processamento
O sistema compara o número digitado com um número inteiro aleatório

Output (Saída de Dados)
O sistema informará o usuário se o mesmo acertou ou não, podendo incluir dicas sobre a proximidade do "chute"

1 a 20 - 10 tentativas
1 a 50 - 7 tentativas
1 a 100 - 3 tentativas

*/

// Numero Aleatorio de 1 até 20

bool jogoContinua = true;


while (jogoContinua)
{
    Console.Clear();
    int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);
    Console.WriteLine("-------------------");
    Console.WriteLine("Jogo De Adivinhacão Contra Eu, Robo!");
    Console.WriteLine("-------------------");

    Console.WriteLine("Digite 1 para Fraco");
    Console.WriteLine("Digite 2 para Mediano");
    Console.WriteLine("Digite 3 para Impossivel");
    Console.WriteLine("-------------------");

    Console.Write("Qual dificuldade você deseja? ");
    int dificuldade = int.Parse(Console.ReadLine());

    #region Dificuldade Facil

    if (dificuldade == 1)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Serio que escolheu essa dificuldade? Você é fraco, humano!");
            Console.WriteLine("Tentativa numero " + i);
            Console.Write("Digite um numero: ");
            int numeroDigitado = int.Parse(Console.ReadLine());


            if (numeroDigitado == numeroAleatorio)
            {
                Console.WriteLine("Você Acertou mas não se orgulhe, humano!");
                Console.WriteLine("O Numero era " + numeroAleatorio);
                i = 10;

            }

            else if (numeroDigitado > numeroAleatorio)
            {
                Console.WriteLine("O numero digitado foi maior que o meu número!");
            }

            else
            {
                Console.WriteLine("O numero digitado foi menor que o meu numero!");
            }

            if (i == 20)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("Você conseguiu perder na dificuldade facil, repense sua vida, humano!");
            }
        }

    }
    #endregion

    if (dificuldade == 2)
    {
        numeroAleatorio = RandomNumberGenerator.GetInt32(1, 51);

        Console.WriteLine("-------------------");
        Console.WriteLine("Você escolheu a dificuldade mediano, já é algo, humano!");
        Console.WriteLine("-------------------");

        for (int i = 1; i <= 7; i++)
        {
            Console.WriteLine("Tentativa numero " + i);
            Console.Write("Digite Seu Numero, Humano: ");
            int numeroDigitado = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------");

            if (numeroDigitado == numeroAleatorio)
            {
                Console.WriteLine("Você FINALMENTE me venceu, humano!");
                Console.WriteLine("O Numero era " + numeroAleatorio);
                i = 7;

            }

            else if (numeroDigitado > numeroAleatorio)
            {
                Console.WriteLine("O numero digitado foi maior que o meu número!");
            }

            else
            {
                Console.WriteLine("O numero digitado foi menor que o meu numero!");
            }

            if (i == 7)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("Nem mediano você, volte para dificuldade fraco, humano!");

            }
        }

    }


    if (dificuldade == 3)
    {
        numeroAleatorio = RandomNumberGenerator.GetInt32(1, 101);

        Console.WriteLine("-------------------");
        Console.WriteLine("Você escolheu a dificuldade impossivel, você é corasojo, humano!");
        Console.WriteLine("-------------------");

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("Tentativa numero " + i);
            Console.Write("Digite Seu Numero, Humano: ");
            int numeroDigitado = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------");

            if (numeroDigitado == numeroAleatorio)
            {
                Console.WriteLine("Você me venceu na dificuldade mais dificil, tem meu respeito, humano!");
                Console.WriteLine("O Numero era " + numeroAleatorio);
                i = 3;

            }

            else if (numeroDigitado > numeroAleatorio)
            {
                Console.WriteLine("O numero digitado foi maior que o meu número!");
            }

            else
            {
                Console.WriteLine("O numero digitado foi menor que o meu numero!");
            }

            if (i == 3)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("Achou que poderia me vencer na dificuldade mais dificil, humano?");

            }
        }
    }


    Console.WriteLine("-------------------");
    Console.Write("Quer continuar jogando comigo, humano? (s/n) ");
    string opcaoContinuar = Console.ReadLine().ToUpper();

    if (opcaoContinuar == "S")
    {
        Console.WriteLine("Vamos Continar Então!");
        Console.WriteLine("Pressione Enter, humano!");
        Console.ReadKey();
    }
    else
    {
        jogoContinua = false;
        Console.WriteLine("Eu te entendo, é dificil me vencer, humano!");
    }

}







//Console.WriteLine("O Número digitado foi: " + numeroAleatorio);


Console.ReadKey();