namespace GA_Nested_If_Salvador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine(" You are an adult.");
            }
            else
            {
                Console.WriteLine("You are not an adult.");
            }
        }
    }
}
