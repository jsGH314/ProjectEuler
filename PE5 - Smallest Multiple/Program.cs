public class PE5
{
    // O(n) solution - second iteration
    static void Main(string[] args)
    {
        PE5 pe5 = new PE5();
        System.Console.WriteLine(pe5.SmallestMultiple());
    }

    public int SmallestMultiple()
    {
        int number = 20; // Start from the smallest multiple of 20
        while (true)
        {
            if (IsDivisibleByAll(number))
            {
                return number;
            }
            number += 20; // Increment by 20 since the number must be divisible by 20
        }
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

