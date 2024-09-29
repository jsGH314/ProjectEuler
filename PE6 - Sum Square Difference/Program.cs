/*
The sum of the squares of the first ten natural numbers is,

1^2 + 2^2 + ... + 10^2 = 385.

The square of the sum of the first ten natural numbers is,

(1 + 2 + ... + 10)^2 = 55^2 = 3025.

Hence the difference between the sum of the squares of the first ten natural numbers 
and the square of the sum is 

3025 - 385 = 2640.

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
*/


public class PE6
{ 
    // O(n) solution
    static void Main(string[] args)
    {
        PE6 pe6 = new PE6();
        Console.WriteLine(pe6.SumSquareDifference(100));
    }

    private int SumSquareDifference(int v)
    {
        int sumOfSquares = Enumerable.Range(1, v).Select(x => x * x).Sum();
        int squareOfSum = Enumerable.Range(1, v).Sum();
        squareOfSum *= squareOfSum;

        return (squareOfSum - sumOfSquares);
    }
}