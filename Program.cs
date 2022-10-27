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
int index, num, sum = 0;

for(index = 0; index < 10; index++)
{
    Console.Write("Inserisci un numero: ");
    num = Int32.Parse(Console.ReadLine());
    sum += num;
}
Console.WriteLine("La somma totale è: " + sum);
