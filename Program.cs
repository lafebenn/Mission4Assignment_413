
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
    while(t2.ValidInput() == false)
    {
        Console.WriteLine("Invalid input. Please choose a position (1-9): ");
        p1Choice = Console.ReadLine();
    }

    // update board



}


