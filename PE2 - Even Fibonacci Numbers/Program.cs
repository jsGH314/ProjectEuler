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
        int sum = 0;
        int counter = 0;
        while (Fibonacci(counter) < number)
        {
            if (Fibonacci(counter) % 2 == 0)
            {
                sum += Fibonacci(counter);
            }
            counter++;
        }
        return sum;
    }
    public int Fibonacci(int number) => number == 0 ? 0 : number == 1 ? 1 : Fibonacci(number - 1) + Fibonacci(number - 2);
}
