
namespace Handling_Multiple_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HandleMultipleExceptions("2" ,2);
            HandleMultipleExceptions("A" ,3);
            HandleMultipleExceptions("2" ,4);
        }

        private static void HandleMultipleExceptions(string inputString, int arrayIndex )
        {
            int[] numbers = { 1, 2, 3 };

            try
            {
                int parsednumber = Int32.Parse(inputString);
                int testIndexNumber = numbers[arrayIndex];

                Console.WriteLine("Correct input");

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format");
            }
            catch (IndexOutOfRangeException) 
            {
                Console.WriteLine("Index out of range");
            }
        }
    }
}
