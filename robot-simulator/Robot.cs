namespace robot_simulator;

public class Robot
{
    private int x, y;
    private Direction direction;
    private bool isPlaced = false;
    private Table table;

    public Robot(Table table)
    {
        this.table = table;
    }

    public void Place(int x, int y, Direction direction)
    {
        if (table.IsValidPosition(x, y))
        {
            this.x = x;
            this.y = y;
            this.direction = direction;
            isPlaced = true;
        }
    }

    public void Move()
    {
        if (!isPlaced) return;

        int newX = x, newY = y;
        switch (direction)
        {
            case Direction.NORTH: newY++; break;
            case Direction.EAST: newX++; break;
            case Direction.SOUTH: newY--; break;
            case Direction.WEST: newX--; break;
        }

        if (table.IsValidPosition(newX, newY))
        {
            x = newX;
            y = newY;
        }
    }

    public void Left()
    {
        if (!isPlaced) return;
        direction = (Direction)(((int)direction + 3) % 4);
    }

    public void Right()
    {
        if (!isPlaced) return;
        direction = (Direction)(((int)direction + 1) % 4);
    }

    public string Report()
    {
        if (!isPlaced) return "Robot not placed on the table.";
        return $"{x},{y},{direction}";
    }
}