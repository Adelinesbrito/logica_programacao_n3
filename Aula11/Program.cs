// Notas
// duas notas 
// media

//int[] notas = new int[2];

//Console.WriteLine("Nota p1:");
//notas[0] = int.Parse(Console.ReadLine());

//Console.WriteLine("Nota p2:");
//notas[1] = int.Parse(Console.ReadLine());   

//Console.WriteLine("Nota Final:" + (notas[0] + notas[1] /  2));

//List<int> notas = new List<int>();

//Console.WriteLine("Nota p1:");
//notas.Add( int.Parse(Console.ReadLine()));

//Console.WriteLine(("Nota p2 :");
//notas.Add(int.Parse(Console.ReadLine()));

// filtro de numeros pares



List <int> numeros = new List<int> {1,2,3,4,5,6,7,8,9,10};

for (int i = 0; i < numeros.Count; i++)
{
    int numero = numeros[i];
    if (numero % 2 == 0)
    {
        Console.WriteLine(numero);
    }
}
