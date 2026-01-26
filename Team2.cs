namespace Mission4_Assignment;



internal class Team2
{
    string board = "123456789XO";
    public bool ValidInput(string input)
    {
        // convert to integer
        int choice;
        bool isNumber = int.TryParse(input, out choice);
        
        if (isNumber == false)
        {
            return false;
        }
        // check range
        if (choice < 1 || choice > 9)
        {
            return false;
        }
        return true;
    }
    
    if ((board[0]))
}



