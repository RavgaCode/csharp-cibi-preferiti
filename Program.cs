// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[] favouriteFoods = { "Pizza", "Risotto ai Funghi", "Pasta alla Carbonara", "Tagliata di Manzo", "Baccalà Mantecatto" };
Console.WriteLine(favouriteFoods.Length);
int index = 0;

for(; index < favouriteFoods.Length; index++)
{
    Console.WriteLine(favouriteFoods[index]);
}
Console.WriteLine(favouriteFoods[0]);
Console.WriteLine(favouriteFoods[favouriteFoods.Length - 1]);
Console.WriteLine(favouriteFoods[favouriteFoods.Length / 2]);