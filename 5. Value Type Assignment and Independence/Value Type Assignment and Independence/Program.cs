namespace Value_Type_Assignment_and_Independence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            bool isParced;
            int userValueType;
            try
            {
                do
                {
                    Console.Write("Please a Value Type number :");
                    isParced = int.TryParse(Console.ReadLine(), out  userValueType); 
                }
                while (!isParced);

                Console.WriteLine($"The Value you Have Entered is {userValueType}");
                userValueType = 100;
                Console.WriteLine($"The Value you Have Entered after reassigning is {userValueType}");

            }
            catch (Exception ex) 
            {
             Console.WriteLine($"the {ex.ToString()} Excepation is Accure.");
            }
             #endregion
        }
    }
}
