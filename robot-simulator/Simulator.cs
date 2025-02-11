namespace robot_simulator;

public class Simulator
{
    private Robot robot;

    public Simulator()
    {
        Table table = new Table(5, 5);
        robot = new Robot(table);
    }

    public void ExecuteCommand(string command)
    {
        string[] parts = command.Split(' ');

        if (parts[0] == "PLACE" && parts.Length == 2)
        {
            string[] args = parts[1].Split(',');
            if (args.Length == 3 &&
                int.TryParse(args[0], out int x) &&
                int.TryParse(args[1], out int y) &&
                Enum.TryParse(args[2], out Direction direction))
            {
                robot.Place(x, y, direction);
            }
        }
        else if (command == "MOVE")
        {
            robot.Move();
        }
        else if (command == "LEFT")
        {
            robot.Left();
        }
        else if (command == "RIGHT")
        {
            robot.Right();
        }
        else if (command == "REPORT")
        {
            Console.WriteLine(robot.Report());
        }
    }

    public void Run()
    {
        Console.WriteLine("Enter commands (PLACE X,Y,F | MOVE | LEFT | RIGHT | REPORT | EXIT):");
        while (true)
        {
            string? input = Console.ReadLine();
            if (input == null || input.Trim().ToUpper() == "EXIT") break;
            ExecuteCommand(input.Trim().ToUpper());
        }
    }
}