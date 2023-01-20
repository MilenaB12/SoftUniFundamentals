int peopleCount = int.Parse(Console.ReadLine());
string typeOfGroup = Console.ReadLine();
string day = Console.ReadLine();
double pricePerPerson = 0;

if (day == "Friday")
{
    if (typeOfGroup == "Students")
    {
        pricePerPerson = 8.45;
    }
    else if (typeOfGroup == "Business")
    {
        pricePerPerson = 10.90;
    }
    else if (typeOfGroup == "Regular")
    {
        pricePerPerson = 15;
    }
}
else if (day == "Saturday")
{
    if (typeOfGroup == "Students")
    {
        pricePerPerson = 9.80;
    }
    else if (typeOfGroup == "Business")
    {
        pricePerPerson = 15.60;
    }
    else if (typeOfGroup == "Regular")
    {
        pricePerPerson = 20;
    }
}
else if (day == "Sunday")
{
    if (typeOfGroup == "Students")
    {
        pricePerPerson = 10.46;
    }
    else if (typeOfGroup == "Business")
    {
        pricePerPerson = 16;
    }
    else if (typeOfGroup == "Regular")
    {
        pricePerPerson = 22.50;
    }
}

if (typeOfGroup == "Business" && peopleCount >= 100)
{
    peopleCount -= 10;
}

double totalPrice = pricePerPerson * peopleCount;

if (typeOfGroup == "Students" && peopleCount >= 30)
{
    totalPrice *= 0.85;
}

if (typeOfGroup == "Regular" && peopleCount >= 10 && peopleCount <= 20)
{
    totalPrice *= 0.95;
}

Console.WriteLine($"Total price: {totalPrice:F2}");
