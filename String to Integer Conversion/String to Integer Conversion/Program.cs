namespace String_to_Integer_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen

            Console.Write("Please Enter a Converable  String :");
            string userInput = Console.ReadLine() ?? "0";

            try{
                int myString = int.Parse(userInput);
                Console.WriteLine($"You have Entered {myString}");
            }
            catch(FormatException) {
                Console.WriteLine($"You have a format Excpation Error");

            }

            #endregion
        }
    }
}
