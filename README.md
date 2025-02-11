# Robot Simulator - C# Console Application

## 🚀 Overview
A console application that simulates a toy robot moving on a 5x5 grid, responding to a set of commands.

## 🛠 How to Run
### 1. Clone Repository
```bash
git clone https://github.com/nhn-nguyenhoangnam/robot-simulator.git
cd robot-simulator
```

### 2. Build and Run
```bash
dotnet build
dotnet run
```

## 📜 Commands
- `PLACE X,Y,F` - Place the robot at (X,Y) facing (NORTH, SOUTH, EAST, WEST).
- `MOVE` - Move the robot one unit forward.
- `LEFT` / `RIGHT` - Rotate the robot 90 degrees.
- `REPORT` - Output the robot's current position and direction.
- `EXIT` - Close the application.

## 📂 Example Test Case
```txt
PLACE 0,0,NORTH
MOVE
REPORT
```
**Expected Output:**
```txt
0,1,NORTH
```
