using System.Security.Cryptography;


/* 

v1

Iremos fazer um jogo onde o usuário terá chances de acertar um número aleatório decidido pelo sistema.

Input (Entrada de Dados)O usuário digita número inteiro

Processamento
O sistema compara o número digitado com um número inteiro aleatório

Output (Saída de Dados)
O sistema informará o usuário se o mesmo acertou ou não, podendo incluir dicas sobre a proximidade do "chute"


*/

// Numero Aleatorio de 1 até 20
int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);
int tentivas = 1;

Console.WriteLine("-------------------");
Console.WriteLine("Jogo De Adivinhacão Contra Eu, Robo!");
Console.WriteLine("-------------------");

Console.WriteLine();
Console.Write("Comece Digitando um numero: ");
int numeroDigitado = int.Parse(Console.ReadLine());




Console.WriteLine("O Número digitado foi: " + numeroAleatorio);

if (numeroDigitado == numeroAleatorio)
{
    Console.WriteLine("Você Acertou!!!");
    Console.WriteLine("O Numero era " + numeroAleatorio);

}

else if (numeroDigitado > numeroAleatorio)
{
    Console.WriteLine("O numero digitado foi maior que o meu número!");
}

else
{
    Console.WriteLine("O numero digitado foi menor que o meu numero!");
}

Console.ReadKey();