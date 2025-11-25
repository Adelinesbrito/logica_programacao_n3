//Faça um programa que receba um numero e, 
// usando laços de repitção
// Calcule e mostre a tabuaba desse numero.

// nro *1
// nro * 2
// nro * 3

//Console.WriteLine("Insira um número inteiro:");
//string entradaUsuario  = Console.ReadLine();

//bool valido = int.TryParse(entradaUsuario, out int numero);

//if (valido)
//{
//    int contador = 1;
//    while (contador <= 10)
//    {
//        Console.WriteLine(contador + "*" + numero + "=" + (contador * numero));
//        contador++;
//    }
//}
//else
//{
//    Console.WriteLine("O  Valor inserido não é um número inteiro.");
//}

// Validação de Nota: Faça um programa que peça uma nota entre zero e dez.
// Mostre uma mensagem caso o valor seja inválido e
// continue pedindo até que o usuário informe um valor válido.

//bool invalido;
//do
//{
//    Console.WriteLine("Insira sua nota (ENTRE 0 a 10):");

//    string entradausuario = Console.ReadLine();

//    bool valido = int.TryParse(entradausuario, out int nota);

//    invalido = !valido || nota < 0 || nota > 10;

//    if (!valido || nota < 0 || nota > 10)
//    {
//        Console.WriteLine(" Informe uma nota válida");
//    }

//    else
//    {
//        Console.WriteLine(nota + " é uma nota validada.");
//    }
//    Console.WriteLine(" ---- ");

//}  while (invalido);

//bool invalido = true ;
//while (invalido)
//{
//    Console.WriteLine("Insira sua nota (ENTRE 0 a 10):");

//    string entradausuario = Console.ReadLine();

//    bool valido = int.TryParse(entradausuario, out int nota);

//    invalido = !valido || nota < 0 || nota > 10;

//    if (!valido || nota < 0 || nota > 10)
//    {
//        Console.WriteLine(" Informe uma nota válida");
//    }

//    else
//    {
//        Console.WriteLine(nota + " é uma nota validada.");
//    }
//    Console.WriteLine(" ---- ");

//}

// Controle de peso: Faça um programa que receba a idade e o peso de sete pessoas. Calcule e mostre:
//A quantidade de pessoas com mais de 90 quilos;
// A média das idades das sete pessoas;

using System.Reflection.PortableExecutable;

//const int QTD_Pessoas = 7;

//int contadorpessoas90kg = 0;
//int somaidadepessoas = 0;

//string entradausuario;

//for (int contador = 0; contador < QTD_Pessoas; contador++)
//{
//    Console.WriteLine("Insira sua idade");
//    entradausuario = Console.ReadLine();
//    int.TryParse(entradausuario, out int idade);

//    Console.WriteLine("Insira seu peso:");
//    entradausuario = Console.ReadLine();
//    int.TryParse(entradausuario, out int peso);

//    somaidadepessoas += idade;

//    if (peso > 90)
//    {
//        contadorpessoas90kg++;

//    }
//}
//Console.WriteLine("A quantidade de pessoas com mais de 90 Kg é: " + contadorpessoas90kg);
//Console.WriteLine("A média das idades é: " + ( somaidadepessoas / QTD_Pessoas));


