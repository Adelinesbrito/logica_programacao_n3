const string AMARELO = "AMARELO";
const string AZUL = "AZUL";
const string VERDE = "VERDE";

const string MSG_voto = "Qual é o seu voto ( AMARELO , AZUL ou VERDE )";
string voto;

int votosamarelo = 0;
int votosazul = 0;
int votosverde = 0;
int abs = 0;

// votação 

Console.WriteLine(MSG_voto);
voto = Console.ReadLine();

// Apuração 
switch (voto)
{
    case AMARELO:
        votosamarelo++;
        break;

    case AZUL:
        votosazul++;
        break;

    case VERDE:
        votosverde++;
        break;

    default:
        abs++;
        break;
}

// votação 

Console.WriteLine(MSG_voto);
voto = Console.ReadLine();

// Apuração 
switch (voto)
{
    case AMARELO:
        votosamarelo++;
        break;

    case AZUL:
        votosazul++;
        break;

    case VERDE:
        votosverde++;
        break;

    default:
        abs++;
        break;
}

// votação 

Console.WriteLine(MSG_voto);
voto = Console.ReadLine();

// Apuração 
switch (voto)
{
    case AMARELO:
        votosamarelo++;
        break;

    case AZUL:
        votosazul++;
        break;

    case VERDE:
        votosverde++;
        break;

    default:
        abs++;
        break;
}

// votação 

Console.WriteLine(MSG_voto);
voto = Console.ReadLine();

// Apuração 
switch (voto)
{
    case AMARELO:
        votosamarelo++;
        break;

    case AZUL:
        votosazul++;
        break;

    case VERDE:
        votosverde++;
        break;

    default:
        abs++;
        break;
}

// votação 

Console.WriteLine(MSG_voto);
voto = Console.ReadLine();

// Apuração 
switch (voto)
{
    case AMARELO:
        votosamarelo++;
        break;

    case AZUL:
        votosazul++;
        break;

    case VERDE:
        votosverde++;
        break;

    default:
        abs++;
        break;
}

// Resultado 

int vencedor = 0;

if ( vencedor < votosamarelo )
{
    vencedor = votosamarelo;
}

if (vencedor < votosazul  )
{
    vencedor = votosazul;
}

if (vencedor < votosverde )
{
    vencedor =  votosverde ;
}

if (vencedor < abs )
{
    vencedor = abs ;
}


Console.WriteLine("O AMARELO recebeu :" + votosamarelo + " votos");
Console.WriteLine("O AZUL recebeu:" + votosazul + " votos");
Console.WriteLine("O VERDE recebeu:" + votosverde + " votos");
Console.WriteLine("Houve " + abs + " abstenções");

if (vencedor == votosamarelo)
{
    Console.WriteLine("O amarelo é o vencedor.");
}

if (vencedor == votosazul )
{
    Console.WriteLine("O Azul  é o vencedor.");
}

if (vencedor == votosverde)
{
    Console.WriteLine("O Verde é o vencedor.");
}

