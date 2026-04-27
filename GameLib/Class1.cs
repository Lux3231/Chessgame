namespace GameLib;

public class Board
{
    private string BoardLine = "+---+---+---+---+---+---+---+---+";
    private string WhiteField = "| # ";
    private string BlackField = "|   ";


    public override string ToString()
    {
        string result = "";

        for (int row = 0; row < 8; row++)
        {
            result += BoardLine + "\n";

            for (int col = 0; col < 8; col++)
            {
                if((row + col) % 2 == 0){
                    result += WhiteField;
                }
                else{
                    result += BlackField;
                }
            }
            result += "|\n";
        }
        result += BoardLine;

        return result;
    }

}
