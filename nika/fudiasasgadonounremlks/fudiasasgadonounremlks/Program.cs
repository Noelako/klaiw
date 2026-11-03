using fudiasasdagonounremlks;
using fudiasasgadonounremlks;
using Microsoft.Win32.SafeHandles;


coord gridDimensions = new coord(50, 20);
coord snakePos = new coord(10, 1);
Random rand = new Random();
coord aapple = new coord(rand.Next(1, gridDimensions.X - 1), rand.Next(1, gridDimensions.Y - 1));
int framedelay = 25;
direction movementdirection = direction.down;
int score = 0;

List<coord> snakePosH= new List<coord>();
int tailL = 1;

while (true)
{
    Console.Clear();
    Console.WriteLine("                 ! score: " + score+" !");
    snakePos.ApplyMove(movementdirection);

    for (int y = 0; y < gridDimensions.Y; y++)
    {
        for (int x = 0; x < gridDimensions.X; x++)
        {

            coord currentcoord = new coord(x, y);

            if (snakePos.Equals(currentcoord) || snakePosH.Contains(currentcoord))
                Console.Write(snakePos.snaky);
            else if (aapple.Equals(currentcoord))
                Console.Write("@");
            else if (x == 0 || x == gridDimensions.X - 1)
                Console.Write("|");
            else if (y == 0 || y == gridDimensions.Y - 1) 
                Console.Write("-");
            else
                Console.Write(" ");

        }
        Console.WriteLine();
    }

    if (snakePos.Equals(aapple))
    {
        tailL++;
        score++;
        aapple = new coord(rand.Next(1, gridDimensions.X - 1), rand.Next(1, gridDimensions.Y - 1));
    }

    else if (snakePos.X == 0 || snakePos.Y == 0 || snakePos.X == gridDimensions.X - 1 || snakePos.Y == gridDimensions.Y - 1|| snakePosH.Contains(snakePos))
    {


        score = 0;
        tailL = 0;
        snakePos = new coord(10, 1);
        snakePosH.Clear();
        movementdirection = direction.down;
        continue;
    } 
    snakePosH.Add(new coord(snakePos.X, snakePos.Y));

    if (snakePosH.Count > tailL)
        snakePosH.RemoveAt(0);

    DateTime time = DateTime.Now;

    while((DateTime.Now-time).Milliseconds < framedelay)
    {
        if (Console.KeyAvailable)
        {
            ConsoleKey key = Console.ReadKey().Key;

            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    movementdirection = direction.left;
                    break;
                case ConsoleKey.RightArrow:
                    movementdirection= direction.right; 
                    break;
                case ConsoleKey.UpArrow:
                    movementdirection=(direction.up);
                    break;
                case ConsoleKey.DownArrow:
                    movementdirection=direction.down;
                    break;

            }
        }
    }

}