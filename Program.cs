// The C Sharp Player's Guide: Part One

// Thing Namer 3000
void ThingNamer3000()
{
// changed variable names to make it better
// also took out non-user input str variables
    Console.WriteLine("What kind of thing are we talking about?");
    string? thing = Console.ReadLine(); // noun
    Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
    string? desc = Console.ReadLine(); // adjective
    Console.WriteLine("The " + desc + " " + thing + " of Doom 3000!");
}

// The Variable Shop
void TheVariableShop()
{
// string + char
    string str = "i am a string!";
    str = "changed!";
    Console.WriteLine(str);
    char c = 'a';
    c = 'w';
    Console.WriteLine(c);

    // numbers
    int num = 0;
    num++;
    Console.WriteLine((num).ToString());
    uint num2 = 0;
    num2++;
    Console.WriteLine((num2).ToString());
    byte byteNum = 0;
    byteNum = 3;
    Console.WriteLine(byteNum);
    sbyte sbyteNum = 0;
    sbyteNum = 4;
    Console.WriteLine(sbyteNum);
    short shortNum = 0;
    shortNum = 5;
    Console.WriteLine((shortNum).ToString());
    ushort ushortNum = 0;
    ushortNum = 6;
    Console.WriteLine((ushortNum).ToString());
    long longNum = 0;
    longNum = 78;
    Console.WriteLine((longNum).ToString());
    ulong ulongNum = 0;
    ulongNum = 77;
    Console.WriteLine((ulongNum).ToString());


    // real numbers
    float floatNum = 0;
    floatNum = 1.2f;
    Console.WriteLine(floatNum);
    double doubleNum = 0;
    doubleNum = 1.2;
    Console.WriteLine(doubleNum);
    decimal decimalNum = 0;
    decimalNum = 1.2m;
    Console.WriteLine(decimalNum);

    // bool
    bool boolNum = false;
    boolNum = true;
    Console.WriteLine((boolNum).ToString());
}

// The Triangle Farmer
void TheTriangleFarmer()
{
    Console.Write("Heya P-Thag! Let's get those areas calculated\nWhat's the base of the tri-guy? _\n> ");
    double b = double.Parse(Console.ReadLine());
    Console.Write("Aaaand the height? _\n> ");
    double h = double.Parse(Console.ReadLine());
    Console.WriteLine("She's a chunky boy alright. Okay, let me do my magic.");
    double area = (b * h) / 2;
    Console.WriteLine("The area is " + area + "\n(Hold for applause)");
}

// The Four Sisters and the DuckBear
void FourSistersAndTheDuckBear()
{
    Console.Write("Ladies, ladies...let's be civil. What was your harvest? _\n> ");
    int harvest = int.Parse(Console.ReadLine());
    int duckbear = harvest % 4;
    int sisters = harvest / 4;

    Console.WriteLine($"All's fair in our chocolate program. The sisters get {sisters} and duckbear gets {duckbear}.");
// duckbear gets more than sisters if <= 3, 6,7, 11
}

// Dominion of Kings
// 1 point per estate, 3 per duchy, and 6 per province
void DominionOfKings()
{
    Console.Write("Who will have the greatest kingdom in all the land? Will it be you? Let's find out!\nEnter your estates: _\n> ");
    int estates = int.Parse(Console.ReadLine());
    Console.Write("Enter your duchies: _\n> ");
    int duchies = int.Parse(Console.ReadLine());
    Console.Write("Enter your providences: _\n> ");
    int providences = int.Parse(Console.ReadLine());
    int points = estates + (3 * duchies) + (6 * providences);
    Console.WriteLine($"Your points total to {points}, King. Congrats on your fine kingdom.");
}
// Console.WriteLine(@"this is a verbatim string literal");

// Defense of Consolas
void DefenseOfConsolas()
{
    Console.Title = "Defense of Consolas";
    Console.Write("Enter the target row: _\n> ");
    int row = int.Parse(Console.ReadLine());
    Console.Write("Enter the target column: _\n> ");
    int col = int.Parse(Console.ReadLine());
    Console.Write("Deploy to:\n" +
                  $"({row}, {col-1})\n({row-1}, {col})\n({row}, {col+1})\n({row+1}, {col})\n");
    Console.Beep();
}

// Repairing the Clock Tower
void Clocktower()
{
    int num = AskForNumber("What number you see, Oh Great Mouse?");
    if (num % 2 == 0)
        Console.WriteLine("Tick");
    else
        Console.WriteLine("Tock");
}

