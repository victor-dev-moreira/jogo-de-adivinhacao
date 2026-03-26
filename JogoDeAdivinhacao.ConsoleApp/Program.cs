using System.Security.Cryptography;


/* 

v1

Iremos fazer um jogo onde o usuário terá chances de acertar um número aleatório decidido pelo sistema.

Input (Entrada de Dados)O usuário digita número inteiro

Processamento
O sistema compara o número digitado com um número inteiro aleatório

Output (Saída de Dados)
O sistema informará o usuário se o mesmo acertou ou não, podendo incluir dicas sobre a proximidade do "chute"

v2 (Novos Requisitos: 24/03)

1. Implemente a funcionalidade de Dificuldade e Tentativas limitadas

O jogador tem um número limitado de tentativas para adivinhar o número.
Fácil (intervalo 1 a 20): ≈ 10 tentativas.
Médio (intervalo 1 a 50): ≈ 5 tentativas.
Difícil (intervalo 1 a 100): ≈ 3 tentativas.
2. Implemente uma funcionalidade de Validação de Números Repetidos

O jogador deve ser informado caso o número que está tentando adivinhar já tenha sido informado anteriormente na mesma rodada.

3. Implemente uma funcionalidade de Pontuação, onde:

O jogador começa com uma pontuação máxima, por exemplo, 1000 pontos.
A pontuação é calculada com base na proximidade do palpite em relação ao número secreto.
A cada tentativa errada, o jogador perde pontos de acordo com a distância do número secreto:
Se a diferença entre o número secreto e o palpite for de 10 ou mais, o jogador perde 100 pontos.
Se a diferença for entre 5 e 9, o jogador perde 50 pontos.
Se a diferença for entre 1 e 4, o jogador perde 20 pontos.
Quando o jogador acerta o número, sua pontuação final é registrada.

Exemplo:
1. Número secreto: 50
2. Palpite do jogador: 30 → diferença de 20 → o jogador perde 100 pontos (de 1000 para 900).
3. Palpite do jogador: 48 → diferença de 2 → o jogador perde 20 pontos (de 900 para 880).
4. Palpite do jogador: 50 → acerto → jogo termina com 888 pontos.

*/

