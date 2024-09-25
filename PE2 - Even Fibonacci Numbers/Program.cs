//By considering the terms in the Fibonacci sequence whose values do not exceed four million,
//find the sum of the even-valued terms.
public class PE2
{
    static void Main(string[] args)
    {
        PE2 pe2 = new PE2();
        int sum = pe2.FindSumOfEvenFibonacciNumbers(4000000);
        Console.WriteLine(sum);
    }

    public int FindSumOfEvenFibonacciNumbers(int number)
    {
        int evenSum = 0;
        int fibonacciIndex = 0;
        int fibonacciNumber = 0;

        while ((fibonacciNumber = Fibonacci(fibonacciIndex)) < number)
        {
            if (fibonacciNumber % 2 == 0)
            {
                evenSum += fibonacciNumber;
            }
            fibonacciIndex++;
        }

        return evenSum;
    }

    public int Fibonacci(int number)
    {
        if (number == 0)
        {
            return 0;
        }
        else if (number == 1)
        {
            return 1;
        }

        int[] fibonacciNumbers = new int[number + 1];
        fibonacciNumbers[0] = 0;
        fibonacciNumbers[1] = 1;

        for (int i = 2; i <= number; i++)
        {
            fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
        }

        return fibonacciNumbers[number];
    }
}