// Watchtower
void Watchtower()
{
    Console.Write("Enter the x coordinate: _\n> ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Enter the y coordinate: _\n> ");
    int y = int.Parse(Console.ReadLine());
    string relativeLocation = "";
    if (x < 0 && y < 0)
        relativeLocation = "southwest";
    else if (x == 0 && y < 0)
        relativeLocation = "south";
    else if (x > 0 && y < 0)
        relativeLocation = "southwest";
    else if (x < 0 && y == 0)
        relativeLocation = "east";
    else if (x == 0 && y == 0)
        relativeLocation = "here";
    else if (x > 0 && y == 0)
        relativeLocation = "west";
    else if (x < 0 && y > 0)
        relativeLocation = "northeast";
    else if (x == 0 && y > 0)
        relativeLocation = "north";
    else
        relativeLocation = "northwest";

    Console.WriteLine($"{char.ToUpper(relativeLocation[0]) + relativeLocation.Substring(1)}! " +
                      $"{char.ToUpper(relativeLocation[0]) + relativeLocation.Substring(1)}! " +
                      $"The enemy is {relativeLocation}!");
}

// Inventory
void Inventory()
{
    Console.Write("Welcome to the Outfitters, your one stop shop for everything adventuring!\n" +
                  "1 - Rope\n" +
                  "2 - Torches\n" +
                  "3 - Climbing Equipment\n" +
                  "4 - Clean Water\n" +
                  "5 - Machete\n" +
                  "6 - Canoe\n" +
                  "7 - Food Supplies\n" +
                  " Choose your selection from the list below. _\n> ");
    int selection = int.Parse(Console.ReadLine());
    Console.Write($"Excellent. Looking up the market rate for your selection: {selection}\n");
// Rope: 10 gold, Torches: 15 gold, Climbing Equipment: 25 gold, Clean Water: 1 gold, Machete: 20 gold, Canoe: 200 gold, Food Supplies: 1 gold.
    string price = selection switch
    {
        1 => "Ropes are 10 g/ea.",
        2 => "Torches are 15 g/ea.",
        3 => "Climbing Equipment is 25 g/ea.",
        4 => "Clean Water is 1 g/bottle.",
        5 => "Machetes are 20 g/ea.",
        6 => "Canoes are 200g/ea.",
        7 => "Food Supplies are 1 g/ea",
        _ => "This item is out of stock."
    };

    Console.WriteLine("- " + price);
}

// Inventory w/ a Discount
void InventoryWithADiscount()
{
    Console.Write("Welcome to Tortuga's Outfitter Shoppe, your one stop spot for everything adventuring! Mind if we getcha name? _\n> ");
    string? name = Console.ReadLine();
    bool discount = name == "xeal";
    double applyDiscount = discount ? 0.5 : 1.0;
    Console.Write("A beautiful name for beloved customer.\nNow, here are our available items." +
                  "1 - Rope\n" +
                  "2 - Torches\n" +
                  "3 - Climbing Equipment\n" +
                  "4 - Clean Water\n" +
                  "5 - Machete\n" +
                  "6 - Canoe\n" +
                  "7 - Food Supplies\n" +
                  "Choose your selection from the list above. _\n> ");
    int choice = Convert.ToInt32(Console.ReadLine());
    string item;
    int cost;
    switch (choice)
    {
        case 1:
            item = "Rope";
            cost = 10;
            break;
        case 2:
            item = "Torches";
            cost = 15;
            break;
        case 3:
            item = "Climbing Equipment";
            cost = 25;
            break;
        case 4:
            item = "Clean Water";
            cost = 1;
            break;
        case 5:
            item = "Machete";
            cost = 20;
            break;
        case 6:
            item = "Canoe";
            cost = 200;
            break;
        case 7:
            item = "Food Supplies";
            cost = 1;
            break;
        default:
            item = "Something Out of Stock";
            cost = 0;
            break;
    }

    Console.WriteLine($"You selected {item}. Your price will be {cost * applyDiscount} gold. \nYou can always count on Tortuga's Outfitter Shop for the best prices.");
}

// The Prototype
void Prototype()
{
    Console.Write("User One, please report to Console _\n> ");
    Console.ReadKey();
    Console.WriteLine("\nGreat, let us begin.");
    int secretNumber = AskForNumberInRange("Please enter a number between one (1) and one hundred (100).\nFor example, 1, 2, skip a few, 99, 100.", 1, 100);
    Console.Clear();

    Console.Write("User Two, please report to Console _\n> ");
    Console.ReadKey();
    Console.WriteLine("Alright, User One picked a number between 1 and 100. Your job is to guess it. Don't worry. I'll nudge you in the right direction. :)");
    int guess;
    do
    {
        Console.Write("What's your guess? _\n> ");
        guess = int.Parse(Console.ReadLine());
        if (guess > secretNumber)
            Console.WriteLine("Oop, too high");
        else if (guess < secretNumber)
            Console.WriteLine("Oop, too low");
    } while (guess != secretNumber);
    Console.WriteLine("Nice, you got the right number. Congrats!");
}

