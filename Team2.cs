namespace Mission4_Assignment;

public class Team2
{
    
}




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