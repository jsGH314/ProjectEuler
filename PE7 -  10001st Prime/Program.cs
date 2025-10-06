/*
 By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
What is the 10001st prime number?
*/

using System;   
using System.Linq;

public class PE7
{
    static void Main(string[] args)
    {
        PE7 pe7 = new PE7();
        Console.WriteLine(pe7.NthPrime(10001));
    }

    public int NthPrime(int n)
    {
        int count = 0;
        int num = 1;
        while (count < n)
        {
            // Increment number to check for primality
            num++;
            if (IsPrime(num))
            {
                // If prime, increment the count
                count++;
            }
        }
        return num;
    }       

    public static bool IsPrime(int num) 
    {
        // Numbers less than or equal to 1 are not prime
        if (num <= 1) return false;
        // 2 is the only even prime number
        if (num == 2) return true;
        // Exclude all other even numbers
        if (num % 2 == 0) return false;
        // Check for divisibility by odd numbers from 3 up to the square root of the number
        int boundary = (int)Math.Floor(Math.Sqrt(num));
        // if a number has a divisor greater than its square root, it must also have a divisor smaller than its square root.
        for (int i = 3; i <= boundary; i += 2)
            if (num % i == 0)
                return false;
        return true;
    }
}
