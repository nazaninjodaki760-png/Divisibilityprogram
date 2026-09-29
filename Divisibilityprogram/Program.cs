namespace Divisibilityprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, enter your one number : ");
            int oneNumber = int.Parse(Console.ReadLine());
            Console.Write("enter your two number : ");
            int twoNumber=int.Parse(Console.ReadLine());
            if(oneNumber%twoNumber==0)
            {
                Console.WriteLine("is disibility");
            }
            else
            {
                Console.WriteLine("is not disibility");
            }
        }
    }
}
