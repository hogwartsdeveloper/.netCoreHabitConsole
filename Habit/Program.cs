using System;

namespace Habit
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var client = new Client("Zhannur");

            try
            {
                client.CreateHabit("No tennis", 30);
                client.Done("No Tennis", 31);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}