//猜數字遊戲
System.Console.WriteLine("Welcome~ Let's play a guess number game~");
System.Console.Write("First of all, please enter your name: ");
string name = System.Console.ReadLine();
System.Console.Write($"Hello {name}~\nDo you dare to accept the challenge? (Y/N)");
bool recall = System.Console.ReadLine().ToUpper() == "Y";
int num_min = 1;
int guess;

if (recall==true)
{
    System.Console.WriteLine("WOW! What a brave man.\n There are different mode in our game, which do you want to challenge?");
}
else
{
    System.Console.WriteLine("Oh... Are you a coward? It's okay, I can understand:> \nByeeeeeee.");
    return;
}

System.Console.WriteLine("1. Easy mode: Range(1~100) with 5 times to guess.\n2. Normal mode: Range(1~500) with 20 times to guess.\n3. Hard mode: Range(1~1000) with 25 times to guess.");
System.Console.Write("Please enter the mode number (1, 2, or 3): ");
int mode = System.Convert.ToInt32(System.Console.ReadLine());

if (mode == 1)
{
    System.Console.WriteLine("You have chosen Easy mode. Have fun! :>");
    int num_max = 100;
    int goal = 36; //test, I'll change to be random number.
    int guess_times = 0;
    int guess_limit = 5;

    do
    {
        System.Console.WriteLine($"This is your {guess_times + 1} guess. \nGuess a number between {num_min} ~ {num_max}: ");
        guess = System.Convert.ToInt32(System.Console.ReadLine());
        guess_times++;

        if (guess < goal)
        {
            num_min = guess;
            System.Console.WriteLine("It's too small!");
        }
        else if (guess > goal)
        {
            num_max = guess;
            System.Console.WriteLine("It's too big!");
        }
        else
        {
            System.Console.WriteLine("You guessed it!!!");
            break;
        }
    }
    while(guess_times < guess_limit);
        if (guess_times == guess_limit)
        {
            System.Console.WriteLine("You have used all your guesses. Game over!");
        }
}

else if (mode == 2)
{
    System.Console.WriteLine("You have chosen Normal mode. Good luck:>");
    return;

}
else if (mode == 3)
{
    System.Console.WriteLine("You have chosen Hard mode. Good luck, you really need it:>");
    return;

}
else
{
    System.Console.WriteLine("Invalid mode. Please restart the game and choose a valid mode. Or... Are you afraid?");
}

