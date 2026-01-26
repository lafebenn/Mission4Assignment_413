namespace Mission4_Assignment;

public class Team2
{
    public bool ValidInput(string input, string[] board)
    {
        // convert to integer
        int choice;
        bool isNumber = int.TryParse(input, out choice);
        if (isNumber == false)
        {
            Console.WriteLine("Invalid input. Please enter a number: ");
            return false;

        }
        // check range
        if (choice < 1 || choice > 9)
        {
            Console.WriteLine("Invalid input. Please choose a position (1-9): ");
            return false;

        }

        // check if position is already taken
        if (board[choice - 1] == "X" || board[choice - 1] == "O")
        {
            Console.WriteLine("Position already taken. Please choose another position (1-9): ");
            return false;
        }


        return true;
    }

    
    // Check to see if there is a winner    
    public string IsWinner(List<string> board)
    {
        List<string> playerChoices = new List<string>();
        bool isWinner = false;
        string winner = "";
        if (playerChoices.Contains("1"))
        {
            if (playerChoices.Contains("2") && playerChoices.Contains("3"))
            {
                Console.WriteLine("You won!");
                isWinner = true;
            }
        }

        else if (playerChoices.Contains("1"))
        {
            if (playerChoices.Contains("4") && playerChoices.Contains("7"))
            {
                Console.WriteLine("You won!");
                isWinner = true;
            }
        }
        else if (playerChoices.Contains("1"))
        {
            if (playerChoices.Contains("4") && playerChoices.Contains("7"))
            {
                Console.WriteLine("You won!");
                isWinner = true;
            }
        }
        else if (playerChoices.Contains("1"))
        {
            if (playerChoices.Contains("5") && playerChoices.Contains("9"))
            {
                Console.WriteLine("You won!");
                isWinner = true;
            }
        }
        else if (playerChoices.Contains("2"))
        {
            if (playerChoices.Contains("5") && playerChoices.Contains("8"))
            {
                Console.WriteLine("You won!");
                isWinner = true;
            }
        }
        else if (playerChoices.Contains("3"))
        {
            if (playerChoices.Contains("6") && playerChoices.Contains("9"))
            {
                Console.WriteLine("You won!");
                isWinner = true;
            }
        }
        else if (playerChoices.Contains("3"))
        {
            if (playerChoices.Contains("5") && playerChoices.Contains("7"))
            {
                Console.WriteLine("You won!");
                isWinner = true;
            }
        }
        else if (playerChoices.Contains("4"))
        {
            if (playerChoices.Contains("5") && playerChoices.Contains("6"))
            {
                Console.WriteLine("You won!");
                isWinner = true;
            }
        }
        else if (playerChoices.Contains("7"))
        {
            if (playerChoices.Contains("8") && playerChoices.Contains("9"))
            {
                Console.WriteLine("You won!");
                isWinner = true;
            }
        }

        if (isWinner == true)
        {
            winner = "You won!";
        }
        return winner;
    }
}