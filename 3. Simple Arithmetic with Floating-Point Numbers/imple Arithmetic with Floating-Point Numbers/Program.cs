using System;

namespace imple_Arithmetic_with_Floating_Point_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            bool isPareced;
            float fNumber;
            string charr;
            float SNumber;


            do
            {
                Console.Write("Please Enter the First Number:");
                isPareced = float.TryParse(Console.ReadLine(), out  fNumber);
          
            } while (!isPareced); 
            
            do
            {
                Console.Write("Please Enter the Second Number:");
                isPareced = float.TryParse(Console.ReadLine(), out  SNumber);



            } while (!isPareced); 
            
             
                Console.Write("Please Enter the Operation (+ - / *):");
                 charr = Console.ReadLine();


            float addiation = fNumber + SNumber;
            float subtraction = fNumber - SNumber;
            float multiplication = fNumber * SNumber;
            float diviion = fNumber / SNumber;
            switch (charr)
            {
                
                case "+":
                    Console.WriteLine(string.Format("{0}  + {1}  = {2}", fNumber, SNumber, addiation));
                    break; 
                case "-":
                    Console.WriteLine(string.Format("{0}  - {1}  = {2}", fNumber, SNumber, subtraction));
                    break; 
                case "*":
                    Console.WriteLine(string.Format("{0}  X {1}  = {2}", fNumber, SNumber, multiplication));
                    break;
                case "/":
                    Console.WriteLine(string.Format("{0}  /  {1}  = {2}", fNumber, SNumber, diviion));
                    break;
            }


            #endregion
        }
    }
}
