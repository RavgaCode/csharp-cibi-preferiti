// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//string[] favouriteFoods = { "Pizza", "Risotto ai Funghi", "Pasta alla Carbonara", "Tagliata di Manzo", "Baccalà Mantecatto" };
//Console.WriteLine(favouriteFoods.Length);
//int index = 0;

//for(; index < favouriteFoods.Length; index++)
//{
//    Console.WriteLine(index +1 + "-" + favouriteFoods[index]);
//}
//Console.WriteLine(favouriteFoods[0]);
//Console.WriteLine(favouriteFoods[favouriteFoods.Length - 1]);
//Console.WriteLine(favouriteFoods[favouriteFoods.Length / 2]);


//Snack 1
//Console.Write("Digita un numero ");
//int userFirstNumber = Int32.Parse(Console.ReadLine());
//Console.Write("Digita un secondo numero ");
//int userSecondNumber = Int32.Parse(Console.ReadLine());

//if (userFirstNumber > userSecondNumber)
//{
//    Console.WriteLine("Il numero più grande è: " + userFirstNumber);
//} else if(userFirstNumber < userSecondNumber)
//{
//    Console.WriteLine("Il numero più grande è: " + userSecondNumber);
//}
//else
//{
//    Console.WriteLine("I due numeri sono uguali!");
//}


//Snack 2

//Console.Write("Scrivi una parola ");
//string userFirstWord = Console.ReadLine();
//Console.Write("Scrivi una seconda parola ");
//string userSecondWord = Console.ReadLine();
//if(userFirstWord.Length < userSecondWord.Length)
//{
//    Console.WriteLine("La parola più corta è: " + userFirstWord);
//    Console.WriteLine("La parola più lunga è: " + userSecondWord);
//} else if(userFirstWord.Length > userSecondWord.Length)
//{
//    Console.WriteLine("La parola più corta è: " + userSecondWord);
//    Console.WriteLine("La parola più lunga è: " + userFirstWord);
//}
//else
//{
//    Console.WriteLine("Le due parole {0} e {1} sono di uguale lunghezza", userFirstWord, userSecondWord);
//}

//Snack 3
//int index, num, sum = 0;

//for(index = 0; index < 10; index++)
//{
//    Console.Write("Inserisci un numero: ");
//    num = Int32.Parse(Console.ReadLine());
//    sum += num;
//}
//Console.WriteLine("La somma totale è: " + sum);

//Snack 4

//int index = 2;
//int sum = 0;


//for (; index < 11; index++)
//{
//    sum += index;

//}
//int average = sum / 9;
//Console.WriteLine("La somma dei numeri da 2 a 10 è: " + sum);
//Console.WriteLine("La media dei numeri da 2 a 10 è: " + average);

//Snack 5

//Console.Write("Digita un numero ");
//int userNumber = Int32.Parse(Console.ReadLine());

//if (userNumber % 2 == 0)
//{
//    Console.WriteLine("Il numero {0} è pari", userNumber);
//} else if (userNumber % 2 != 0)
//{
//    Console.WriteLine("Il numero {0} non è pari. Il seguente numero {1} è pari", userNumber, userNumber + 1);
//}

//Snack 6

//string[] invitedPeople = { "Gianni", "Piero", "Antonio" };
//Console.Write("Come ti chiami? ");
//string userName = Console.ReadLine();
//if (invitedPeople.Contains(userName))
//{
//    Console.WriteLine("Ottimo, Gatsby ti ha invitato!");
//} else
//{
//    Console.WriteLine("Mi spiace, Gatsby non ti ha invitato");
//}

//Snack 7
//int n = 10;
//int[] numbers = new int[n];

//for (int index = 0; index < n; index++)
//{
//    Console.Write("Digita un numero: ");
//    int newNumber = Int32.Parse(Console.ReadLine());
//    if(newNumber %2 != 0)
//    {
//        numbers[index] = newNumber;
//    }  
//}

//Console.WriteLine(String.Join(",", numbers));

//Snack 8

//int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
//int sum = 0;

//for (int index = 0; index < numbers.Length; index++)
//{
//    if (index %2 != 0)
//    {
//        sum += numbers[index];
//    }
//}

//Console.WriteLine("La somma dei numeri in posizione dispari è: " + sum);

//Snack 9

//int[] numbers = new int[50];

//int sum = 0;

//while (sum < 50)
//{
//    Console.Write("Digita un numero intero: ");
//    int userNumber = Int32.Parse(Console.ReadLine());
//    if (userNumber != 0)
//    {
//        sum += userNumber;
//    }
//}

//Console.WriteLine("Stop, la somma di tutti i numeri digitati è superiore a 50!!");

//Snack 10

//Console.Write("Quanti array vuoi creare? ");

//int numberOfArrayToGenerate = Int32.Parse(Console.ReadLine());

//for(int index = 0; index < numberOfArrayToGenerate; index++)
//{
//    int[] arrayToPrint = new int[10];
//    for(int y = 0; y < 10; y++)
//    {
//        Random rand = new Random();
//        int randomNumber = rand.Next(1,100);
//        arrayToPrint[y] = randomNumber;
//    }
//    Console.WriteLine(String.Join(",", arrayToPrint));
//}

//Snack 11
//Dare la possibilità di inserire due parole.
//Verificare tramite una funzione che le due parole abbiano la stessa lunghezza.
//Se hanno la stessa lunghezza, stamparle entrambe, altrimenti stampare la più lunga delle due. (stampare fuori dalla funzione)

string stringLengthCheck (string word1, string word2)
{
    if(word1.Length > word2.Length)
    {
        return word1;
    } else if (word1.Length < word2.Length)
    {
        return word2;
    } else
    {
        return word1 + "" + word2;
    }
}

Console.Write("Digita una parola: ");
string userWord1 = Console.ReadLine();
Console.Write("Digita una seconda parola: ");
string userWord2 = Console.ReadLine();
string result = stringLengthCheck(userWord1,userWord2);
Console.WriteLine("La parola più lunga è: " + result);
