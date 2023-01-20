int number = int.Parse(Console.ReadLine());
int copyNumber = number;

int sum = 0;

while(copyNumber > 0)
{ 
    int digit = copyNumber % 10;
    copyNumber /= 10;
    int factorial = 1;

    for (int i = 1; i <= digit; i++)
    {
        factorial *= i;
    }
    sum += factorial;
}

if (number == sum)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}

