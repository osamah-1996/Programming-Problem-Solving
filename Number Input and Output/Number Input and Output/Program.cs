namespace Number_Input_and_Output
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Write a program that allows the user to enter a number then print it.
            int userInput;
            Console.Write("Please Enter a Number :");
            int.TryParse(Console.ReadLine(), out userInput);
            Console.WriteLine($"The Number You have Entered is {userInput}");
            #endregion




        }
    }
}
