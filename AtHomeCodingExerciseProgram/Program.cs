using AtHomeCodingExerciseBaseCode;

namespace TestProgram
{
    class Program
    {
        static void Main()
        {
            int[] list = { 1, 5, 2, 1, 10, 12, 25, 1, 18, 235, 5, -3};
            for (int i = -10; i <= 11; i++)
            {
                try
                {
                    Console.WriteLine($"{i}: {AtHomeCodingExercise.aboveBelow(list, i)}");
                    Console.WriteLine($"\t{AtHomeCodingExercise.stringRotation("MyString", i)}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"\tCannot do string rotation. {e.Message}");
                }
            }
        }
    }
}