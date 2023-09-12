using lab5;

CustomTimer timer = new CustomTimer(1000, () =>
{
    double x = GetRandomValue(); // getting random x
    double result = CalculateFunction(x); // calculating function for x
    Console.WriteLine($"x = {x}, f(x) = {result}");
});

timer.Start();

Console.WriteLine("Press Enter to stop this thread...");
Console.ReadLine();
timer.Stop();

static double GetRandomValue()
{
    Random random = new Random();
    return random.NextDouble() * 10 - 5; // generating x [-5, 5]
}

static double CalculateFunction(double x)
{
    if (-3 <= x && x <= 3)
    {
        return 2 / (x * x) + 1;
    }
    else
    {
        if (x == 0)
        {
            throw new ArgumentException("x can't be 0");
        }
        return Math.Abs((x * x * x - 7) / x);
    }
}
