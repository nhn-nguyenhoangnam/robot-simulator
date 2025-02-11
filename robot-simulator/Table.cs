namespace robot_simulator;

public class Table
{
    private int width;
    private int height;

    public Table(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public bool IsValidPosition(int x, int y)
    {
        return x >= 0 && x < width && y >= 0 && y < height;
    }
}