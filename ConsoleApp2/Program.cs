// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string Menu()
{
    Console.WriteLine("Vítej ve hře");
    Console.WriteLine("Tady máš možnisti ty chcanko");
    Console.WriteLine("A) Start");
    Console.WriteLine("B) Exit");

    string volba = Console.ReadLine();

    return VerifyVolba(volba);
}

string VerifyVolba(string x)
{
    if (x.ToLower()== "a")
    {
        Start();
    }
    if (x.ToLower() == "b")
    {
        Console.WriteLine("Konec");
    }
    return "true";
}

void Start()
{
    Console.WriteLine("Vítej ve hře");
}

char[] CharToArray(string input)
{
    char[] arr = new char[input.Length];

    for (int i = 0; i < input.Length; i++)
    {
        arr[i] = input[i];
    }
    return arr;
}


bool CharInArray(char[] input)
{

    return true;
    
}

char[] DoubleArray(char[] input)
{
    char[] doubleArr = new char[input.Length];

    return doubleArr;
}

Menu();