// The Magic Cannon ✨
void TheMagicCannon()
{
    for (int i = 1; i <= 100; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{i}; Electric & Fire Combo");
        }
        else if (i % 3 == 0 && i % 5 != 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{i}; Fire");
        }
        else if (i % 3 != 0 && i % 5 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{i}; Electric");
        }
        else
        {
            Console.ResetColor();
            Console.WriteLine($"{i}; Normal");
        }
    }
}

// The Really Boring One
void Boring()
{
    int[] firstArray = new int[5];
    for (int i = 0; i < 5; i++)
    {
        Console.Write("Pick a number, any number... _\n> ");
        firstArray[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine(" First Array complete!\nCopying values into second array...");
    int[] secondArray = firstArray;

    Console.WriteLine("Done! Here are your copies.\n");
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"{firstArray[i]} | {secondArray[i]}");
    }
}

// The Laws of Freach
void LawsOfFreach()
{
    int[] dummmy = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
    int currentSmallest = int.MaxValue; // Start higher than anything in the array.
    foreach (int dum in dummmy)
    {
        if (dum < currentSmallest)
            currentSmallest = dum;
    }
    Console.WriteLine("smallest value in dummy is ... " + currentSmallest);

    int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
    int total = 0;
    foreach (int num in array)
    {
        total += num;
    }
    float average = (float)total / array.Length;
    Console.WriteLine("the average value in array is... " + average);

}

// Ask For Number
int AskForNumber(string text)
{
    Console.Write(text + " _\n> ");
    return int.Parse(Console.ReadLine());
}

// Ask For Number In Range
int AskForNumberInRange(string text, int min, int max)
{
    int num;
    do
    {
        Console.Write(text + " _\n> ");
        num = int.Parse(Console.ReadLine());
        if (num < min)
        {
            Console.WriteLine("Oop! Too low.");
        }
        else if (num > max)
        {
            Console.WriteLine("Oop! Too high.");
        }
    } while (num < min || num > max);
    Console.WriteLine($"Input of [{num}] accepted.");
    return num;
}

// Countdown 
void Countdown(int curr)
{
    if (curr == 1)
    {
        Console.WriteLine("Aaaaand 1! Countdown complete");
    }
    else
    {
        Console.WriteLine(curr);
        Countdown(curr - 1);
    }
}

// Hunting The Manticore
int CannonBlast(int round)
{
    if (round % 3 == 0 && round % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Electric & Fire Combo");
        return 10;
    }
    else if (round % 3 == 0 && round % 5 != 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Fire");
        return 3;
    }
    else if (round % 3 != 0 && round % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Electric");
        return 5; // changed to 5 bc it makes more sense to me
    }
    else
    {
        Console.ResetColor();
        Console.WriteLine($"Normal");
        return 1;
    }
}

void HuntingTheManticore()
{
    // setup
    int manticore = 10;
    int city = 15;
    int round = 1;
    Console.Write("User 1, press any key to report to console. _\n> ");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Great. Welcome User 1. Where would you like to place the cannon?");
    int position = AskForNumberInRange("Choose between one (1) and one hundred (100). For example, 1, 2, skip a few, 99, 100.", 1, 100);
    Console.Clear();
    
    Console.Write("User 2, please press any key to report to console._\n> ");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Excellent. Let us take down the manticore.\n______\n");
    int damage;
    int cannonRange;
    do
    {
        // report status
        Console.WriteLine($"STATUS: Round: {round}\t| City: {city}/15\t| Manticore: {manticore}/10");
        // report damage of the cannon based on round
        damage = CannonBlast(round);
        Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");
        Console.ResetColor();
        // get user 2 input of distance
        cannonRange = AskForNumberInRange("User 2, enter your desired cannon range.", 1, 100);
        // report position relative to user 1's guess
        Console.Clear();
        if (cannonRange > position)
        {
            Console.WriteLine("That round OVERSHOT the target.");
            city--;
        }
        else if (cannonRange == position)
        {
            Console.WriteLine("That round was a DIRECT HIT!");
            manticore -= damage;
            city--;
        }
        else
        {
            Console.WriteLine("That round FELL SHORT of the target.");
            city--;
        }
        round++;
        Console.WriteLine("_______");
    } while (manticore > 0 && city > 0);

    if (city == 0)
    {
        Console.WriteLine("What a horrible fate has befallen the land of Consolas. May we all recover from this great loss in haste.");
    }
    else
    {
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved.");
    }
    // option to replay
    Console.WriteLine("(Wanna play again? y/n)");
    if (Console.ReadKey().Key == ConsoleKey.Y)
    {
        Console.Clear();
        HuntingTheManticore();
    }
    Console.WriteLine("Thanks for valiant effort!");
}

// Part Two