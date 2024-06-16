class SumDigits
{
    public static void Main(string[] args)
    {

        int number = int.Parse(Console.ReadLine());

        int sum = 0;


        while (number > 0)
        {
           int sumDigits = number % 10;
           sum += sumDigits;
            number /= 10;
        }

        Console.WriteLine($"{sum}");
    }
}