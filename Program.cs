using System.Globalization;

Random rnd = new Random();

Console.WriteLine("Játékszabály: ");
Console.WriteLine("\nAz olló elvágja a papírt.\r\n" +
    "A papír bevonja a követ.\r\n" +
    "A kő agyonüti a gyíkot.\r\n" +
    "A gyík megmarja Spockot,\r\n" +
    "Spock eltöri az ollót.\r\n" +
    "Az olló lefejezi a gyíkot,\r\n" +
    "a gyík megeszi a papírt,\r\n" +
    "a papír cáfolja Spockot,\r\n" +
    "Spock feloldja a követ,\r\n" +
    "és mint általában, a kő eltöri az ollót.");
Console.WriteLine("\nA gép ellen fogsz játszani, aki előbb gyűjt 3 pontot, az nyer! ");

Kerdes:
Console.WriteLine("\nSikerült megérteni a játékszabályokat? (Igen-nel válaszolj)!");
string answ = Console.ReadLine();
string answ2 = answ.ToLower();

if (answ2 == "igen")
{
    Console.Clear();
}
else
{
    Console.WriteLine("nem jó választ adtál te majom!");
    goto Kerdes;
}

string[] options = { "kő", "papír", "olló", "gyík", "Spock" };

int player_points = 0;
int oponent_points = 0;



while (player_points < 3 || oponent_points < 3)
{
    Console.WriteLine("Mit szeretnél mutatni?(választható lehetőségek: kő; papír; olló; gyík; Spock) ");
    string player_shows = Console.ReadLine();
    int array_index = rnd.Next(5);
    string oponent_shows = options[array_index];
    Console.WriteLine($"az ellenfél mutat: {oponent_shows}");

    //Játék szabályok
    if (player_shows == "kő")
    {
        if (oponent_shows == "olló" || oponent_shows == "gyík")
        {
            player_points++;
            Console.WriteLine("Ezt a kört te nyerted!");
        }
        if (oponent_shows == "Spock" || oponent_shows == "papír")
        {
            oponent_points++;
            Console.WriteLine("Ezt a kört veszteted :c");
        }
        if (oponent_shows == player_shows)
        {
            Console.WriteLine("döntetlen!");
        }

    }

    if (player_shows == "olló")
    {
        if (oponent_shows == "papír" || oponent_shows == "gyík")
        {
            player_points++;
            Console.WriteLine("Ezt a kört te nyerted!");
        }
        if (oponent_shows == "kő" || oponent_shows == "Spock")
        {
            oponent_points++;
            Console.WriteLine("Ezt a kört veszteted :c");
        }
        if (oponent_shows == player_shows)
        {
            Console.WriteLine("döntetlen!");
        }

    }

    if (player_shows == "papír")
    {
        if (oponent_shows == "kő" || oponent_shows == "Spock")
        {
            player_points++;
            Console.WriteLine("Ezt a kört te nyerted!");
        }
        if (oponent_shows == "olló" || oponent_shows == "gyík")
        {
            oponent_points++;
            Console.WriteLine("Ezt a kört veszteted :c");
        }
        if (oponent_shows == player_shows)
        {
            Console.WriteLine("döntetlen!");
        }

    }

    if (player_shows == "gyík")
    {
        if (oponent_shows == "papír" || oponent_shows == "Spock")
        {
            player_points++;
            Console.WriteLine("Ezt a kört te nyerted!");
        }
        if (oponent_shows == "kő" || oponent_shows == "olló")
        {
            oponent_points++;
            Console.WriteLine("Ezt a kört veszteted :c");
        }
        if (oponent_shows == player_shows)
        {
            Console.WriteLine("döntetlen!");
        }

    }

    if (player_shows == "Spock")
    {
        if (oponent_shows == "olló" || oponent_shows == "kő")
        {
            player_points++;
            Console.WriteLine("Ezt a kört te nyerted!");
        }
        if (oponent_shows == "papír" || oponent_shows == "gyík")
        {
            oponent_points++;
            Console.WriteLine("Ezt a kört veszteted :c");
        }
        if (oponent_shows == player_shows)
        {
            Console.WriteLine("döntetlen!");
        }
    }
    Console.WriteLine();
    Console.WriteLine($"pontjaid: {player_points}");
    Console.WriteLine($"ellenfeled pontjai: {oponent_points}");

    //Ponthatár
    if (oponent_points == 3)
    {
        Console.Clear();
        Console.WriteLine("vesztettél! majd legközelebb :c");
        break;
    }
    if (player_points == 3)
    {
        Console.Clear();
        Console.WriteLine("Gratula, győztél! c:");
        break;
    }

}
Console.ReadKey();