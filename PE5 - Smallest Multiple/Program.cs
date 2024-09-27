public class PE5
{
    // O(n) solution
    static void Main(string[] args)
    {
        PE5 pe5 = new PE5();
        System.Console.WriteLine(pe5.SmallestMultiple());
    }

    public int SmallestMultiple()
    {
        foreach (var number in Enumerable.Range(1, int.MaxValue))
        {
            if (IsDivisibleByAll(number))
            {
                return number;
            }
        };
        return 0;
    }

    public bool IsDivisibleByAll(int number)
    {
        for (int i = 1; i <= 20; i++)
        {
            if (number % i != 0)
            {
                return false;
            }
        }
        return true;
    }
}

