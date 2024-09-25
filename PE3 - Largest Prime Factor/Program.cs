//What is the largest prime factor of the number 600851475143?
//A prime factor of a number cannot be more than the square root of it.
public class PE3
{
    static void Main(string[] args)
    {
        PE3 pe3 = new PE3();
        long number = 600851475143;
        long largestPrimeFactor = pe3.FindLargestPrimeFactor(number);
        Console.WriteLine(largestPrimeFactor);
    }

    public long FindLargestPrimeFactor(long number)
    {
        long largestPrimeFactor = 0;
        //start at 2
        long factor = 2;

        //while number is positive integer greater than 1
        while (number > 1)
        {
            //if number is divisible by factor
            if (number % factor == 0)
            { 
                //divide number by factor
                number /= factor;
                //set largestPrimeFactor to factor
                largestPrimeFactor = factor;
            }
            else
            {
                //increment factor
                factor++;
            }
        }

        return largestPrimeFactor;
    }
}
