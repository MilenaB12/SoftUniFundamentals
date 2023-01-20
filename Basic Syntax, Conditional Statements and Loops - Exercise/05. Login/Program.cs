string username = Console.ReadLine();
string expectedPassword = new string(username.Reverse().ToArray());
int incorrectTries = 0;

while (true)
{ 
    string password = Console.ReadLine();

    if (password == expectedPassword)
    {
        Console.WriteLine($"User {username} logged in.");
        break;
    }
    else
    {
        incorrectTries++;
        if (incorrectTries == 4)
        {
            Console.WriteLine($"User {username} blocked!");
            break;
        }
        else
        {
            Console.WriteLine("Incorrect password. Try again.");
        }
    }
}


