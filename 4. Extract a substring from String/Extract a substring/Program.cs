namespace Extract_a_substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write C# program that Extract a substring from a given string.
            string? userInput;
            Console.Write("Please Enter any String :");
             userInput = Console.ReadLine();
            while (userInput is null)
            {
                Console.Write("Please Enter any String :");
                userInput = Console.ReadLine();
            }
            Console.WriteLine($"The Full Input String is {userInput}");
            Console.WriteLine($"The Sustring Input  is {userInput.Substring(0, 4)}");
            #endregion
        }
    }
}
