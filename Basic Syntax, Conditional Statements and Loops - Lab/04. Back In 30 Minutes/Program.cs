int hour = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

int currentMinutes = minutes + 30;
if (currentMinutes >= 60)
{
    hour++;
    currentMinutes -= 60;
}
if (hour > 23)
{
    hour = 0;
}

Console.WriteLine($"{hour}:{currentMinutes:d2}");