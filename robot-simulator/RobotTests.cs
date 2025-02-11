using Xunit;

namespace robot_simulator;

public class RobotTests
{
    private Table table = new Table(5, 5);
    private Robot robot;

    public RobotTests()
    {
        robot = new Robot(table);
    }

    [Fact]
    public void Test_Place_And_Report()
    {
        robot.Place(0, 0, Direction.NORTH);
        Assert.Equal("0,0,NORTH", robot.Report());
    }

    [Fact]
    public void Test_Move_Within_Boundaries()
    {
        robot.Place(0, 0, Direction.NORTH);
        robot.Move();
        Assert.Equal("0,1,NORTH", robot.Report());
    }

    [Fact]
    public void Test_Move_Outside_Boundaries()
    {
        robot.Place(0, 4, Direction.NORTH);
        robot.Move();
        Assert.Equal("0,4,NORTH", robot.Report()); // Không được di chuyển vượt qua bàn
    }

    [Fact]
    public void Test_Left_Turn()
    {
        robot.Place(0, 0, Direction.NORTH);
        robot.Left();
        Assert.Equal("0,0,WEST", robot.Report());
    }

    [Fact]
    public void Test_Right_Turn()
    {
        robot.Place(0, 0, Direction.NORTH);
        robot.Right();
        Assert.Equal("0,0,EAST", robot.Report());
    }
}