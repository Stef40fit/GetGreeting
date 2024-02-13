//namespace GetGreeting
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            GreetingProvider greetingProvider = new GreetingProvider();
//            string greeting = greetingProvider.GetGreeting();
//            Console.WriteLine(greeting);
//        }
//    }

//}
using GetGreeting.Tests;

namespace GetGreeting
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetingProvider greetingProvider = new GreetingProvider(ITimeProvider(new DateTime(2000, 2, 2)));
            string greeting = greetingProvider.GetGreeting();
            Console.WriteLine(greeting);
        }

        private static ITimeProvider ITimeProvider(DateTime dateTime)
        {
            throw new NotImplementedException();
        }
    }

}