
//weakreference permits Garbage Collector to clean the object. and at the same time,
//allows to access the object until the Garbage collector collects the object.
//Below code checks if the 
namespace GC_WeekReference
{
    public class Program
    {
        static WeakReference weakReference = new WeakReference(null);
        public static void Main()
        {
            CreateWeekReference();
            while (weakReference.IsAlive)
                {
               // SomeClass gcsome = new SomeClass(); //provoking GC 
                Console.WriteLine(weakReference.IsAlive);
                }            
        }

        public class SomeClass
        {
            public int x;
            
        }
        public static void CreateWeekReference()
        {           

            SomeClass sc = new SomeClass();
            sc.x = 1;
            weakReference.Target = sc;
        }
    }
}