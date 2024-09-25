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

        for (int i = 101; i < 1000; i++)
        {
            for (int j = 101; j < 1000; j++)
            {
                int product = i * j;
                if (IsPalindrome(product) && product > largestProduct)
                {
                    largestProduct = product;
                    num1 = i;
                    num2 = j;
                }
            }
        }

        return $"{num1} * {num2} = {largestProduct}";
    }

    public bool IsPalindrome(int number)
    {
        string numberString = number.ToString();
        int length = numberString.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (numberString[i] != numberString[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
