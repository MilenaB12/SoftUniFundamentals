int lostGamesCount = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());

int headsetTrashCount = 0;
int mouseTrashCount = 0;
int keyboardTrashCount = 0;
int displayTrashCount = 0;

for (int i = 1; i <= lostGamesCount; i++)
{
    if (i % 2 == 0)
    {
        headsetTrashCount++;
    }
    if (i % 3 == 0)
    {
        mouseTrashCount++;
    }
    if (i % 6 == 0)
    {
        keyboardTrashCount++;
    }
    if (i % 12 == 0)
    {
        displayTrashCount++;
    }
}

double allHeadsetPrice = headsetPrice * headsetTrashCount;
double allMousePrice = mousePrice * mouseTrashCount;
double allKeyboardPrice = keyboardPrice * keyboardTrashCount;
double allDisplayPrice = displayPrice * displayTrashCount;

double totalExpenses = allHeadsetPrice + allMousePrice + allKeyboardPrice + allDisplayPrice;

Console.WriteLine($"Rage expenses: {totalExpenses:F2} lv.");