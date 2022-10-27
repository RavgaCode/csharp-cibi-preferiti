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
Console.Write("Digita un numero ");
int userFirstNumber = Int32.Parse(Console.ReadLine());
Console.Write("Digita un secondo numero ");
int userSecondNumber = Int32.Parse(Console.ReadLine());

if (userFirstNumber > userSecondNumber)
{
    Console.WriteLine("Il numero più grande è: " + userFirstNumber);
} else if(userFirstNumber < userSecondNumber)
{
    Console.WriteLine("Il numero più grande è: " + userSecondNumber);
}
else
{
    Console.WriteLine("I due numeri sono uguali!");
}


