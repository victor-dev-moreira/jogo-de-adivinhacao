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

Console.WriteLine("-------------------");
Console.WriteLine("Jogo De Adivinhacão");
Console.WriteLine("-------------------");

Console.WriteLine();
Console.Write("Comece Digitando um numero: ");
string strNumeroDigitado = Console.ReadLine();


// Numero Aleatorio de 1 até 20
int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);

Console.WriteLine("O Número digitado foi: " + numeroAleatorio);

Console.ReadKey();