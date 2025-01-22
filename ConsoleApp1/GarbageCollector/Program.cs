namespace GarbageCollector
{
    public class Program{
        public static void Main()
        {
            Console.WriteLine("Press Something to start the profiler");
            Console.Read();
            for (double i = 0; i <= 100000000000000; i++)
            {
                SomeClass x = new SomeClass();
                x.x = 10;
                x.Dispose();
            }
            
        }

        public class SomeClass() : IDisposable
        {
            public int x;

            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }
}