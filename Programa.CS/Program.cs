//  Escrevendo no console uma string pedindo a idade do usuario
Console.WriteLine("Qual sua idade ?");

// Ler a resposta do usuario
string resposta = Console.ReadLine();

bool ehvalido = int.TryParse( resposta, out int idade);

// verificar se a tentativa de parse funcionou 

if (ehvalido)
{
    // verificar se  idade é maior ou iguao a 18
  
   if (idade >= 18)
    {
        Console.WriteLine("Usuario é maior de idade.");

    }
   // verificar se a idade é validade  

    else if (idade < 0)
    {
        Console.WriteLine("Idade inválida!");
    }
   // se for validad e menor 18
    else
    {
        Console.WriteLine("Usuario é menor de idade.");
    }
}
else
    Console.WriteLine("Valor informado não corresponde a um numero inteiro");