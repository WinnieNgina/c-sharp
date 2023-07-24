// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//try
//{
//	Console.WriteLine("Enter your age?");
//	int Age = int.Parse(Console.ReadLine());
	//int _age = int.Parse(Age);
	//Console.WriteLine($"My age is {Age}");
//}
//catch
//{
//	Console.WriteLine("Invalid Input!!");
//}
void print_str(string str)
{
	Console.WriteLine(str);
}
void ask_input()
{
	Console.WriteLine("Please enter your name?");
	string input = Console.ReadLine();
	print_str(input);
}
ask_input();
