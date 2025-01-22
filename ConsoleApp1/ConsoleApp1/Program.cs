namespace ConsoleApp1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number to calculate fibonocis");
            int x = Convert.ToInt32( Console.ReadLine());
            double finonocis = Program.fibo(x);
            Console.WriteLine("Fibonocis value of the given number is :" + finonocis);

        }
        public static double fibo(int x)
        {
            if (x > 0)
            {
                return x * fibo(x - 1);
            }
            return 1;
        }
    }
}