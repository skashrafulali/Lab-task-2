namespace Lab_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter 'n' your desired number: ");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Even numbers from 1 to {n}:");
            
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }











            Console.ReadKey();
        }
    }
}
