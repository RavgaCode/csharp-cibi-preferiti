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
//int sum=0;
//int average = (10 - 2) / 2;

//for(; index <11; index++)
//{
//    sum += index;

//}
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

int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
int sum = 0;

for (int index = 0; index < numbers.Length; index++)
{
    if (index %2 != 0)
    {
        sum += numbers[index];
    }
}

Console.WriteLine("La somma dei numeri in posizione dispari è: " + sum);