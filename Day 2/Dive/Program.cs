// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var inputFile = File.ReadAllLines("Directions.txt");

var inputList = new List<string>(inputFile);

int horizontalPosition = 0;

int aim = 0;

int depth = 0;

foreach (var input in inputList)
{
    var vals = input.Split(' ');

    int val = int.Parse(vals[1]);

    switch (vals[0])
    {
        case "forward":
            horizontalPosition += val;
            depth += (val * aim);
            break;
        case "down":
            aim += val;
            break;
        case "up":
            aim -= val;
            break;
    }
}

Console.WriteLine($"Final position: {horizontalPosition * depth}");