namespace MethodOverloadingDemoCSharp_41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var addedInts = Add(2, 2);
            var addedDoubles = Add(3.5, 6.9);
            var addedDecs = Add(2.0m, 2.0m);

            Greet("Seth");
            Greet("Snake", "Plissken");
            Greet("Seth", "Bowman", 29);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static void Greet(string firstName)
        {
            Console.WriteLine($"Hello, {firstName}!");
        }

        public static void Greet(string firstName, string lastName)
        {
            Console.WriteLine($"Hello, {firstName} {lastName}!");
        }

        public static void Greet(string firstName, string lastName, int age)
        {
            if(age >= 18)
            {
                Console.WriteLine($"Hello, {firstName} {lastName}! You are {age} so you can vote!");
            }
            else
            {
                Console.WriteLine($"Hello, {firstName} {lastName}! You are {age} so you can't vote!");
            }
        }
    }
}