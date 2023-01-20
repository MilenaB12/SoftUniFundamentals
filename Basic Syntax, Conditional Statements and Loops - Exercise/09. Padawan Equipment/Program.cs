double allMoney = double.Parse(Console.ReadLine());
int studentsCount = int.Parse(Console.ReadLine());
double lightsaberPerPersonPrice = double.Parse(Console.ReadLine());
double robePerPersonPrice = double.Parse(Console.ReadLine());
double beltPerPersonPrice = double.Parse(Console.ReadLine());

int beltsCount = 0;

for (int i = 1; i <= studentsCount; i++)
{
    if (i % 6 == 0)
    {

    }
    else
    {
        beltsCount++;
    }
}

double lightsabersStudents = Math.Ceiling(studentsCount * 1.10);

double allLightsabersPrice = lightsaberPerPersonPrice * lightsabersStudents;
double robesPrice = robePerPersonPrice * studentsCount;
double beltsPrice = beltPerPersonPrice * beltsCount;

double neededMoney = allLightsabersPrice + robesPrice + beltsPrice;

if (neededMoney <= allMoney)
{
    Console.WriteLine($"The money is enough - it would cost {neededMoney:F2}lv.");
}
else
{
    Console.WriteLine($"John will need {neededMoney - allMoney:F2}lv more.");
}