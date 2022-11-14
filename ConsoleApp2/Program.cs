// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Linq;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;




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
    Easy();
}

void Easy()
{
    
    string[] words = System.IO.File.ReadAllLines(@"../../../wordList.txt");
    Random random = new Random();
    int start = random.Next(0, words.Length);
    string slovo = words[start];
    char[] arr = CharToArray(slovo);
    int lenght = ArrayLenght(arr);
    string[] progress = new string[lenght];
    
    for (int i = 0; i < lenght; i++)
    {
        progress[i] = "_";
    }

   foreach (string s in progress) 
    {
        Console.Write(s + " "); 
    }

    Console.Write("\nPísmeno ->");
    bool result = CharInArray(arr, Console.ReadLine());
    Console.WriteLine(result);
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
    return input.Length;
}

char[] DoubleArray(char[] input)
{
    char[] doubleArr = new char[input.Length];

    return doubleArr;
}




Menu();