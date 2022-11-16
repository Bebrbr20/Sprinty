// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



using System.Collections.Generic;
using System.IO;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

int pocetHer = 0;
int zivoty = 1;
string jmeno = "";

bool akl = true;

void Menu()
        {
            Console.WriteLine("Vítej ve hře");
            
            Console.WriteLine("A) Start");
            Console.WriteLine("B) Leaderboard");
            Console.Write("N) Ukončit hru\n\n->");

            string volba = Console.ReadLine();

            VerifyVolba(volba);
        }

        string VerifyVolba(string x)
        {
       

    for (int i = 1; i == 1;)
            {
                if (x.ToLower() == "a")
                {
                    Start();
                    return "true";
                }
                else if (x.ToLower() == "b")
                {
                    DisplayLeaderboard();
                    return "true";
        }
                else if (x.ToLower() == "n")
                {

                    akl = false;
                    return "konec";
                }
                else
                {
                    Console.WriteLine("Tato volba neexistuje!\nVybrete znovu->");
                    x = Console.ReadLine();
                }
            }

            return "false";
        }

        char[] VerifyVolbaX(string x)
        {
        if (zivoty == 0)
        {

            pocetHer = 0;
        zivoty = 1;
        }
    char[] stringos;
            for (int i = 1; i == 1;)
            {
                if (x.ToLower() == "e")
                {
            if (pocetHer == 0 && zivoty > 0)
            {
                zivoty = 5;
            }
                    stringos = Easy();
                    return stringos;
                }
                if (x.ToLower() == "h")
                {
            if (pocetHer == 0 && zivoty > 0)
            {
                zivoty = 3;
            }
            stringos = Hard();

                    return stringos;
                }

                else
                {
                    Console.WriteLine("Tato volba neexistuje!\nVybrete znovu->");
                    x = Console.ReadLine();
                }
            }

            stringos = Easy();
            return stringos;
        }


void Start()
{
    Console.WriteLine("Vítej ve hře");
    Console.WriteLine("Vyberte obtížnost hry");
    Console.WriteLine("(E)asy");
    Console.Write("(H)ard\n\n->");

    string volba = Console.ReadLine();
    char[] arr;
    arr = VerifyVolbaX(volba);

    int lenght = ArrayLenght(arr);
    char[] progress = new char[lenght];

    for (int i = 0; i < lenght; i++)
    {
        progress[i] = '_';
    }

    char[] userInput = new char[30];
    int pokus = 0;
    bool status = true;
    while (status == true && zivoty >= 1)
    {
        foreach (char s in progress)
        {
            Console.Write(s + " ");
        }

        char input = VerifyInput();
        
        if (CharInArray(arr, input) == true && CharInArray(userInput, input) == false)
        {
            for (int j = 0; j < arr.Length; j++)
                    {
                        if (input == arr[j])
                            progress[j] = input;
                    }
        }
        else if (CharInArray(userInput, input) == true)
        {
            Console.WriteLine("Tento znak jste již zadali!");
        }
        else
        {
            zivoty--;
            Console.WriteLine("Tento znak se zde nenachází!");
            Console.WriteLine("Máte " + zivoty + " životů !\n");
        }

        if(Enumerable.SequenceEqual(arr, progress))
        {
            status = false;
            pocetHer++;
            Console.Write("Slovo bylo ");
            foreach (char s in progress)
            {
                Console.Write(s );
            }

            Console.WriteLine("\nVyhrál jsi!");
        }
        if(zivoty == 0)
        {
            Console.Write("\nUmřel jsi!\n\nSlovo bylo ");
            foreach (char s in arr)
            {
                Console.Write(s);
            }
        }
        userInput[pokus] = input;
        pokus++;

        
    }
}

    char[] Easy()
    {
        string[] words = System.IO.File.ReadAllLines(@"../../../wordList.txt");
        Random random = new Random();
        int start = random.Next(0, words.Length);
        string slovo = words[start];
        char[] arr = CharToArray(slovo);

        return arr;
}

    char[] Hard()
    {

        string[] words = System.IO.File.ReadAllLines(@"../../../wordListHard.txt");
        Random random = new Random();
        int start = random.Next(0, words.Length);
        string slovo = words[start];
        char[] arr = CharToArray(slovo);

        return arr;
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



    bool CharInArray(char[] input, char xx)
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

    char VerifyInput()
{
    Console.Write("\n->");
    string input = "nnn";

    while (true)
    {
        input = Console.ReadLine();
        if (input.Length != 1)
        {
            Console.Write("\nChyba! Napište pouze jedno písmeno! ->");

        }
        else
        {
            return input[0];
        }
    }
    
}
bool writeToLeaderboard(string jmeno, int pocet)
{
    string newFileName = "../../../leaderboard.csv";

    string clientDetails = jmeno + "," + pocet + Environment.NewLine;


    if (!File.Exists(newFileName))
    {
        
        File.WriteAllText(newFileName, clientDetails);
        File.AppendAllText(newFileName, clientDetails);
    }
    else
    {
        File.AppendAllText(newFileName, clientDetails);
    }

    
    return true;
}

void DisplayLeaderboard()
{
    string[] leaderbord = System.IO.File.ReadAllLines(@"../../../leaderboard.csv");
    List<int> poradi = new List<int>();
    foreach (string s in leaderbord)
    {
        char lastCharacter = s[s.Length - 1];
        poradi.Add(lastCharacter);
        
    }
    foreach (char item in poradi)
    {
        //Console.WriteLine(item);
    }
    foreach (string item in leaderbord)
    {
        Console.WriteLine(item);

    }
    Console.WriteLine("Stiskněte libovolnou klávesu pro ukončení\n\n->");
    Console.ReadLine();
    akl = false;
    
}



Menu();

while (akl == true)
{


    
        Console.WriteLine("\nChcete hru zopakovat?");
        Console.WriteLine("A) Ano");
        Console.WriteLine("N) Ne, ukončit hru\n\n->");
        string volba = Console.ReadLine();
        string result = VerifyVolba(volba);
        if (result == "konec")
        {
            akl = false;
            bool score = false;
            while (score == false)
            {
                Console.WriteLine("\nChcete zeznamenat vaše skóre? (" + pocetHer + ")\nA) ano\nB) stiskem jakéhokoliv jiného písmena klávesy hru ukončíte...\n\n");
                char vlba = VerifyInput();
                if (vlba == 'a' || vlba == 'A')
                {
                    Console.Write("Zadejte vaše jméno\n->");
                    string player = Console.ReadLine();
                writeToLeaderboard(player, pocetHer);
                score = true;
                    
                }
                else
                {
                    score = true;
                }
            }
        }
    
    
    
}
