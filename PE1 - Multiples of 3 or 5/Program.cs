//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
//The sum of these multiples is 23.
//Find the sum of all the multiples of 3 or 5 below 1000.

public class PE1
{
    static void Main(string[] args)
    {
        //using linq
        var total = Enumerable.Range(0, 1000)
                        .Where(counter => (counter % 3 == 0) || (counter % 5 == 0))
                        .Sum();

        Console.WriteLine(total);
        Console.ReadKey();
    }

    //first iteration
    public int FindSumOfMultiples(int number)
    {
        int sum = 0;
        for (int i = 0; i < number; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }
}





