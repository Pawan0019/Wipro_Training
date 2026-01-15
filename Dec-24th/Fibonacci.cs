class Fibonacci
{
     static void Main()
    {
        static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    Console.WriteLine(Fibonacci(20));
    }
}