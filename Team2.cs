namespace Mission4_Assignment;

public class Team2
{
    public bool ValidInput(string input, string[] board)
    {
        int choice;
        bool isNumber = int.TryParse(input, out choice);
        
        if (isNumber == false)
        {
            Console.WriteLine("Invalid input. Please enter a number: ");
            return false;
        }

        if (choice < 1 || choice > 9)
        {
            Console.WriteLine("Invalid input. Please choose a position (1-9): ");
            return false;
        }

        if (board[choice - 1] == "X" || board[choice - 1] == "O")
        {
            Console.WriteLine("Position already taken. Please choose another position (1-9): ");
            return false;
        }

        return true;
    }

    public void PrintBoard(string[] board)
    {
        Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
        Console.WriteLine("----------");
        Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
        Console.WriteLine("----------");
        Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
    }

    public string IsWinner(string[] board)
    {
        string winnerStatement = "";
        bool gameOver = false;

        /* ========================================================== */
        // Player 1 (X) Wins Logic
        
        // Check if X is in top left corner (Position 1)
        if (board[0] == "X")
        {
            // Check Row 1, Col 1, and Diagonal
            if ((board[1] == "X" && board[2] == "X") || 
                (board[3] == "X" && board[6] == "X") || 
                (board[4] == "X" && board[8] == "X"))
            {
                winnerStatement = "Player 1 won!";
                gameOver = true;
            }
        }
        
        // Check if X is in top middle (Position 2)
        if (board[1] == "X")
        {
            if (board[4] == "X" && board[7] == "X")
            {
                winnerStatement = "Player 1 won!";
            }
        }

        // Check if X is in top right corner (Position 3)
        if (board[2] == "X")
        {
            // Check Col 3 and Diagonal (Right to Left)
            if ((board[5] == "X" && board[8] == "X") || 
                (board[4] == "X" && board[6] == "X"))
            {
                winnerStatement = "Player 1 won!";
            }
        }

        // Check if X is in middle left spot (Position 4)
        if (board[3] == "X")
        {
            if (board[4] == "X" && board[5] == "X")
            {
                winnerStatement = "Player 1 won!";
            }
        }

        // Check if X is in bottom left corner (Position 7)
        if (board[6] == "X")
        {
            if (board[7] == "X" && board[8] == "X")
            {
                winnerStatement = "Player 1 won!";
            }
        }


        /* ========================================================== */
        // Player 2 (O) Wins Logic
        

        // Only check for O if X hasn't won yet
        if (winnerStatement == "")
        {
            // Check if O is in top left corner (Position 1)
            if (board[0] == "O")
            {
                if ((board[1] == "O" && board[2] == "O") || 
                    (board[3] == "O" && board[6] == "O") || 
                    (board[4] == "O" && board[8] == "O"))
                {
                    winnerStatement = "Player 2 won!";
                }
            }

            // Check if O is in top middle (Position 2)
            if (board[1] == "O")
            {
                if (board[4] == "O" && board[7] == "O")
                {
                    winnerStatement = "Player 2 won!";
                }
            }

            // Check if O is in top right corner (Position 3)
            if (board[2] == "O")
            {
                if ((board[5] == "O" && board[8] == "O") || 
                    (board[4] == "O" && board[6] == "O"))
                {
                    winnerStatement = "Player 2 won!";
                }
            }

            // Check if O is in middle left spot (Position 4)
            if (board[3] == "O")
            {
                if (board[4] == "O" && board[5] == "O")
                {
                    winnerStatement = "Player 2 won!";
                }
            }

            // Check if O is in bottom left corner (Position 7)
            if (board[6] == "O")
            {
                if (board[7] == "O" && board[8] == "O")
                {
                    winnerStatement = "Player 2 won!";
                }
            }
        }


        /* ========================================================== */
        // Tie Game Logic

        // If no one has won yet, check for a tie
        if (winnerStatement == "")
        {
            bool isTie = true;

            // Loop through board to see if any numbers (1-9) are left
            foreach (string spot in board)
            {
                // If the spot contains a digit, the game is not over
                if (char.IsDigit(spot[0]))
                {
                    isTie = false;
                    break;
                }
            }

            if (isTie)
            {
                winnerStatement = "It's a tie!";
            }
        }

        return winnerStatement;
    }
}