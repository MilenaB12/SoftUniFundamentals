using System.Runtime.Intrinsics.X86;

decimal allCoins = 0m;

while (true)
{
    string command = Console.ReadLine();

    if (command == "Start")
    {
        break;
    }

    decimal coin = decimal.Parse(command);

    if (coin == 0.1m || coin == 0.2m || coin == 0.5m || coin == 1m || coin == 2m)
    {
            allCoins += coin;
    }
    else
    {
        Console.WriteLine($"Cannot accept {coin}");
    }
}
while (true)
{
    string input = Console.ReadLine();

    if (input == "End")
    {
        break;
    }

    if (input == "Nuts")
    {
        if (allCoins >= 2.0m)
        {
            Console.WriteLine("Purchased nuts");
            allCoins -= 2m;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (input == "Water")
    {
        if (allCoins >= 0.7m)
        {
            Console.WriteLine("Purchased water");
            allCoins -= 0.7m;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (input == "Crisps")
    {
        if (allCoins >= 1.5m)
        {
            Console.WriteLine("Purchased crisps");
            allCoins -= 1.5m;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (input == "Soda")
    {
        if (allCoins >= 0.80m)
        {
            Console.WriteLine("Purchased soda");
            allCoins -= 0.80m;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (input == "Coke")
    {
        if (allCoins >= 1.0m)
        {
            Console.WriteLine("Purchased coke");
            allCoins -= 1.0m;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else
    {
        Console.WriteLine("Invalid product");
    }
}

Console.WriteLine($"Change: {allCoins:F2}");