bool jogoContinua = true;
while (jogoContinua)
{
    //Console.Clear();

    Console.WriteLine("------------------------------------------"); Console.WriteLine("Jogo De Adivinhacão Contra Eu, Robo!");
    Console.WriteLine("------------------------------------------");

    Console.WriteLine("Digite 1 para Fraco (10 Tentativas)");
    Console.WriteLine("Digite 2 para Mediano (5 Tentativas)");
    Console.WriteLine("Digite 3 para Impossivel (3 Tentativas)");
    Console.WriteLine("------------------------------------------");

    Console.Write("Qual dificuldade você deseja? ");
    string dificuldade = Console.ReadLine();

    int tentativasMaximas = 0;
    int numeroAleatorio;


    switch (dificuldade)
    {
        case "1":
            numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);
            tentativasMaximas = 10;

            break;

        case "2":
            numeroAleatorio = RandomNumberGenerator.GetInt32(1, 51);
            tentativasMaximas = 5;
            break;

        case "3":
            numeroAleatorio = RandomNumberGenerator.GetInt32(1, 101);
            tentativasMaximas = 3;
            break;

        default:
            Console.WriteLine("Digite um numero valido.");
            Console.WriteLine("Pressione enter para continuar...");
            Console.ReadLine();
            continue;
    }

    int[] numeros = new int[tentativasMaximas];
    int contadorNumeros = 0;
    int pontuacao = 1000;

    for (int i = 1; i <= tentativasMaximas; i++)
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Tentativa numero: " + i);
        Console.WriteLine($"Pontuacão: {pontuacao}");
        Console.WriteLine("------------------------------------------");

        Console.Write("Digite um numero: ");
        int numeroDigitado = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("DEBUG: passou aqui");

        if (numeroDigitado == numeroAleatorio)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Você Acertou mas não se orgulhe, humano!");
            Console.WriteLine("O Numero era " + numeroAleatorio);
            break;

        }

        else if (numeroDigitado > numeroAleatorio)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("O numero digitado foi maior que o meu número!");
        }

        else
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("O numero digitado foi menor que o meu numero!");

        }

        //  Se a diferença entre o número secreto e o palpite for de 10 ou mais, o jogador perde 100 pontos.
        //  Se a diferença for entre 5 e 9, o jogador perde 50 pontos.
        //  Se a diferença for entre 1 e 4, o jogador perde 20 pontos.
        //  Quando o jogador acerta o número, sua pontuação final é registrada.


        int diferenca = Math.Abs(numeroAleatorio - numeroDigitado);
        if (diferenca >= 10)
        {
            pontuacao = pontuacao - 100;
        }
        else if (diferenca >= 5)
        {
            pontuacao = pontuacao - 50;
        }
        else
        {
            pontuacao = pontuacao - 20;
        }

        bool repetido = false;
        for (int a = 0; a < numeros.Length; a++)
        {
            if (numeros[a] == numeroDigitado)
            {
                repetido = true;
                break;
            }

        }

        if (repetido)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Você digitou numero repetido");
            Console.WriteLine("Pressione Enter Para Continuar");
            Console.ReadLine();
            i--;
            continue;
        }

        numeros[contadorNumeros] = numeroDigitado;
        contadorNumeros++;

    }



    #region Com if

    // if (dificuldade == 1)
    // {
    //     for (int i = 1; i <= 10; i++)
    //     {
    //         Console.WriteLine("Serio que escolheu essa dificuldade? Você é fraco, humano!");
    //         Console.WriteLine("Tentativa numero " + i);
    //         Console.Write("Digite um numero: ");
    //         int numeroDigitado = int.Parse(Console.ReadLine());


    //         if (numeroDigitado == numeroAleatorio)
    //         {
    //             Console.WriteLine("Você Acertou mas não se orgulhe, humano!");
    //             Console.WriteLine("O Numero era " + numeroAleatorio);
    //             i = 10;

    //         }

    //         else if (numeroDigitado > numeroAleatorio)
    //         {
    //             Console.WriteLine("O numero digitado foi maior que o meu número!");
    //         }

    //         else
    //         {
    //             Console.WriteLine("O numero digitado foi menor que o meu numero!");
    //         }

    //         if (i == 20)
    //         {
    //             Console.WriteLine("-------------------");
    //             Console.WriteLine("Você conseguiu perder na dificuldade facil, repense sua vida, humano!");
    //         }
    //     }

    // }




    // if (dificuldade == 2)
    // {
    //     numeroAleatorio = RandomNumberGenerator.GetInt32(1, 51);

    //     Console.WriteLine("-------------------");
    //     Console.WriteLine("Você escolheu a dificuldade mediano, já é algo, humano!");
    //     Console.WriteLine("-------------------");

    //     for (int i = 1; i <= 5; i++)
    //     {
    //         Console.WriteLine("Tentativa numero " + i);
    //         Console.Write("Digite Seu Numero, Humano: ");
    //         int numeroDigitado = int.Parse(Console.ReadLine());
    //         Console.WriteLine("-------------------");

    //         if (numeroDigitado == numeroAleatorio)
    //         {
    //             Console.WriteLine("Você FINALMENTE me venceu, humano!");
    //             Console.WriteLine("O Numero era " + numeroAleatorio);
    //             i = 5;

    //         }

    //         else if (numeroDigitado > numeroAleatorio)
    //         {
    //             Console.WriteLine("O numero digitado foi maior que o meu número!");
    //         }

    //         else
    //         {
    //             Console.WriteLine("O numero digitado foi menor que o meu numero!");
    //         }

    //         if (i == 7)
    //         {
    //             Console.WriteLine("-------------------");
    //             Console.WriteLine("Nem mediano você, volte para dificuldade fraco, humano!");

    //         }
    //     }

    // }





    // if (dificuldade == 3)
    // {
    //     numeroAleatorio = RandomNumberGenerator.GetInt32(1, 101);

    //     Console.WriteLine("-------------------");
    //     Console.WriteLine("Você escolheu a dificuldade impossivel, você é corasojo, humano!");
    //     Console.WriteLine("-------------------");

    //     for (int i = 1; i <= 3; i++)
    //     {
    //         Console.WriteLine("Tentativa numero " + i);
    //         Console.Write("Digite Seu Numero, Humano: ");
    //         int numeroDigitado = int.Parse(Console.ReadLine());
    //         Console.WriteLine("-------------------");

    //         if (numeroDigitado == numeroAleatorio)
    //         {
    //             Console.WriteLine("Você me venceu na dificuldade mais dificil, tem meu respeito, humano!");
    //             Console.WriteLine("O Numero era " + numeroAleatorio);
    //             i = 3;

    //         }

    //         else if (numeroDigitado > numeroAleatorio)
    //         {
    //             Console.WriteLine("O numero digitado foi maior que o meu número!");
    //         }

    //         else
    //         {
    //             Console.WriteLine("O numero digitado foi menor que o meu numero!");
    //         }

    //         if (i == 3)
    //         {
    //             Console.WriteLine("-------------------");
    //             Console.WriteLine("Achou que poderia me vencer na dificuldade mais dificil, humano?");

    //         }
    //     }
    // }
    #endregion


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