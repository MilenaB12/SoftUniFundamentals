int ordersCount = int.Parse(Console.ReadLine());
double wholePrice = 0;
for (int i = 1; i <= ordersCount; i++)
{
    double pricePerCapsule = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsuleCount = int.Parse(Console.ReadLine());

    double orderPrice = pricePerCapsule * days * capsuleCount;

    Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");

    wholePrice += orderPrice;
}

Console.WriteLine($"Total: ${wholePrice:F2}");