using KataChallangeTests;

namespace KataChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Diamond.Generate(args[0].ToCharArray()[0]));

            Console.ReadLine();
        }
    }
}
