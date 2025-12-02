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