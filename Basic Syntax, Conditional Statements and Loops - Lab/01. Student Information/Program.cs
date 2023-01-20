// See https://aka.ms/new-console-template for more information

string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
double grade = double.Parse(Console.ReadLine());

Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:f2}");
