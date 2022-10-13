
int sides;
int roll1;
int roll2;
int rollTotal;
bool runAgain = true;

while (runAgain)
{
    while (true)
    {
        Console.WriteLine("Please enter the number of sides the dice have.");
        if (int.TryParse(Console.ReadLine(), out sides) && sides >= 1)
        {
            Console.WriteLine($"Now rolling dice with {sides} sides...");
            break;
        }
        else
        {
            Console.WriteLine("Sorry, that is not a valid number. Please try again.");
        }
    }

    if (sides == 6)
    {
        roll1 = DiceRoller(sides);
        roll2 = DiceRoller(sides);
        rollTotal = roll1 + roll2;
        Console.WriteLine($"You rolled a {roll1} and a {roll2} for a total of {rollTotal}!");
        Console.WriteLine(sixSidedDie(roll1, roll2));
    }
    else
    {
        roll1 = DiceRoller(sides);
        roll2 = DiceRoller(sides);
        rollTotal = roll1 + roll2;
        Console.WriteLine($"You rolled a {roll1} and a {roll2} for a total of {rollTotal}!");
    }
    runAgain = GoAgain();
}

// Methods

int DiceRoller(int diceSides)
{
    Random roll = new Random();
    return roll.Next(diceSides) + 1;

}

string sixSidedDie(int roll1, int roll2)
{
    {
        string message = " ";

        if (roll1 == 1 && roll2 == 1)
        {
            message = "Snake Eyes and Craps!";
        }
        if ((roll1 == 2 && roll2 == 1) || (roll1 == 2 && roll2 == 1))
        {
            message = "Ace deuce and craps!";
        }
        if (roll1 == 6 && roll2 == 6)
        {
            message = "Box Cars and Craps!";
        }
        if ((roll1 + roll2 == 7) || (roll1 + roll2 == 11))
        {
            message = "We've got a winner!";
        }
        return message;
    }
}

bool GoAgain()
{
    while (true)
    {
        Console.WriteLine("Would you like to roll again (y/n)?");
        string userAnswer = Console.ReadLine();

        if (userAnswer.ToLower().Trim() == "y")
        {
            return true;
        }
        else if (userAnswer.ToLower().Trim() == "n")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Sorry, that is not a valid response. Try again.");
        }
    }
}

