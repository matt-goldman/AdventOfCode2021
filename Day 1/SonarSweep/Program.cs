// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Sonar Sweep!");

int increaseCount = 0;

var inputFile = File.ReadAllLines("SweepInput.txt");

var inputList = new List<string>(inputFile);

Console.WriteLine($"There are {inputList.Count} input values");

int currentVal = 0;

int currentSum = 0;
int lastSum = 0;

int valsPushed = 0;

int[] window = new int[3];

foreach (var input in inputList)
{
    currentVal = int.Parse(input);

    PushValue(currentVal);
    
    if(valsPushed < 2 )
    {
        valsPushed++;
    }
    else
    {
        currentSum = window.Sum();
    }

    if (lastSum > 0 && currentSum > lastSum)
    {
        increaseCount++;
    }

    //Console.WriteLine($"Current sum: {currentSum}, last sum: {lastSum}, is greater: {currentSum > lastSum}");

    lastSum = currentSum;
}

Console.WriteLine($"Total increases: {increaseCount}");

void PushValue(int val)
{
    window[2] = window[1];
    window[1] = window[0];
    window[0] = val;
}