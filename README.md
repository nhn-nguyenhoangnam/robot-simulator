<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Robot Simulator - README</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            line-height: 1.6;
            max-width: 800px;
            margin: 20px auto;
            padding: 20px;
            border: 1px solid #ddd;
            border-radius: 10px;
            background-color: #f9f9f9;
        }
        code {
            background: #eee;
            padding: 3px 6px;
            border-radius: 4px;
        }
        pre {
            background: #eee;
            padding: 10px;
            border-radius: 5px;
            overflow-x: auto;
        }
    </style>
</head>
<body>
    <h1>Robot Simulator - C# Console Application</h1>
    
    <h2>🚀 Overview</h2>
    <p>A console application that simulates a toy robot moving on a 5x5 grid, responding to a set of commands.</p>
    
    <h2>🛠 How to Run</h2>
    <h3>1. Clone Repository</h3>
    <pre><code>git clone https://github.com/nhn-nguyenhoangnam/robot-simulator.git
cd robot-simulator</code></pre>
    
    <h3>2. Build and Run</h3>
    <pre><code>dotnet build
    dotnet run</code></pre>
    
    <h2>📜 Commands</h2>
    <ul>
        <li><code>PLACE X,Y,F</code> - Place the robot at (X,Y) facing (NORTH, SOUTH, EAST, WEST).</li>
        <li><code>MOVE</code> - Move the robot one unit forward.</li>
        <li><code>LEFT</code> / <code>RIGHT</code> - Rotate the robot 90 degrees.</li>
        <li><code>REPORT</code> - Output the robot's current position and direction.</li>
        <li><code>EXIT</code> - Close the application.</li>
    </ul>
    
    <h2>📂 Example Test Case</h2>
    <pre><code>PLACE 0,0,NORTH
MOVE
REPORT</code></pre>
    <p>Expected Output:</p>
    <pre><code>0,1,NORTH</code></pre>
    
    <h2>📝 Author</h2>
    <p>Nguyễn Hoàng Nam</p>
</body>
</html>
