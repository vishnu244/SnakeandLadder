// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Snake and Ladder!");

int playerposition = 0;
Random random = new Random();
int rollDie = random.Next(1, 7);
Console.WriteLine(rollDie);
int options = random.Next(0, 3);
switch (options)
{
    case 0:
        Console.WriteLine("NO_PLAY");
        playerposition = 0;
        break;
    case 1:
        Console.WriteLine("LADDER");
        playerposition += rollDie;
        break;
    case 2:
        Console.WriteLine("SNAKE");
        playerposition -= rollDie;
        if (playerposition < 0)
        {
            playerposition = 0;
        }
        break;
    default:
        break;
}
Console.WriteLine(playerposition);