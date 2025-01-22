namespace ParameterTypes
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = 10;
            int num1 = 100;
            int num2 = 200;

            Console.WriteLine("Before function calll X value : " + x);
            Program.PassParam(ref x);
            Console.WriteLine("After function calll X value : " + x);

            Program.Maths(num1, num2, out int sum, out int sub);
            Console.WriteLine("Sum of the numbers = : "+ sum + " Sub = : " + sub);
        }
        public static void PassParam(ref int i)
        {
            i = 200;
            Console.WriteLine("After function calll i value : " + i);
        }

        public static void Maths(int num1, int num2,out int x, out int y)
        {
            x = num1 + num2;
            y = num1 - num2;
        }
    }
}