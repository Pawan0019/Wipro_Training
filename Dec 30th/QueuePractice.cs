public class QueuePractice
{
    public static void Main()
    {
        Queue<int> booking = new Queue<int>();
        booking.Enqueue(10);
        booking.Enqueue(20);
        booking.Enqueue(30);

        booking.Dequeue();
        booking.Count();
        booking.Peek();

        foreach (int number in booking)
        {
            Console.WriteLine(number);
        }
    }
}