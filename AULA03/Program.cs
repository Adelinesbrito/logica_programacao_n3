// See https://aka.ms/new-console-template for more information
//double x = 1;
//int y = 1;  
//int z = 2;  

//double resultado = ((x + y) * z) / 3;

//Console.WriteLine("Hello, World!");
//Console.WriteLine("Olá, mundo !");
//Console.WriteLine(resultado);

//Console.WriteLine("\n ---- \n");
//string nome = "Adelines";
//string sobrenome = "Brito";
//Console.WriteLine( nome + sobrenome );

//char letraA = 'á';
//char letraB = '1';    
//Console.WriteLine( letraA + 0 );
//Console.WriteLine(letraB + 0 );

//Console.WriteLine("\n ---- \n");


//Console.WriteLine( " Qual é o seu nome ?" );
//string nomeUsuario = Console.ReadLine();

//Console.WriteLine( nomeUsuario );
//Console.WriteLine("O seu nome é :" + nomeUsuario );

//Console.WriteLine("em qual ano vc nasceu ?");
//string anonascimentousuariostring = Console.ReadLine();
//int idadeusuario = 2025 - int.Parse( anonascimentousuariostring );
//Console.WriteLine("o seu nome é " + idadeusuario);//

//Peça para o usuário inserir dois números inteiros e mostre-os no Console.//

Console.WriteLine("\n --------------- \n");
int n1;
int n2;

Console.WriteLine("Insirar um número inteiro:");

n1 = int.Parse (Console.ReadLine());

Console.WriteLine("O numero escolhido é " +  n1);

Console.WriteLine("Insirar outro um número inteiro :");

n2  = int.Parse(Console.ReadLine());

Console.WriteLine("O numero escolhido é " + n2);

// Peça para o usuário inserir dois números inteiros, mostre a soma dos números informados no Console//

Console.WriteLine("\n --------------- \n");

// somatoria//
int n3;
int n4;

Console.WriteLine("Insirar um número inteiro :");

n3 = int.Parse(Console.ReadLine());

Console.WriteLine("O numero escolhido é " + n3);

Console.WriteLine("Insirar outro um números inteiros :");

n4 = int.Parse(Console.ReadLine());

Console.WriteLine("O numero escolhido é " + n4);


int resultadosoma = n3 + n4;

Console.WriteLine("soma é  " + resultadosoma);

// Peça para o usuário inserir dois números inteiros, mostre a subtração dos números//

Console.WriteLine("Insirar um número inteiro :");

int n5 = int.Parse(Console.ReadLine());

Console.WriteLine("Insirar um número inteiro :");

int n6 = int.Parse(Console.ReadLine());

Console.WriteLine( " o valor da subtração é :" + (n5-n6));


Console.WriteLine("\n --------------- \n");

//Peça para o usuário inserir dois números inteiros, mostre a multiplicação dos números informados no Console.

Console.WriteLine("Insirar outro um números inteiros :");
int n7  = int.Parse(Console.ReadLine());
Console.WriteLine("Insirar outro um números inteiros :");
int n8= int.Parse(Console.ReadLine());
Console.WriteLine(" o valor da multiplicação é :" + (n7 * n8));


Console.WriteLine("\n --------------- \n");

//Peça para o usuário inserir dois números inteiros, mostre a divisão dos números informados no Console (Cuidado com o tipo na hora de mostrar o resultado).


Console.WriteLine("Insirar outro um números inteiros :");
int n9 = double.Parse(Console.ReadLine());
Console.WriteLine("Insirar outro um números inteiros :");
int n10 = double.Parse (Console.ReadLine());

double divisao = n9 / n10;

Console.WriteLine(" o valor da divisão é :" + divisao );
