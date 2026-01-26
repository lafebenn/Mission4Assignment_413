
using Mission4_Assignment;

// initialize variables
string[] board = new string[9];
foreach (var i in Enumerable.Range(0, 9))
{
    board[i] = (i + 1).ToString();
}

bool gameOver = false;

// get class from team 2
Team2 t2 = new Team2();



// =======================================================

// begin game

Console.WriteLine("Welcome to Group 4-3's Tic-Tac-Toe!");

while (gameOver == false)
{
    // player 1 turn
    Console.WriteLine("Player 1, choose a position (1-9): ");
    t2.PrintBoard(board);
    string p1Choice = Console.ReadLine();

    // validate input
    while (t2.ValidInput(p1Choice, board) == false)
    {
        p1Choice = Console.ReadLine();
    }

    // update board
    int p1ChoiceInt = int.Parse(p1Choice) - 1;
    board[p1ChoiceInt] = "X";

    // ==================================================

    // player 2 turn
    Console.WriteLine("Player 2, choose a position (1-9): ");
    t2.PrintBoard(board);
    string p2Choice = Console.ReadLine();

    // validate input
    while (t2.ValidInput(p2Choice, board) == false)
    {
        p2Choice = Console.ReadLine();
    }

    // update board
    int p2ChoiceInt = int.Parse(p2Choice) - 1;
    board[p2ChoiceInt] = "O";


    // pass board to T2, if winner, set gameOver to true


    if (t2.isWinner(board) == 1)
    {
        gameOver = true;
        Console.WriteLine("Player 1 wins!");
    }

    if (t2.isWinner(board) == 2)
    {
        gameOver = true;
        Console.WriteLine("Player 2 wins!");
    }

    if (t2.isWinner(board) == 3)
    {
        gameOver = true;
        Console.WriteLine("It's a tie!");
    }






}

// print final board and thank you message
Console.WriteLine("Final Board:");
t2.PrintBoard(board);
Console.WriteLine("Thanks for playing!");


