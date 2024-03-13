bool flag = true;
int value = 5;

if (value > 0)
{
    int value2 = 6;
    value += value2;
    Console.WriteLine($"Inside the code block: {value2}");
}

// value = 10;
Console.WriteLine($"Outside the code block: {value}");