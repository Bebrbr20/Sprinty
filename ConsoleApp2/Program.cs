// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Linq;

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
   
    for (int i=1; i==1;)
    {
     if (x.ToLower()== "a")
        {
            Start();
            return "true";
        }
        if (x.ToLower() == "b")
        {
            Console.WriteLine("Konec");
            return "true";
        }
        else
        {
            Console.WriteLine("Tato volba neexistuje!\nVybrete znovu->");
            x = Console.ReadLine();
        }
    }

    return "false";
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



bool CharInArray(char[] input, string xx)
{
    if (Array.IndexOf(input, xx) > -1)
    {
        return true;
    }
    else
    {
        return false;
    }
    
    
}

int ArrayLenght(char[] input)
{
    
}

char[] DoubleArray(char[] input)
{
    char[] doubleArr = new char[input.Length];

    return doubleArr;
}

Menu();