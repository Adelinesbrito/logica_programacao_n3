//01.Conversão de Temperatura -> Difícil
//    Crie um programa que peça ao usuário uma temperatura em graus Celsius.
//    Converta para Fahrenheit usando a fórmula: F = (Cx9 / 5) + 32
//    Exiba o resultado.

//Console.WriteLine("Insira uma temperatura uma temperatura em graus Celsius");





//--------------------------------------------------------------------------------//
//02.Operações Matemáticas->Fácil
//    Solicite dois números inteiros ao usuário.
//    Armazene-os em variáveis.
//    Calcule e exiba a soma, subtração, multiplicação e divisão.

//Console.WriteLine("Insira uma  número inteiro");
//int n1 = int.Parse(Console.ReadLine());
//Console.WriteLine("insira mais um numero inteiro");
//int n2 = int.Parse(Console.ReadLine());
//Console.WriteLine("O valor da soma é : " + (n1 + n2));
//Console.WriteLine("O valor da subtração  é : " + (n1 - n2));
//Console.WriteLine("O valor da multiplicação é : " + (n1 * n2));
//Console.WriteLine("O valor da divisão é : " + (n1 % n2));
//-----------------------------------------------------------------//
//03.Estrutura de Decisão(if/else) -> Fácil
//    Peça ao usuário um número inteiro.
//    Informe se ele é múltiplo de 3, de 5 ou de ambos.

//using System.Runtime.CompilerServices;

//Console.WriteLine("Insira uma  número inteiro");
//int n1 = int.Parse(Console.ReadLine());

//bool multiplo3 = n1 % 3 == 0;
//bool multiplo5 = n1 % 5 == 0;


//if (multiplo3 && multiplo5)
//{
//    Console.WriteLine("O numero eh multiplo de 3 e 5!");
//}
//else if (multiplo5)
//{
//    Console.WriteLine("O numero eh multiplo de 5.");
//}
//else if (multiplo3)
//{
//    Console.WriteLine("O numero eh multiplo de 3.");
//}
//else
//{
//    Console.WriteLine("O nomero NAO eh multiplo nem de 5, nem de 3...");
//}
//-----------------------------------------------------------------//

//////04.Estrutura de Decisão(switch) -> Fácil
//////    Solicite ao usuário um número de 1 a 7.
//////    Exiba o dia da semana correspondente (1 = Domingo, 2 = Segunda, etc.).

// const string DIA_1 = "DOMINGO";
//const string DIA_2 = "SEGUNDA-FEIRA";
//const string DIA_3 = "TERÇA- FEIRA";
//const string DIA_4 = "QUARTA-FEIRA ";
//const string DIA_5 = "QUINTA-FEIRA ";
//const string DIA_6 = "SEXTA-FEIRA";
//const string DIA_7 = "SABADO";

//const string MSG_NUMERO = "Informe um numero inteiro de 1 a 7 ?";

//Console.WriteLine(MSG_NUMERO);
//int numero = int.Parse(Console.ReadLine());

//string dia;

//switch (numero)
//{
//    case 1:
//        dia = DIA_1;
//        break;

//    case 2:
//        dia = DIA_2;
//        break;

//    case 3:
//        dia = DIA_3;
//        break;

//    case 4:
//        dia = DIA_4;
//        break;

//    case 5:
//        dia = DIA_5;
//        break;

//    case 6:
//        dia = DIA_6;
//        break;

//    case 7:
//        dia = DIA_7;
//        break;

//    default:
//        dia = "Número inválido! Digite entre 1 e 7.";
//        break;

//}

//Console.WriteLine($" o {numero} é {dia} !");

//-----------------------------------------------------------------//

//05.Laço de Repetição(for) -> Fácil
//    Crie um programa que exiba todos os números de 1 a 20 usando for.
//for (int i = 1; i <= 20; i++)
//{
//    Console.WriteLine(i);
//}

//-----------------------------------------------------------------//


//06.Laço de Repetição(while) -> Fácil
//    Solicite ao usuário um número.
//    Continue pedindo novos números até que ele digite 0.
//    Ao final, mostre quantos números foram digitados.
//int contador = 0;
//int respostaUsuario = -1;

//while (respostaUsuario != 0)
//{
//    Console.WriteLine("Digitar um nro:");
//    respostaUsuario = int.Parse(Console.ReadLine());

//    if (respostaUsuario != 0)
//    {
//        contador++;
//    }
//}

//Console.WriteLine(contador);
//-----------------------------------------------------------------//

//////07.Contagem de Vogais -> Difícil
//////    Peça ao usuário para digitar uma palavra.
//////    Use um laço de repetição para percorrer cada letra.
//////    Conte quantas vogais (a, e, i, o, u) existem na palavra.
//////    Exiba o total de vogais encontradas.

//Console.WriteLine(" Escreva uma palavra:");
//string palavra = Console.ReadLine().ToLower();
//int totalVogais = 0;

//for (int i = 0; i < palavra.Length; i++)
//{
//    char letra = palavra[i];

//    if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
//    {
//        totalVogais++;
//    }
//}
//Console.WriteLine(totalVogais);

//-----------------------------------------------------------------//

//08.Lista Simples(Array)->Médio
//    Crie um programa que armazene 5 nomes em um array.
//    Depois, exiba todos os nomes na tela.

//cconst int CINCO = 5;

//string[] nomes = new string[CINCO];

//for (int i = 0; i < CINCO; i++)
//{
//    Console.WriteLine("Insira um nome:");
//    nomes[i] = Console.ReadLine();
//}

//for (int i = 0; i < nomes.Length; i++)
//{
////    Console.WriteLine(nomes[i]);
//}
//09.Lista com Inteiros -> Médio
//    Crie uma lista de números inteiros.
//    Peça ao usuário para digitar 5 números e armazene-os na lista.
//    Exiba o maior e o menor número digitado.

//List<int> numeros = new List<int>();

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Insira um numero inteiro:");
//    int numero = int.Parse(Console.ReadLine());
//    numeros.Add(numero);
//}

//int maior = 0;
//int menor  = 0;

//for (int i = 0; i < numeros.Count; i++)
//{
//    if (numeros[i] > maior)
//    {
//        maior = numeros[i];
//    }
//    if (numeros[i] < menor)
//    {
//        menor = numeros[i];
//    }
//}
//Console.WriteLine("O menor numero é:"+ menor);
//Console.WriteLine("O maior numero é:" + maior);

//10.Média de Notas -> Médio
//    Solicite ao usuário 4 notas (armazenadas em uma lista).
//    Calcule a média.
//    Use if/else para informar se o aluno está aprovado (média ≥ 7) ou reprovado.

//List<double> notas = new List<double>();

//for (int i = 0; i  < 4 ; i++)
//{
//    Console.WriteLine(" Insira sua nota da prova" + (i + 1) + ":");
//    notas.Add(double.Parse(Console.ReadLine()));
//}

//double somaNotas = 0;

//for (int i = 0;i < notas.Count ; i++)
//{
//    somaNotas += notas[i];

//}

//double media  =  somaNotas / notas.Count;

//if (media >= 7)
//{
//    Console.WriteLine("Aprovado");

//}
//else
//{
//    Console.WriteLine("Reprovado");
//}
int nota = 7;
if (nota >= 9)
    Console.WriteLine("Excelente");
else if (nota >= 7)
    Console.WriteLine("Bom");
else
    
 Console.WriteLine("Precisa melhorar");


