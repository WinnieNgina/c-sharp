// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
 * Console.WriteLine("What's your name?");
 * string name = Console.ReadLine();
 * Console.WriteLine("How old are you?");
 * string input_age = Console.ReadLine();
 * int age = int.Parse(input_age);
 * Console.WriteLine($"My name is {name} and I'm {age} years old");
*/
Console.WriteLine("Enter number of age");
string num = Console.ReadLine();
int age = int.Parse(num);
List <int> integers = new List <int>();
if (age > 20 && age <= 30)
{
	Console.WriteLine("You are still young");
	integers.Add(age);
}
else if (age <= 20)
{
	Console.WriteLine("You are a teeneger");
	integers.Add(age);
}
else if (age > 30 && age <= 40)
{
	Console.WriteLine("Senior bachelor");
	integers.Add(age);
}
else
{
	Console.WriteLine("You are too old");
	integers.Add(age);
}
for (int i = 0; i < integers.Count; i++ )
{
	Console.WriteLine($"{integers[i]}");
}





