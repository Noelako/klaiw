string word= "katzavidi";

int maxLives = 7;
int currentLives = maxLives;
bool win = false;
List<char> guessedLetters = new List<char>();


Console.Write("  __\n");
Console.Write(" |  ] \n");
Console.Write(" |   ");
Console.Write("\n/|        ");

while (currentLives  > 0 && !win)
{     
    foreach(char c in word)
    {
        if (guessedLetters.Contains(c))
            Console.Write(c);
        else
            Console.Write("_ ");
    }
    Console.WriteLine("\n    Please guess a letter ! :3");
    Console.WriteLine("    You currently have " + currentLives + " lives :D");
    char guess = Convert.ToChar(Console.ReadLine());

    if (word.Contains(guess) && !guessedLetters.Contains(guess))
    {
        Console.WriteLine("correct");
    }
    else
    {
        Console.WriteLine("incorrect");
        currentLives--;

    }
    guessedLetters.Add(guess);

    bool wordComplete = true;

    
    foreach (char c in word) 
        if (!guessedLetters.Contains(c))
            
            wordComplete = false;
    win = wordComplete;
}
if (win)
    Console.Write("You win");
else

    Console.WriteLine("You lost ");

