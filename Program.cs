const int SHORT = 1;
const int REGULAR = 2;
const int DOUBLE = 3;
const int COSTUM = 4;

int gamecounterplayer1;
int gamecounterplayer2;
int pointcounterplayer1;
int pointcounterplayer2;

Console.WriteLine("Which type of match will be played? Press (1) for short, (2) for regular, (3) for double, (4) for custom");
int gametype = int.Parse(Console.ReadLine()!);

Console.WriteLine("Press any key to select randomly which player gets the service (1 is player1 and 2 is player2).");
Console.ReadKey();
int service = Random.Shared.Next(1, 3);
Console.WriteLine(service);

if (gametype == SHORT)
{
    gamecounterplayer1 = 0;
    gamecounterplayer2 = 0;
    pointcounterplayer1 = 0;
    pointcounterplayer2 = 0;

    while (gamecounterplayer1 < 1 && gamecounterplayer2 < 1)
    {
        Console.WriteLine("Player" + service + "has service.");
        Console.WriteLine("Who made a point? Press (1) for player1 or (2) for player2 or (3) for quit.");
        int point = int.Parse(Console.ReadLine()!);
        if (point == 1)
        {
            pointcounterplayer1 += 1;
            Console.WriteLine("Points:" + pointcounterplayer1 + ":" + pointcounterplayer2);
            Console.WriteLine("Games:" + gamecounterplayer1 + ":" + gamecounterplayer2);
            if ((pointcounterplayer1 + pointcounterplayer2) % 2 == 0 && service == 1)
            {
                service += 1;
            }
            else if ((pointcounterplayer1 + pointcounterplayer2) % 2 == 0 && service == 2)
            {
                service -= 1;
            }
        }
        else if (point == 2)
        {
            pointcounterplayer2 += 1;
            Console.WriteLine("Points:" + pointcounterplayer1 + ":" + pointcounterplayer2);
            Console.WriteLine("Games:" + gamecounterplayer1 + ":" + gamecounterplayer2);
            if ((pointcounterplayer1 + pointcounterplayer2) % 2 == 0 && service == 1)
            {
                service += 1;
            }
            else if ((pointcounterplayer1 + pointcounterplayer2) % 2 == 0 && service == 2)
            {
                service -= 1;
            }
        }
        else if (point == 3)
        {
            gamecounterplayer1 += 10;
            gamecounterplayer2 += 10;
        }
        if (pointcounterplayer1 == 11)
        {
            Console.WriteLine("Player1 won this game!");
            pointcounterplayer1 = 0;
            pointcounterplayer2 = 0;
            gamecounterplayer1 += 1;
            Console.WriteLine();
        }
        else if (pointcounterplayer2 == 11)
        {
            Console.WriteLine("Player2 won this game!");
            pointcounterplayer1 = 0;
            pointcounterplayer2 = 0;
            gamecounterplayer2 += 1;
            Console.WriteLine();
        }
    }
    if (gamecounterplayer1 == 1)
    {
        Console.WriteLine("Player1 won the match!");
    }
    else if (gamecounterplayer2 == 1)
    {
        Console.WriteLine("Player2 won the match!");
    }
    else if (gamecounterplayer1 > 1)
    {
        Console.WriteLine("The game stopped!");
    }
}
if (gametype == REGULAR)
{
    gamecounterplayer1 = 0;
    gamecounterplayer2 = 0;
    pointcounterplayer1 = 0;
    pointcounterplayer2 = 0;

    while (gamecounterplayer1 < 4 && gamecounterplayer2 < 4)
    {
        Console.WriteLine("Player" + service + "has service.");
        Console.WriteLine("Who made a point? Press (1) for player1 or (2) for player2 or (3) for quit.");
        int point = int.Parse(Console.ReadLine()!);
        if (point == 1)
        {
            pointcounterplayer1 += 1;
            Console.WriteLine("Points:" + pointcounterplayer1 + ":" + pointcounterplayer2);
            Console.WriteLine("Games:" + gamecounterplayer1 + ":" + gamecounterplayer2);
            if ((pointcounterplayer1 + pointcounterplayer2) % 2 == 0 && service == 1)
            {
                service += 1;
            }
            else if ((pointcounterplayer1 + pointcounterplayer2) % 2 == 0 && service == 2)
            {
                service -= 1;
            }
        }
        else if (point == 2)
        {
            pointcounterplayer2 += 1;
            Console.WriteLine("Points:" + pointcounterplayer1 + ":" + pointcounterplayer2);
            Console.WriteLine("Games:" + gamecounterplayer1 + ":" + gamecounterplayer2);
            if ((pointcounterplayer1 + pointcounterplayer2) % 2 == 0 && service == 1)
            {
                service += 1;
            }
            else if ((pointcounterplayer1 + pointcounterplayer2) % 2 == 0 && service == 2)
            {
                service -= 1;
            }
        }
        else if (point == 3)
        {
            gamecounterplayer1 += 10;
            gamecounterplayer2 += 10;
        }
        if (pointcounterplayer1 == 11)
        {
            Console.WriteLine("Player1 won this game!");
            pointcounterplayer1 = 0;
            pointcounterplayer2 = 0;
            gamecounterplayer1 += 1;
            Console.WriteLine();
        }
        else if (pointcounterplayer2 == 11)
        {
            Console.WriteLine("Player2 won this game!");
            pointcounterplayer1 = 0;
            pointcounterplayer2 = 0;
            gamecounterplayer2 += 1;
            Console.WriteLine();
        }

    }
    if (gamecounterplayer1 == 4)
    {
        Console.WriteLine("Player1 won the match!");
    }
    else if (gamecounterplayer2 == 4)
    {
        Console.WriteLine("Player2 won the match!");
    }
    else if (gamecounterplayer1 > 4)
    {
        Console.WriteLine("The game stopped!");
    }
}
if (gametype == DOUBLE)
{
    gamecounterplayer1 = 0;
    gamecounterplayer2 = 0;
    pointcounterplayer1 = 0;
    pointcounterplayer2 = 0;

    while (gamecounterplayer1 < 3 && gamecounterplayer2 < 3)
    {
        Console.WriteLine("Player" + service + "has service.");
        Console.WriteLine("Who made a point? Press (1) for player1 or (2) for player2 or (3) for quit.");
        int point = int.Parse(Console.ReadLine()!);
        if (point == 1)
        {
            pointcounterplayer1 += 1;
            Console.WriteLine("Points:" + pointcounterplayer1 + ":" + pointcounterplayer2);
            Console.WriteLine("Games:" + gamecounterplayer1 + ":" + gamecounterplayer2);
            if ((pointcounterplayer1 + pointcounterplayer2) % 2 == 0 && service == 1)
            {
                service += 1;
            }
            else if ((pointcounterplayer1 + pointcounterplayer2) % 2 == 0 && service == 2)
            {
                service -= 1;
            }
        }
        else if (point == 2)
        {
            pointcounterplayer2 += 1;
            Console.WriteLine("Points:" + pointcounterplayer1 + ":" + pointcounterplayer2);
            Console.WriteLine("Games:" + gamecounterplayer1 + ":" + gamecounterplayer2);
            if ((pointcounterplayer1 + pointcounterplayer2) % 2 == 0 && service == 1)
            {
                service += 1;
            }
            else if ((pointcounterplayer1 + pointcounterplayer2) % 2 == 0 && service == 2)
            {
                service -= 1;
            }
        }
        else if (point == 3)
        {
            gamecounterplayer1 += 10;
            gamecounterplayer2 += 10;
        }
        if (pointcounterplayer1 == 11)
        {
            Console.WriteLine("Player1 won this game!");
            pointcounterplayer1 = 0;
            pointcounterplayer2 = 0;
            gamecounterplayer1 += 1;
            Console.WriteLine();
        }
        else if (pointcounterplayer2 == 11)
        {
            Console.WriteLine("Player2 won this game!");
            pointcounterplayer1 = 0;
            pointcounterplayer2 = 0;
            gamecounterplayer2 += 1;
            Console.WriteLine();
        }
    }
    if (gamecounterplayer1 == 3)
    {
        Console.WriteLine("Player1 won the match!");
    }
    else if (gamecounterplayer2 == 3)
    {
        Console.WriteLine("Player2 won the match!");
    }
    else if (gamecounterplayer1 > 3)
    {
        Console.WriteLine("The game stopped!");
    }
}
if (gametype == COSTUM)
{
    Console.WriteLine("How many games should your match have?");
    int numberofgames = int.Parse(Console.ReadLine()!);
    while (numberofgames % 2 == 0 && numberofgames > 10)
    {
        Console.WriteLine("How many games should your match have?");
        numberofgames = int.Parse(Console.ReadLine()!);
    }

    gamecounterplayer1 = 0;
    gamecounterplayer2 = 0;
    pointcounterplayer1 = 0;
    pointcounterplayer2 = 0;

    while (gamecounterplayer1 <= numberofgames / 2 && gamecounterplayer2 <= numberofgames / 2)
    {
        Console.WriteLine("Player" + service + "has service.");
        Console.WriteLine("Who made a point? Press (1) for player1 or (2) for player2 or (3) for quit.");
        int point = int.Parse(Console.ReadLine()!);
        if (point == 1)
        {
            pointcounterplayer1 += 1;
            Console.WriteLine("Points:" + pointcounterplayer1 + ":" + pointcounterplayer2);
            Console.WriteLine("Games:" + gamecounterplayer1 + ":" + gamecounterplayer2);
            if ((pointcounterplayer1 + pointcounterplayer2) % 2 == 0 && service == 1)
            {
                service += 1;
            }
            else if ((pointcounterplayer1 + pointcounterplayer2) % 2 == 0 && service == 2)
            {
                service -= 1;
            }
        }
        else if (point == 2)
        {
            pointcounterplayer2 += 1;
            Console.WriteLine("Points:" + pointcounterplayer1 + ":" + pointcounterplayer2);
            Console.WriteLine("Games:" + gamecounterplayer1 + ":" + gamecounterplayer2);
            if ((pointcounterplayer1 + pointcounterplayer2) % 2 == 0 && service == 1)
            {
                service += 1;
            }
            else if ((pointcounterplayer1 + pointcounterplayer2) % 2 == 0 && service == 2)
            {
                service -= 1;
            }
        }
        else if (point == 3)
        {
            gamecounterplayer1 += 10;
            gamecounterplayer2 += 10;
        }
        if (pointcounterplayer1 == 11)
        {
            Console.WriteLine("Player1 won this game!");
            pointcounterplayer1 = 0;
            pointcounterplayer2 = 0;
            gamecounterplayer1 += 1;
            Console.WriteLine();
        }
        else if (pointcounterplayer2 == 11)
        {
            Console.WriteLine("Player2 won this game!");
            pointcounterplayer1 = 0;
            pointcounterplayer2 = 0;
            gamecounterplayer2 += 1;
            Console.WriteLine();
        }
    }
    if (gamecounterplayer1 > numberofgames / 2)
    {
        Console.WriteLine("Player1 won the match!");
    }
    else if (gamecounterplayer2 > numberofgames / 2)
    {
        Console.WriteLine("Player2 won the match!");
    }
    else if (gamecounterplayer1 >= 10)
    {
        Console.WriteLine("The game stopped!");
    }
}

