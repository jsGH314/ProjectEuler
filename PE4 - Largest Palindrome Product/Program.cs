public class PE4
{
    static void Main(string[] args)
    {
        PE4 pe4 = new PE4();
        string result = pe4.GetLargestPalindromeProduct();
        Console.WriteLine(result);
    }

    public string GetLargestPalindromeProduct()
    {
        int largestProduct = 0;
        int num1 = 0;
        int num2 = 0;

        // Start from the largest possible value and decrement
        // 999 to 101 so we can find three digit numbers
        for (int i = 999; i >= 101; i--)
        {
            for (int j = 999; j >= i; j--)
            {
                int product = i * j;

                // Check for palindrome without converting to string
                if (IsPalindrome(product))
                {
                    if (product > largestProduct)
                    {
                        largestProduct = product;
                        num1 = i;
                        num2 = j;
                    }
                    // Break out of the loop if product is smaller than largestProduct
                    else
                    {
                        break;
                    }
                }
            }
        }

        return $"{num1} * {num2} = {largestProduct}";
    }

    public bool IsPalindrome(int number)
    {
        int reverse = 0;
        int original = number;

        while (number > 0)
        {
            int remainder = number % 10;
            reverse = (reverse * 10) + remainder;
            number /= 10;
        }

        return original == reverse;
    }
}
